namespace DBMaster
{
    partial class DbCopyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelSource = new System.Windows.Forms.Label();
            this.textBoxSource = new System.Windows.Forms.TextBox();
            this.buttonBrwSource = new System.Windows.Forms.Button();
            this.labelDestination = new System.Windows.Forms.Label();
            this.textBoxDest = new System.Windows.Forms.TextBox();
            this.buttonBrwDest = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.75545F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.24455F));
            this.tableLayoutPanel1.Controls.Add(this.labelSource, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxSource, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonBrwSource, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelDestination, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxDest, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonBrwDest, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.96227F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.03773F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(380, 140);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelSource
            // 
            this.labelSource.AutoSize = true;
            this.labelSource.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelSource.Location = new System.Drawing.Point(3, 2);
            this.labelSource.Name = "labelSource";
            this.labelSource.Size = new System.Drawing.Size(285, 13);
            this.labelSource.TabIndex = 0;
            this.labelSource.Text = "Путь к UNI_WORK2003.fdb";
            // 
            // textBoxSource
            // 
            this.textBoxSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSource.Location = new System.Drawing.Point(3, 18);
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.Size = new System.Drawing.Size(285, 20);
            this.textBoxSource.TabIndex = 1;
            // 
            // buttonBrwSource
            // 
            this.buttonBrwSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBrwSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBrwSource.Location = new System.Drawing.Point(294, 18);
            this.buttonBrwSource.Name = "buttonBrwSource";
            this.buttonBrwSource.Size = new System.Drawing.Size(83, 24);
            this.buttonBrwSource.TabIndex = 2;
            this.buttonBrwSource.Text = ". . .";
            this.buttonBrwSource.UseVisualStyleBackColor = true;
            this.buttonBrwSource.Click += new System.EventHandler(this.buttonBrwSource_Click);
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelDestination.Location = new System.Drawing.Point(3, 49);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(285, 13);
            this.labelDestination.TabIndex = 3;
            this.labelDestination.Text = "Скопировать в каталог . . .";
            // 
            // textBoxDest
            // 
            this.textBoxDest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDest.Location = new System.Drawing.Point(3, 65);
            this.textBoxDest.Name = "textBoxDest";
            this.textBoxDest.Size = new System.Drawing.Size(285, 20);
            this.textBoxDest.TabIndex = 4;
            // 
            // buttonBrwDest
            // 
            this.buttonBrwDest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBrwDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBrwDest.Location = new System.Drawing.Point(294, 65);
            this.buttonBrwDest.Name = "buttonBrwDest";
            this.buttonBrwDest.Size = new System.Drawing.Size(83, 20);
            this.buttonBrwDest.TabIndex = 5;
            this.buttonBrwDest.Text = ". . .";
            this.buttonBrwDest.UseVisualStyleBackColor = true;
            this.buttonBrwDest.Click += new System.EventHandler(this.buttonBrwDest_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel2.Controls.Add(this.buttonCancel, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonSave, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonCopy, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 91);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(285, 46);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonCancel.Location = new System.Drawing.Point(185, 22);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(97, 21);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSave.Location = new System.Drawing.Point(94, 22);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(85, 21);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonCopy.Location = new System.Drawing.Point(3, 22);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(85, 21);
            this.buttonCopy.TabIndex = 0;
            this.buttonCopy.Text = "Скопировать";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Firebird files(*.fdb)|*.fdb";
            // 
            // DbCopyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 140);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DbCopyForm";
            this.Text = "Копирование";
            this.Load += new System.EventHandler(this.DbCopyForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelSource;
        private System.Windows.Forms.TextBox textBoxSource;
        private System.Windows.Forms.Button buttonBrwSource;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.TextBox textBoxDest;
        private System.Windows.Forms.Button buttonBrwDest;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}