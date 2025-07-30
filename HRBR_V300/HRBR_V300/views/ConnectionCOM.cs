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

namespace HRBR_V300.views
{
    public partial class ConnectionCOM : Form
    {
        public ConnectionCOM()
        {
            InitializeComponent();
            LoadAvailablePorts();
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void LoadAvailablePorts()
        {
            string[] ports = SerialPort.GetPortNames();
            cmbPorts.Items.AddRange(ports);

            if (ports.Length > 0)
            {
                cmbPorts.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("No COM ports found.");
            }
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (cmbPorts.SelectedItem != null)
            {
                string selectedPort = cmbPorts.SelectedItem.ToString();
                try
                {
                    Form1.Instance.SelectCOM(selectedPort);
                    MessageBox.Show($"Connected to {selectedPort} successfully!");
                    this.Close();
                    this.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: Could not connect to {selectedPort}. {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please select a COM port.");
            }
            this.Close();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
