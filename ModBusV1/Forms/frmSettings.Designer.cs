
namespace ModBusV1.Forms
{
    partial class FrmSettings
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
            System.Windows.Forms.GroupBox grp;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cmbStopBits = new System.Windows.Forms.ComboBox();
            this.cmbParityBits = new System.Windows.Forms.ComboBox();
            this.cmbDataBits = new System.Windows.Forms.ComboBox();
            this.cmbBaudrate = new System.Windows.Forms.ComboBox();
            this.cmbComPort = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.NumAddress = new System.Windows.Forms.NumericUpDown();
            this.NumRefresh = new System.Windows.Forms.NumericUpDown();
            grp = new System.Windows.Forms.GroupBox();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label10 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            grp.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // grp
            // 
            grp.Controls.Add(this.btnRefresh);
            grp.Controls.Add(this.cmbStopBits);
            grp.Controls.Add(label5);
            grp.Controls.Add(this.cmbParityBits);
            grp.Controls.Add(label4);
            grp.Controls.Add(this.cmbDataBits);
            grp.Controls.Add(label3);
            grp.Controls.Add(this.cmbBaudrate);
            grp.Controls.Add(label2);
            grp.Controls.Add(this.cmbComPort);
            grp.Controls.Add(label1);
            grp.Location = new System.Drawing.Point(12, 12);
            grp.Name = "grp";
            grp.Size = new System.Drawing.Size(287, 160);
            grp.TabIndex = 0;
            grp.TabStop = false;
            grp.Text = "Connections";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefresh.Location = new System.Drawing.Point(228, 19);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(53, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cmbStopBits
            // 
            this.cmbStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStopBits.FormattingEnabled = true;
            this.cmbStopBits.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbStopBits.Location = new System.Drawing.Point(68, 102);
            this.cmbStopBits.Name = "cmbStopBits";
            this.cmbStopBits.Size = new System.Drawing.Size(51, 21);
            this.cmbStopBits.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(7, 105);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(53, 13);
            label5.TabIndex = 10;
            label5.Text = "Stop Bits:";
            // 
            // cmbParityBits
            // 
            this.cmbParityBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParityBits.FormattingEnabled = true;
            this.cmbParityBits.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cmbParityBits.Location = new System.Drawing.Point(68, 75);
            this.cmbParityBits.Name = "cmbParityBits";
            this.cmbParityBits.Size = new System.Drawing.Size(74, 21);
            this.cmbParityBits.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(7, 78);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(59, 13);
            label4.TabIndex = 8;
            label4.Text = "Parity Bits:";
            // 
            // cmbDataBits
            // 
            this.cmbDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDataBits.FormattingEnabled = true;
            this.cmbDataBits.Items.AddRange(new object[] {
            "7",
            "8"});
            this.cmbDataBits.Location = new System.Drawing.Point(68, 129);
            this.cmbDataBits.Name = "cmbDataBits";
            this.cmbDataBits.Size = new System.Drawing.Size(51, 21);
            this.cmbDataBits.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(7, 132);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(54, 13);
            label3.TabIndex = 6;
            label3.Text = "Data Bits:";
            // 
            // cmbBaudrate
            // 
            this.cmbBaudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBaudrate.FormattingEnabled = true;
            this.cmbBaudrate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "1800",
            "2400",
            "4800",
            "7200",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400"});
            this.cmbBaudrate.Location = new System.Drawing.Point(68, 48);
            this.cmbBaudrate.Name = "cmbBaudrate";
            this.cmbBaudrate.Size = new System.Drawing.Size(131, 21);
            this.cmbBaudrate.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(7, 51);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(55, 13);
            label2.TabIndex = 4;
            label2.Text = "Baudrate:";
            // 
            // cmbComPort
            // 
            this.cmbComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComPort.FormattingEnabled = true;
            this.cmbComPort.Location = new System.Drawing.Point(68, 21);
            this.cmbComPort.Name = "cmbComPort";
            this.cmbComPort.Size = new System.Drawing.Size(154, 21);
            this.cmbComPort.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(7, 24);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(60, 13);
            label1.TabIndex = 2;
            label1.Text = "Serial Port:";
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOk.Location = new System.Drawing.Point(12, 267);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(224, 267);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(this.NumRefresh);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(this.NumAddress);
            groupBox1.Controls.Add(label10);
            groupBox1.Location = new System.Drawing.Point(12, 178);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(287, 80);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "General";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(7, 24);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(85, 13);
            label10.TabIndex = 2;
            label10.Text = "Device Address:";
            // 
            // NumAddress
            // 
            this.NumAddress.Location = new System.Drawing.Point(98, 22);
            this.NumAddress.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.NumAddress.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumAddress.Name = "NumAddress";
            this.NumAddress.Size = new System.Drawing.Size(49, 20);
            this.NumAddress.TabIndex = 3;
            this.NumAddress.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(153, 51);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(47, 13);
            label7.TabIndex = 7;
            label7.Text = "Seconds";
            // 
            // NumRefresh
            // 
            this.NumRefresh.Location = new System.Drawing.Point(98, 49);
            this.NumRefresh.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumRefresh.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.NumRefresh.Name = "NumRefresh";
            this.NumRefresh.Size = new System.Drawing.Size(49, 20);
            this.NumRefresh.TabIndex = 6;
            this.NumRefresh.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(7, 51);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(80, 13);
            label8.TabIndex = 5;
            label8.Text = "Refresh every:";
            // 
            // FrmSettings
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(310, 302);
            this.ControlBox = false;
            this.Controls.Add(groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(grp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            grp.ResumeLayout(false);
            grp.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumRefresh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.ComboBox cmbComPort;
        public System.Windows.Forms.ComboBox cmbStopBits;
        public System.Windows.Forms.ComboBox cmbParityBits;
        public System.Windows.Forms.ComboBox cmbDataBits;
        public System.Windows.Forms.ComboBox cmbBaudrate;
        private System.Windows.Forms.Button btnRefresh;
        public System.Windows.Forms.NumericUpDown NumAddress;
        public System.Windows.Forms.NumericUpDown NumRefresh;
    }
}