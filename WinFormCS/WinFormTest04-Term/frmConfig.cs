using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTest04_Term
{
    public partial class frmConfig : Form
    {
        public frmConfig(int n1 = 0, int n2 = 0, int n3 = 0, int n4 = 0, int n5 = 0)
        {
            InitializeComponent();
            string[] l = System.IO.Ports.SerialPort.GetPortNames();
            foreach (string s in l) { cmbPort.Items.Add(s); }
            cmbPort.SelectedIndex = n1;
            cmbBaud.SelectedIndex = n2;
            cmbParity.SelectedIndex = n3;
            cmbData.SelectedIndex = n4;
            cmbStop.SelectedIndex = n5;
        }
    }
}
