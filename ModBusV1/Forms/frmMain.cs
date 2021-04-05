using Modbus.Device;
using ModBusV1.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModBusV1
{
    public partial class FrmMain : Form
    {
        SerialPort serialPort;
        IModbusSerialMaster master;
        byte slaveAddress = Properties.Settings.Default.Address;

        public static int[] BaudRate = new int[] { 4800, 9600, 19200, 38400, 57600, 115200 };
        public static int[] DataBits = new int[] { 7, 8 };
        public static int[] StepBits = new int[] { 1, 2 };

        public FrmMain()
        {
            InitializeComponent();
            serialPort = new SerialPort();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            UpdateStatus();
            tmr.Interval = Properties.Settings.Default.Refresh;
        }

        private void MnuFileSettings_Click(object sender, EventArgs e)
        {
            FrmSettings frmSettings = new FrmSettings();
            var result = frmSettings.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                Properties.Settings.Default.ComPort = frmSettings.cmbComPort.Text;
                Properties.Settings.Default.Baudrate = int.Parse(frmSettings.cmbBaudrate.Text);
                Properties.Settings.Default.DataBits = int.Parse(frmSettings.cmbDataBits.Text);
                Properties.Settings.Default.ParityBits = frmSettings.cmbParityBits.SelectedIndex;
                Properties.Settings.Default.StopBits = frmSettings.cmbStopBits.SelectedIndex;
                Properties.Settings.Default.Refresh = int.Parse(frmSettings.NumRefresh.Value.ToString());
                Properties.Settings.Default.Address = byte.Parse(frmSettings.NumAddress.Value.ToString());
                slaveAddress = Properties.Settings.Default.Address;
                tmr.Interval = Properties.Settings.Default.Refresh;

                Properties.Settings.Default.Save();
                UpdateStatus();
            }

            frmSettings.Dispose();
        }

        private void UpdateStatus()
        {
            stsComPort.Text = "Port: " + Properties.Settings.Default.ComPort;
            stsBaudRate.Text = "Baud Rate: " + Properties.Settings.Default.Baudrate;
            stsDataBits.Text = "Data Bits: " + Properties.Settings.Default.DataBits;
            stsParity.Text = "Patity: " + (Parity)Properties.Settings.Default.ParityBits;
            stsStopBits.Text = "Stop Bits: " + (StopBits)Properties.Settings.Default.StopBits;
        }

        private void MnuFileConnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort = new SerialPort();
                serialPort.PortName = Properties.Settings.Default.ComPort;
                serialPort.BaudRate = Properties.Settings.Default.Baudrate;
                serialPort.DataBits = Properties.Settings.Default.DataBits;
                serialPort.Parity = (Parity)Properties.Settings.Default.ParityBits;
                serialPort.StopBits = (StopBits)Properties.Settings.Default.StopBits;

                if (!serialPort.IsOpen) serialPort.Open();
                master = ModbusSerialMaster.CreateRtu(serialPort);
                master.Transport.ReadTimeout = 1000;
                master.Transport.WriteTimeout = 1000;

                stsState.Text = "Connected";
                stsState.ForeColor = Color.DarkGreen;
                mnuFileConnect.Enabled = false;
                mnuFileSettings.Enabled = false;
                mnuFileDisConnect.Enabled = true;
                lblTemp.Visible = true;
                numAddress.Visible = true;
                numValue.Visible = true;
                BtnSend.Visible = true;
                LblLevel.Visible = true;
                BtnInc.Visible = true;
                BtnDec.Visible = true;
                LblAddress.Visible = true;
                LblValue.Visible = true;

                BackgroundImage = null;

                tmr.Start();
            }
            catch (IOException exIO)
            {
                if (exIO.HResult == -2146232800)
                    MessageBox.Show(this, "SerialPort is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else
                    MessageBox.Show(this, exIO.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MnuFileExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to close?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                serialPort.Close();
                serialPort.Dispose();
                master.Dispose();
                this.Dispose();
            }
        }

        private void MnuFileDisConnect_Click(object sender, EventArgs e)
        {
            tmr.Stop();
            serialPort.Close();
            serialPort.Dispose();
            master.Dispose();

            stsState.Text = "Disconnected";
            stsState.ForeColor = Color.DarkRed;
            mnuFileConnect.Enabled = true;
            mnuFileSettings.Enabled = true;
            mnuFileDisConnect.Enabled = false;
            numAddress.Visible = false;
            numValue.Visible = false;
            BtnSend.Visible = false;
            lblTemp.Visible = false;
            LblLevel.Visible = false;
            BtnInc.Visible = false;
            BtnDec.Visible = false;
            LblAddress.Visible = false;
            LblValue.Visible = false;
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            try
            {
                ushort[] results = master.ReadInputRegisters(slaveAddress, 4096 , 1);

                decimal temp = results[0];
                temp /= 10;
                lblTemp.Text = temp.ToString("#.0");
            }
            catch (Exception ex)
            {
                MnuFileDisConnect_Click(this, new EventArgs());

                if (ex.HResult == -2146233083)
                    MessageBox.Show(this, "Check SlaveAddress then try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            master.WriteSingleRegister(slaveAddress, Convert.ToUInt16(numAddress.Value.ToString()), Convert.ToUInt16(numValue.Value.ToString()));
        }

        private void numAddress_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (serialPort.IsOpen && master != null) { 
                    numValue.Value = master.ReadHoldingRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value.ToString()), 1)[0];
                    if(numValue.Value == 0)
                        LblLevel.Text = numValue.Value.ToString("0#.0");
                }
            }
            catch (Exception ex)
            {
                if(ex.HResult== -2146233088)
                    MessageBox.Show(this, "Address is wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnInc_Click(object sender, EventArgs e)
        {
            var val = decimal.Parse(LblLevel.Text) * 10;
            val += 1;
            master.WriteSingleRegister(slaveAddress, 0, (ushort)val);
            LblLevel.Text = (val / 10).ToString("0#.0");
        }

        private void BtnDec_Click(object sender, EventArgs e)
        {
            var val = decimal.Parse(LblLevel.Text) * 10;
            val -= 1;
            master.WriteSingleRegister(slaveAddress, 0, (ushort)val);
            LblLevel.Text = (val / 10).ToString("0#.0");
        }
    }
}
