using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace DBMaster
{
    class MyLoger
    {
        private static StreamWriter writer;
        public MyLoger()
        {
            try
            {
                writer = new StreamWriter("Services.ini", true);
            }
            catch (Exception)
            {

                MessageBox.Show("Мы все уронили");
            }
            
            
        }

        public void write(String line)
        {
            try
            {
                writer.WriteLine(line);
            }
            catch (Exception)
            {

                MessageBox.Show("Не удалось записать файл log");
            }
        }
    }
}
