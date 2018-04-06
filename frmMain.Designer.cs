namespace PCComm
{
    partial class frmMain
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
            this.cboData = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cboStop = new System.Windows.Forms.ComboBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdDisconnect = new System.Windows.Forms.Button();
            this.cmdSend = new System.Windows.Forms.Button();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboParity = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.cboBaud = new System.Windows.Forms.ComboBox();
            this.cboPort = new System.Windows.Forms.ComboBox();
            this.cmdOpen = new System.Windows.Forms.Button();
            this.cmdConnect = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboData
            // 
            this.cboData.FormattingEnabled = true;
            this.cboData.Items.AddRange(new object[] {
            "7",
            "8",
            "9"});
            this.cboData.Location = new System.Drawing.Point(595, 604);
            this.cboData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboData.Name = "cboData";
            this.cboData.Size = new System.Drawing.Size(112, 28);
            this.cboData.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(449, 576);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Стопбиты";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(585, 571);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Биты данных";
            // 
            // cmdClose
            // 
            this.cmdClose.BackColor = System.Drawing.Color.Transparent;
            this.cmdClose.Enabled = false;
            this.cmdClose.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.cmdClose.FlatAppearance.BorderSize = 2;
            this.cmdClose.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.cmdClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.cmdClose.ForeColor = System.Drawing.Color.Black;
            this.cmdClose.Location = new System.Drawing.Point(642, 320);
            this.cmdClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(150, 39);
            this.cmdClose.TabIndex = 5;
            this.cmdClose.Text = "Закрыть порт";
            this.cmdClose.UseVisualStyleBackColor = false;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cboStop
            // 
            this.cboStop.FormattingEnabled = true;
            this.cboStop.Location = new System.Drawing.Point(452, 601);
            this.cboStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboStop.Name = "cboStop";
            this.cboStop.Size = new System.Drawing.Size(112, 28);
            this.cboStop.TabIndex = 13;
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GroupBox1.Controls.Add(this.cmdDisconnect);
            this.GroupBox1.Controls.Add(this.cmdClose);
            this.GroupBox1.Location = new System.Drawing.Point(21, 98);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox1.Size = new System.Drawing.Size(782, 442);
            this.GroupBox1.TabIndex = 4;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.UseCompatibleTextRendering = true;
            // 
            // cmdDisconnect
            // 
            this.cmdDisconnect.BackColor = System.Drawing.Color.Transparent;
            this.cmdDisconnect.Enabled = false;
            this.cmdDisconnect.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.cmdDisconnect.FlatAppearance.BorderSize = 2;
            this.cmdDisconnect.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.cmdDisconnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.cmdDisconnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.cmdDisconnect.ForeColor = System.Drawing.Color.Black;
            this.cmdDisconnect.Location = new System.Drawing.Point(642, 369);
            this.cmdDisconnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdDisconnect.Name = "cmdDisconnect";
            this.cmdDisconnect.Size = new System.Drawing.Size(140, 39);
            this.cmdDisconnect.TabIndex = 10;
            this.cmdDisconnect.Text = "Разъединить";
            this.cmdDisconnect.UseVisualStyleBackColor = false;
            this.cmdDisconnect.Click += new System.EventHandler(this.cmdDisconnect_Click);
            // 
            // cmdSend
            // 
            this.cmdSend.Enabled = false;
            this.cmdSend.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.cmdSend.FlatAppearance.BorderSize = 2;
            this.cmdSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.cmdSend.ForeColor = System.Drawing.Color.Black;
            this.cmdSend.Location = new System.Drawing.Point(664, 514);
            this.cmdSend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdSend.Name = "cmdSend";
            this.cmdSend.Size = new System.Drawing.Size(140, 44);
            this.cmdSend.TabIndex = 5;
            this.cmdSend.Text = "Отправить";
            this.cmdSend.UseVisualStyleBackColor = true;
            this.cmdSend.Click += new System.EventHandler(this.cmdSend_Click);
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(32, 528);
            this.txtSend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(615, 26);
            this.txtSend.TabIndex = 4;
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.BackColor = System.Drawing.Color.White;
            this.rtbDisplay.Location = new System.Drawing.Point(21, 40);
            this.rtbDisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.ReadOnly = true;
            this.rtbDisplay.Size = new System.Drawing.Size(943, 358);
            this.rtbDisplay.TabIndex = 3;
            this.rtbDisplay.Text = "";
            this.rtbDisplay.TextChanged += new System.EventHandler(this.rtbDisplay_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(313, 575);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Бит четности";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(170, 578);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Скорость";
            // 
            // cboParity
            // 
            this.cboParity.FormattingEnabled = true;
            this.cboParity.Location = new System.Drawing.Point(309, 604);
            this.cboParity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboParity.Name = "cboParity";
            this.cboParity.Size = new System.Drawing.Size(112, 28);
            this.cboParity.TabIndex = 12;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(28, 576);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(48, 20);
            this.Label1.TabIndex = 15;
            this.Label1.Text = "Порт";
            // 
            // cboBaud
            // 
            this.cboBaud.FormattingEnabled = true;
            this.cboBaud.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "28800",
            "36000",
            "115000"});
            this.cboBaud.Location = new System.Drawing.Point(173, 604);
            this.cboBaud.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboBaud.Name = "cboBaud";
            this.cboBaud.Size = new System.Drawing.Size(112, 28);
            this.cboBaud.TabIndex = 11;
            // 
            // cboPort
            // 
            this.cboPort.FormattingEnabled = true;
            this.cboPort.Location = new System.Drawing.Point(32, 602);
            this.cboPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboPort.Name = "cboPort";
            this.cboPort.Size = new System.Drawing.Size(112, 28);
            this.cboPort.TabIndex = 10;
            // 
            // cmdOpen
            // 
            this.cmdOpen.BackColor = System.Drawing.Color.Transparent;
            this.cmdOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdOpen.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.cmdOpen.FlatAppearance.BorderSize = 2;
            this.cmdOpen.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.cmdOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cmdOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.cmdOpen.ForeColor = System.Drawing.Color.Black;
            this.cmdOpen.Location = new System.Drawing.Point(811, 418);
            this.cmdOpen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdOpen.Name = "cmdOpen";
            this.cmdOpen.Size = new System.Drawing.Size(150, 39);
            this.cmdOpen.TabIndex = 8;
            this.cmdOpen.Text = "Открыть порт";
            this.cmdOpen.UseVisualStyleBackColor = false;
            this.cmdOpen.Click += new System.EventHandler(this.cmdOpen_Click);
            // 
            // cmdConnect
            // 
            this.cmdConnect.BackColor = System.Drawing.Color.Transparent;
            this.cmdConnect.Enabled = false;
            this.cmdConnect.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.cmdConnect.FlatAppearance.BorderSize = 2;
            this.cmdConnect.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.cmdConnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.cmdConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.cmdConnect.ForeColor = System.Drawing.Color.Black;
            this.cmdConnect.Location = new System.Drawing.Point(812, 466);
            this.cmdConnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdConnect.Name = "cmdConnect";
            this.cmdConnect.Size = new System.Drawing.Size(150, 39);
            this.cmdConnect.TabIndex = 9;
            this.cmdConnect.Text = "Подключиться";
            this.cmdConnect.UseVisualStyleBackColor = false;
            this.cmdConnect.Click += new System.EventHandler(this.cmdConnect_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(980, 33);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4});
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(93, 29);
            this.toolStripMenuItem3.Text = "Справка";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(209, 30);
            this.toolStripMenuItem4.Text = "О программе";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(812, 514);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 42);
            this.button1.TabIndex = 20;
            this.button1.Text = "История";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(980, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.cmdSend);
            this.Controls.Add(this.cboData);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmdOpen);
            this.Controls.Add(this.cmdConnect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtbDisplay);
            this.Controls.Add(this.cboStop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboParity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.cboBaud);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.cboPort);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1526, 1078);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Чат";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.GroupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.ComboBox cboStop;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.Button cmdSend;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.RichTextBox rtbDisplay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboParity;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.ComboBox cboBaud;
        private System.Windows.Forms.ComboBox cboPort;
        private System.Windows.Forms.Button cmdOpen;
        private System.Windows.Forms.Button cmdConnect;
        private System.Windows.Forms.Button cmdDisconnect;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}