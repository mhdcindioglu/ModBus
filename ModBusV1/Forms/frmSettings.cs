using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModBusV1.Forms
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            cmbComPort.DataSource = SerialPort.GetPortNames();

            for (int i = 0; i < cmbComPort.Items.Count - 1; i++)
            {
                if (cmbComPort.Items[i].ToString() == Properties.Settings.Default.ComPort)
                    cmbComPort.SelectedIndex = i;
            }

            cmbBaudrate.DataSource = FrmMain.BaudRate;
            cmbBaudrate.Text = Properties.Settings.Default.Baudrate.ToString();

            cmbDataBits.DataSource = FrmMain.DataBits;
            cmbDataBits.Text = Properties.Settings.Default.DataBits.ToString();

            cmbParityBits.DataSource = Enum.GetNames(typeof(Parity));
            cmbParityBits.SelectedIndex = Properties.Settings.Default.ParityBits;

            cmbStopBits.DataSource = Enum.GetNames(typeof(StopBits));
            cmbStopBits.SelectedIndex = Properties.Settings.Default.StopBits;

            NumAddress.Value = Properties.Settings.Default.Address;
            NumRefresh.Value = Properties.Settings.Default.Refresh;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cmbComPort.DataSource = SerialPort.GetPortNames();
        }
    }
}
