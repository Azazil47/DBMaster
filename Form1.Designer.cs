namespace DBMaster
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStatus = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonStopAll = new System.Windows.Forms.Button();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.buttonStartAll = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LbPathSDP = new System.Windows.Forms.Label();
            this.TbPathSDP = new System.Windows.Forms.TextBox();
            this.BtBrowseSDP = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.LbCopySDP = new System.Windows.Forms.Label();
            this.TbCopySDP = new System.Windows.Forms.TextBox();
            this.BtBrowseCopySDP = new System.Windows.Forms.Button();
            this.BtCopySDP = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(241, 336);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 0;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            // 
            // buttonStatus
            // 
            this.buttonStatus.Location = new System.Drawing.Point(24, 336);
            this.buttonStatus.Name = "buttonStatus";
            this.buttonStatus.Size = new System.Drawing.Size(75, 23);
            this.buttonStatus.TabIndex = 1;
            this.buttonStatus.Text = "Status";
            this.buttonStatus.UseVisualStyleBackColor = true;
            this.buttonStatus.Click += new System.EventHandler(this.buttonStatus_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(132, 336);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(527, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "buttonTest";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(360, 336);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceName,
            this.ServiceState});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(237, 97);
            this.dataGridView1.TabIndex = 6;
            // 
            // ServiceName
            // 
            this.ServiceName.Frozen = true;
            this.ServiceName.HeaderText = "Имя службы";
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.ReadOnly = true;
            this.ServiceName.Width = 96;
            // 
            // ServiceState
            // 
            this.ServiceState.Frozen = true;
            this.ServiceState.HeaderText = "Состояние";
            this.ServiceState.Name = "ServiceState";
            this.ServiceState.ReadOnly = true;
            this.ServiceState.Width = 86;
            // 
            // buttonStopAll
            // 
            this.buttonStopAll.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonStopAll.Location = new System.Drawing.Point(3, 32);
            this.buttonStopAll.Name = "buttonStopAll";
            this.buttonStopAll.Size = new System.Drawing.Size(98, 23);
            this.buttonStopAll.TabIndex = 7;
            this.buttonStopAll.Text = "Остановить все";
            this.buttonStopAll.UseVisualStyleBackColor = true;
            this.buttonStopAll.Click += new System.EventHandler(this.buttonStopAll_Click);
            // 
            // textBoxLog
            // 
            this.textBoxLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxLog.Location = new System.Drawing.Point(3, 3);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(799, 107);
            this.textBoxLog.TabIndex = 8;
            // 
            // buttonStartAll
            // 
            this.buttonStartAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStartAll.Location = new System.Drawing.Point(3, 3);
            this.buttonStartAll.Name = "buttonStartAll";
            this.buttonStartAll.Size = new System.Drawing.Size(98, 23);
            this.buttonStartAll.TabIndex = 9;
            this.buttonStartAll.Text = "Запустить все";
            this.buttonStartAll.UseVisualStyleBackColor = true;
            this.buttonStartAll.Click += new System.EventHandler(this.buttonStartAll_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.textBoxLog);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 365);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(802, 110);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.83852F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.16147F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 448F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.71429F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(802, 308);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.buttonStartAll);
            this.flowLayoutPanel2.Controls.Add(this.buttonStopAll);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(246, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(104, 61);
            this.flowLayoutPanel2.TabIndex = 12;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.46154F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.53846F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel2.Controls.Add(this.LbPathSDP, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.TbPathSDP, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.BtBrowseSDP, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.progressBar1, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.LbCopySDP, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.TbCopySDP, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.BtBrowseCopySDP, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.BtCopySDP, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(356, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.29412F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.70588F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(443, 104);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // LbPathSDP
            // 
            this.LbPathSDP.AutoSize = true;
            this.LbPathSDP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LbPathSDP.Location = new System.Drawing.Point(3, 3);
            this.LbPathSDP.Name = "LbPathSDP";
            this.LbPathSDP.Size = new System.Drawing.Size(284, 13);
            this.LbPathSDP.TabIndex = 0;
            this.LbPathSDP.Text = "Путь к UNI_WORK2003.fdb";
            // 
            // TbPathSDP
            // 
            this.TbPathSDP.Dock = System.Windows.Forms.DockStyle.Left;
            this.TbPathSDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbPathSDP.Location = new System.Drawing.Point(3, 19);
            this.TbPathSDP.Name = "TbPathSDP";
            this.TbPathSDP.Size = new System.Drawing.Size(284, 24);
            this.TbPathSDP.TabIndex = 1;
            // 
            // BtBrowseSDP
            // 
            this.BtBrowseSDP.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtBrowseSDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtBrowseSDP.Location = new System.Drawing.Point(293, 19);
            this.BtBrowseSDP.Name = "BtBrowseSDP";
            this.BtBrowseSDP.Size = new System.Drawing.Size(31, 24);
            this.BtBrowseSDP.TabIndex = 2;
            this.BtBrowseSDP.Text = ". . .";
            this.BtBrowseSDP.UseVisualStyleBackColor = true;
            this.BtBrowseSDP.Click += new System.EventHandler(this.BtBrowseSDP_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(3, 96);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(284, 5);
            this.progressBar1.TabIndex = 14;
            // 
            // LbCopySDP
            // 
            this.LbCopySDP.AutoSize = true;
            this.LbCopySDP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LbCopySDP.Location = new System.Drawing.Point(3, 48);
            this.LbCopySDP.Name = "LbCopySDP";
            this.LbCopySDP.Size = new System.Drawing.Size(284, 13);
            this.LbCopySDP.TabIndex = 3;
            this.LbCopySDP.Text = "Скопировать UNI_WORK2003.fdb в:";
            // 
            // TbCopySDP
            // 
            this.TbCopySDP.Dock = System.Windows.Forms.DockStyle.Left;
            this.TbCopySDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbCopySDP.Location = new System.Drawing.Point(3, 64);
            this.TbCopySDP.Name = "TbCopySDP";
            this.TbCopySDP.Size = new System.Drawing.Size(284, 24);
            this.TbCopySDP.TabIndex = 4;
            // 
            // BtBrowseCopySDP
            // 
            this.BtBrowseCopySDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtBrowseCopySDP.Location = new System.Drawing.Point(293, 64);
            this.BtBrowseCopySDP.Name = "BtBrowseCopySDP";
            this.BtBrowseCopySDP.Size = new System.Drawing.Size(31, 24);
            this.BtBrowseCopySDP.TabIndex = 5;
            this.BtBrowseCopySDP.Text = ". . .";
            this.BtBrowseCopySDP.UseVisualStyleBackColor = true;
            this.BtBrowseCopySDP.Click += new System.EventHandler(this.BtBrowseCopySDP_Click);
            // 
            // BtCopySDP
            // 
            this.BtCopySDP.Location = new System.Drawing.Point(330, 3);
            this.BtCopySDP.Name = "BtCopySDP";
            this.tableLayoutPanel2.SetRowSpan(this.BtCopySDP, 4);
            this.BtCopySDP.Size = new System.Drawing.Size(100, 76);
            this.BtCopySDP.TabIndex = 6;
            this.BtCopySDP.Text = "Скопировать";
            this.BtCopySDP.UseVisualStyleBackColor = true;
            this.BtCopySDP.Click += new System.EventHandler(this.BtCopySDP_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Firebird File (*.fdb)|*.fdb";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Firebird File (*.fdb)|*.fdb";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 475);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonStatus);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "DBMaster";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStatus;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceState;
        private System.Windows.Forms.Button buttonStopAll;
        public System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Button buttonStartAll;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label LbPathSDP;
        private System.Windows.Forms.TextBox TbPathSDP;
        private System.Windows.Forms.Button BtBrowseSDP;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label LbCopySDP;
        private System.Windows.Forms.TextBox TbCopySDP;
        private System.Windows.Forms.Button BtBrowseCopySDP;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button BtCopySDP;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

