
namespace ModBusV1
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.MenuStrip mnuMain;
            System.Windows.Forms.ToolStripMenuItem mnuFile;
            System.Windows.Forms.ToolStripSeparator mnuFile_1;
            System.Windows.Forms.ToolStripSeparator mnuFile_2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.mnuFileConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileDisConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.stsMain = new System.Windows.Forms.StatusStrip();
            this.stsComPort = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsBaudRate = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsDataBits = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsParity = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsStopBits = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsState = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTemp = new System.Windows.Forms.Label();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.numAddress = new System.Windows.Forms.NumericUpDown();
            this.numValue = new System.Windows.Forms.NumericUpDown();
            this.BtnSend = new System.Windows.Forms.Button();
            this.LblLevel = new System.Windows.Forms.Label();
            this.BtnInc = new System.Windows.Forms.Button();
            this.BtnDec = new System.Windows.Forms.Button();
            this.LblAddress = new System.Windows.Forms.Label();
            this.LblValue = new System.Windows.Forms.Label();
            this.Pic = new System.Windows.Forms.PictureBox();
            mnuMain = new System.Windows.Forms.MenuStrip();
            mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            mnuFile_1 = new System.Windows.Forms.ToolStripSeparator();
            mnuFile_2 = new System.Windows.Forms.ToolStripSeparator();
            mnuMain.SuspendLayout();
            this.stsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            mnuFile});
            mnuMain.Location = new System.Drawing.Point(0, 0);
            mnuMain.Name = "mnuMain";
            mnuMain.Size = new System.Drawing.Size(965, 24);
            mnuMain.TabIndex = 2;
            mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileConnect,
            this.mnuFileDisConnect,
            mnuFile_1,
            this.mnuFileSettings,
            mnuFile_2,
            this.mnuFileExit});
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new System.Drawing.Size(37, 20);
            mnuFile.Text = "File";
            // 
            // mnuFileConnect
            // 
            this.mnuFileConnect.Name = "mnuFileConnect";
            this.mnuFileConnect.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.mnuFileConnect.Size = new System.Drawing.Size(209, 22);
            this.mnuFileConnect.Text = "Connect";
            this.mnuFileConnect.Click += new System.EventHandler(this.MnuFileConnect_Click);
            // 
            // mnuFileDisConnect
            // 
            this.mnuFileDisConnect.Enabled = false;
            this.mnuFileDisConnect.Name = "mnuFileDisConnect";
            this.mnuFileDisConnect.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.mnuFileDisConnect.Size = new System.Drawing.Size(209, 22);
            this.mnuFileDisConnect.Text = "DisConnect";
            this.mnuFileDisConnect.Click += new System.EventHandler(this.MnuFileDisConnect_Click);
            // 
            // mnuFile_1
            // 
            mnuFile_1.Name = "mnuFile_1";
            mnuFile_1.Size = new System.Drawing.Size(206, 6);
            // 
            // mnuFileSettings
            // 
            this.mnuFileSettings.Name = "mnuFileSettings";
            this.mnuFileSettings.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.mnuFileSettings.Size = new System.Drawing.Size(209, 22);
            this.mnuFileSettings.Text = "Settings";
            this.mnuFileSettings.Click += new System.EventHandler(this.MnuFileSettings_Click);
            // 
            // mnuFile_2
            // 
            mnuFile_2.Name = "mnuFile_2";
            mnuFile_2.Size = new System.Drawing.Size(206, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuFileExit.Size = new System.Drawing.Size(209, 22);
            this.mnuFileExit.Text = "Exit";
            this.mnuFileExit.Click += new System.EventHandler(this.MnuFileExit_Click);
            // 
            // stsMain
            // 
            this.stsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsComPort,
            this.stsBaudRate,
            this.stsDataBits,
            this.stsParity,
            this.stsStopBits,
            this.stsState});
            this.stsMain.Location = new System.Drawing.Point(0, 534);
            this.stsMain.Name = "stsMain";
            this.stsMain.Size = new System.Drawing.Size(965, 22);
            this.stsMain.TabIndex = 3;
            this.stsMain.Text = "statusStrip1";
            // 
            // stsComPort
            // 
            this.stsComPort.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.stsComPort.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.stsComPort.Name = "stsComPort";
            this.stsComPort.Size = new System.Drawing.Size(4, 17);
            this.stsComPort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stsBaudRate
            // 
            this.stsBaudRate.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.stsBaudRate.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.stsBaudRate.Name = "stsBaudRate";
            this.stsBaudRate.Size = new System.Drawing.Size(4, 17);
            this.stsBaudRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stsDataBits
            // 
            this.stsDataBits.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.stsDataBits.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.stsDataBits.Name = "stsDataBits";
            this.stsDataBits.Size = new System.Drawing.Size(4, 17);
            this.stsDataBits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stsParity
            // 
            this.stsParity.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.stsParity.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.stsParity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stsParity.Name = "stsParity";
            this.stsParity.Size = new System.Drawing.Size(4, 17);
            // 
            // stsStopBits
            // 
            this.stsStopBits.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.stsStopBits.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.stsStopBits.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stsStopBits.Name = "stsStopBits";
            this.stsStopBits.Size = new System.Drawing.Size(4, 17);
            // 
            // stsState
            // 
            this.stsState.AutoSize = false;
            this.stsState.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.stsState.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.stsState.ForeColor = System.Drawing.Color.DarkRed;
            this.stsState.Name = "stsState";
            this.stsState.Size = new System.Drawing.Size(930, 17);
            this.stsState.Spring = true;
            this.stsState.Text = "Disconnected";
            this.stsState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTemp
            // 
            this.lblTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lblTemp.Font = new System.Drawing.Font("DS-Digital", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.ForeColor = System.Drawing.Color.Red;
            this.lblTemp.Location = new System.Drawing.Point(9, 298);
            this.lblTemp.Margin = new System.Windows.Forms.Padding(0);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(249, 132);
            this.lblTemp.TabIndex = 4;
            this.lblTemp.Text = "16.5";
            this.lblTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTemp.Visible = false;
            // 
            // tmr
            // 
            this.tmr.Interval = 1000;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // numAddress
            // 
            this.numAddress.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAddress.Location = new System.Drawing.Point(559, 378);
            this.numAddress.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numAddress.Name = "numAddress";
            this.numAddress.Size = new System.Drawing.Size(120, 52);
            this.numAddress.TabIndex = 5;
            this.numAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numAddress.Visible = false;
            this.numAddress.ValueChanged += new System.EventHandler(this.numAddress_ValueChanged);
            // 
            // numValue
            // 
            this.numValue.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numValue.Location = new System.Drawing.Point(685, 378);
            this.numValue.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numValue.Name = "numValue";
            this.numValue.Size = new System.Drawing.Size(120, 52);
            this.numValue.TabIndex = 6;
            this.numValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numValue.Visible = false;
            // 
            // BtnSend
            // 
            this.BtnSend.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSend.Location = new System.Drawing.Point(811, 378);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(152, 52);
            this.BtnSend.TabIndex = 7;
            this.BtnSend.Text = "Update";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Visible = false;
            this.BtnSend.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblLevel
            // 
            this.LblLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.LblLevel.Font = new System.Drawing.Font("DS-Digital", 80.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LblLevel.Location = new System.Drawing.Point(263, 330);
            this.LblLevel.Margin = new System.Windows.Forms.Padding(0);
            this.LblLevel.Name = "LblLevel";
            this.LblLevel.Size = new System.Drawing.Size(227, 100);
            this.LblLevel.TabIndex = 8;
            this.LblLevel.Text = "40.0";
            this.LblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblLevel.Visible = false;
            // 
            // BtnInc
            // 
            this.BtnInc.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInc.Location = new System.Drawing.Point(493, 330);
            this.BtnInc.Margin = new System.Windows.Forms.Padding(0);
            this.BtnInc.Name = "BtnInc";
            this.BtnInc.Size = new System.Drawing.Size(55, 48);
            this.BtnInc.TabIndex = 9;
            this.BtnInc.Text = "+";
            this.BtnInc.UseVisualStyleBackColor = true;
            this.BtnInc.Visible = false;
            this.BtnInc.Click += new System.EventHandler(this.BtnInc_Click);
            // 
            // BtnDec
            // 
            this.BtnDec.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDec.Location = new System.Drawing.Point(493, 389);
            this.BtnDec.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDec.Name = "BtnDec";
            this.BtnDec.Size = new System.Drawing.Size(55, 41);
            this.BtnDec.TabIndex = 10;
            this.BtnDec.Text = "-";
            this.BtnDec.UseVisualStyleBackColor = true;
            this.BtnDec.Visible = false;
            this.BtnDec.Click += new System.EventHandler(this.BtnDec_Click);
            // 
            // LblAddress
            // 
            this.LblAddress.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddress.Location = new System.Drawing.Point(559, 337);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(120, 38);
            this.LblAddress.TabIndex = 11;
            this.LblAddress.Text = "Address";
            this.LblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblAddress.Visible = false;
            // 
            // LblValue
            // 
            this.LblValue.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValue.Location = new System.Drawing.Point(685, 337);
            this.LblValue.Name = "LblValue";
            this.LblValue.Size = new System.Drawing.Size(120, 38);
            this.LblValue.TabIndex = 12;
            this.LblValue.Text = "Value";
            this.LblValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblValue.Visible = false;
            // 
            // Pic
            // 
            this.Pic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pic.Image = ((System.Drawing.Image)(resources.GetObject("Pic.Image")));
            this.Pic.Location = new System.Drawing.Point(0, 27);
            this.Pic.Name = "Pic";
            this.Pic.Size = new System.Drawing.Size(965, 504);
            this.Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic.TabIndex = 13;
            this.Pic.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(965, 556);
            this.Controls.Add(this.LblValue);
            this.Controls.Add(this.LblAddress);
            this.Controls.Add(this.BtnDec);
            this.Controls.Add(this.BtnInc);
            this.Controls.Add(this.LblLevel);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.numValue);
            this.Controls.Add(this.numAddress);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.stsMain);
            this.Controls.Add(mnuMain);
            this.Controls.Add(this.Pic);
            this.MainMenuStrip = mnuMain;
            this.Name = "FrmMain";
            this.Text = "Modbus Comunication";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            mnuMain.ResumeLayout(false);
            mnuMain.PerformLayout();
            this.stsMain.ResumeLayout(false);
            this.stsMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem mnuFileConnect;
        private System.Windows.Forms.ToolStripMenuItem mnuFileDisConnect;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSettings;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.StatusStrip stsMain;
        private System.Windows.Forms.ToolStripStatusLabel stsComPort;
        private System.Windows.Forms.ToolStripStatusLabel stsBaudRate;
        private System.Windows.Forms.ToolStripStatusLabel stsDataBits;
        private System.Windows.Forms.ToolStripStatusLabel stsParity;
        private System.Windows.Forms.ToolStripStatusLabel stsStopBits;
        private System.Windows.Forms.ToolStripStatusLabel stsState;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.NumericUpDown numAddress;
        private System.Windows.Forms.NumericUpDown numValue;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.Label LblLevel;
        private System.Windows.Forms.Button BtnInc;
        private System.Windows.Forms.Button BtnDec;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.Label LblValue;
        private System.Windows.Forms.PictureBox Pic;
    }
}

