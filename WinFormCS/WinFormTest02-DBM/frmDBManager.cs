using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTest02_DBM
{
    public partial class frmDBManager : Form
    {
        public frmDBManager()
        {
            InitializeComponent();
        }
        //C:\Users\EMBEDDED\source\repos\Intel\WinFormCS\WinFormTest02-DBM\TestDB.mdf
        string GetFileName(string sPath)
        {
            string[] sa = sPath.Split('\\');
            return sa[sa.Length - 1];
        }
        SqlConnection sqlConn = new SqlConnection();
        SqlCommand sqlCom = new SqlCommand();
        string sConn;        
        private void mnuOpen_Click(object sender, EventArgs e)
        {   // DB file select
            openFileDialog1.Filter = "MS-SQL Database file|*.mdf";
            if(DialogResult.OK == openFileDialog1.ShowDialog())
            {
                sConn = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={openFileDialog1.FileName};Integrated Security=True;Connect Timeout=30";
                sqlConn.ConnectionString = sConn;
                sqlConn.Open();
                sqlCom.Connection = sqlConn;
                sbLabel1.BackColor = Color.Green;
                sbLabel1.Text = GetFileName(openFileDialog1.FileName);
            }
        }

        ArrayList ColName = new ArrayList();  // 필드 이름 List
        List<object[]> RunSql(string sql) // Select vs Others
        {
            List<object[]> result = new List<object[]>();
            sqlCom.CommandText = sql;
            try
            {
                if (sql.Trim().ToLower().Substring(0, 6) == "select")  // Sele.. sel.. SEL..__Sel
                {
                    SqlDataReader sr = sqlCom.ExecuteReader();
                    ColName.Clear();
                    for (int i = 0; i < sr.FieldCount; i++) // Column Name
                    {
                        ColName.Add(sr.GetName(i));
                    }
                    for (; sr.Read();) // 1 record read
                    {
                        object[] oarr = new object[sr.FieldCount];
                        sr.GetValues(oarr);
                        result.Add(oarr);
                        ////string str = ""; // 1 Line add
                        ////for(int i = 0; i < sr.FieldCount; i++)
                        ////{
                        ////    object o = sr.GetValue(i);
                        ////    if (i == 0) str = $"{o}";
                        ////    else        str += $",{o}";
                        ////}
                    }
                    sr.Close();
                }
                else
                {
                    int n = sqlCom.ExecuteNonQuery();
                }
                sbLabel3.Text = "OK";
                return result;
            }
            catch(Exception ex)
            {
//                MessageBox.Show(ex.Message);
                sbLabel3.AutoSize = true;
                sbLabel3.Text = ex.Message;
                return null;
            }
        }
        private void mnuRun_Click(object sender, EventArgs e)
        {
            string sql = tbSql.SelectedText;
            if(sql == "") sql = tbSql.Text;
            List<object[]> r = RunSql(sql);
            if (r == null) return;

            dataView.Rows.Clear();
            dataView.Columns.Clear();
            for (int i = 0; i < ColName.Count; i++) // Column 생성
            {
                string colName = (string)ColName[i];
                dataView.Columns.Add(colName, colName);
            }
            for (int i = 0; i < r.Count; i++) // 1 record read
            {
                int nRow = dataView.Rows.Add(); // 1 Line add
                object[] o = r[i];
                for (int j = 0; j < ColName.Count; j++)
                {
                    dataView.Rows[nRow].Cells[j].Value = o[j];
                }
            }
        }

        private void mnuFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                tbSql.Font = fontDialog1.Font;
                sbLabel2.Text = tbSql.Font.Name;
            }
        }
    }
}
