using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DBMaster
{
    public partial class DbCopyForm : Form
    {
        private string pathsource;
        public string PathSource
        {
            get
            {
                return pathsource;
            }
            set
            {
                pathsource = value;
            }

        }

        private string pathdest;
        public string PathDest
        {
            get
            {
                return pathdest;
            }
            set
            {
                pathdest = value;
            }
        }


        public DbCopyForm()
        {
            InitializeComponent();
        }

        private void saveSeting()
        {
            FileStream FileStreamDestination = new FileStream("pathSDP.ini", FileMode.OpenOrCreate);
        }

        private void buttonBrwSource_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            PathSource = openFileDialog1.FileName;
            textBoxSource.Text = PathSource;

        }

        private void buttonBrwDest_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            PathDest = saveFileDialog1.FileName;
            textBoxDest.Text = PathDest;
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            CopyClass copySDP = new CopyClass();
            var thread = new Thread(() => copySDP.Copy(PathSource, PathDest));
            thread.Start();
            this.Close();
        }

        private void DbCopyForm_Load(object sender, EventArgs e)
        {
            PathSource = Properties.Settings.Default._pathSDPsour;
            textBoxSource.Text = PathSource;
            PathDest = Properties.Settings.Default._pathSDPdest;
            textBoxDest.Text = PathDest;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default._pathSDPsour = PathSource;
            Properties.Settings.Default._pathSDPdest = PathDest;
            Properties.Settings.Default.Save();
        }
    }
}
