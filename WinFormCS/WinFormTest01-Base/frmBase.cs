﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTest01_Base
{
    public partial class frmBase : Form
    {
        int EncMode = 0; // 0:UTF-8, 1:ANSI
        public frmBase()
        {
            InitializeComponent();
            if (EncMode == 0) mnuUtf8_Click(null, null);
            else              mnuAnsi_Click(null, null);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            mnuOpen_Click(sender, e);
        }

        string ReadBuf;
        Encoding enc = Encoding.UTF8;   // Windows 기본 엔코딩
        private void mnuOpen_Click(object sender, EventArgs e)
        {
            DialogResult ret = openFileDialog1.ShowDialog();
            if(ret == DialogResult.OK)
            {
                string fn = openFileDialog1.FileName;
                FileStream fs = new FileStream(fn, FileMode.Open);
                StreamReader sr = new StreamReader(fs, enc);
                tbMemo.Text += sr.ReadToEnd();
                sr.Close();
                fs.Close();
            }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            DialogResult ret = saveFileDialog1.ShowDialog();
            if(ret == DialogResult.OK)
            {
                string fn = saveFileDialog1.FileName;
                FileStream fs = new FileStream(fn, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(tbMemo.Text);
                sw.Close();
                fs.Close();
            }
        }

        private void mnuAnsi_Click(object sender, EventArgs e)
        {   // UTF-8 ==> ANSI
            sbLabel1.Text = "ANSI";
            mnuAnsi.Checked = true;
            mnuUtf8.Checked = false;
            enc = Encoding.Default;
        }

        private void mnuUtf8_Click(object sender, EventArgs e)
        {
            sbLabel1.Text = "UTF-8";
            mnuAnsi.Checked = false;
            mnuUtf8.Checked = true;
            enc = Encoding.UTF8;
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            string s = "";
            frmAbout frm = new frmAbout();
            DialogResult r = frm.ShowDialog();
            if(r == DialogResult.OK) s = "About... OK";
            else                     s = "About... Cancel";     
            sbLabel2.Text = s;
        }
    }
}
