using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace SimpleReplacer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (chkRegex.Checked)
            {
                txtAfter.Text = replaceRegex(txtBefore.Text);
            }
            else
            {
                txtAfter.Text = replaceNormal(txtBefore.Text);
            }
        }

        private string replaceRegex(string txtBefore)
        {
            //string dirpath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\Desktop\";
            string dirpath = @".\";
            string filename = txtConvFileName.Text; // TSV File
            string[] strReplArray = File.ReadAllLines(dirpath + filename, Encoding.UTF8);

            string strBuff = "";
            strBuff = txtBefore;

            for (int cnt = 0; cnt < strReplArray.GetLength(0); cnt++)
            {
                string[] pairStr = strReplArray[cnt].Split('\t');

                StringBuilder strread = new StringBuilder();
                string[] strarray = strBuff.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                for (int i = 0; i < strarray.GetLength(0); i++)
                {
                    strread.AppendLine(Regex.Replace(strarray[i],pairStr[0], pairStr[1]));
                }
                strBuff = strread.ToString();
            }
            return strBuff.TrimEnd();
        }
        private string replaceNormal(string txtBefore)
        {
            //string dirpath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\Desktop\";
            string dirpath = @".\";
            string filename = txtConvFileName.Text; // TSV File
            string[] strReplArray = File.ReadAllLines(dirpath + filename, Encoding.UTF8);

            string strBuff = "";
            //strBuff = txtBefore.Text;
            strBuff = txtBefore;

            for (int cnt = 0; cnt < strReplArray.GetLength(0); cnt++)
            {
                string[] pairStr = strReplArray[cnt].Split('\t');

                StringBuilder strread = new StringBuilder();
                string[] strarray = strBuff.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                for (int i = 0; i < strarray.GetLength(0); i++)
                {
                    if (strarray[i].Contains(pairStr[0]) == true)
                    {
                        strread.AppendLine(strarray[i].Replace(pairStr[0], pairStr[1]));
                    }
                    else
                    {
                        strread.AppendLine(strarray[i]);
                    }
                }
                strBuff = strread.ToString();
            }
            return strBuff.TrimEnd();
        }

        private void txtBefore_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A) {
                txtBefore.SelectAll();
            }
        }
        private void txtAfter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A) {
                txtAfter.SelectAll();
            }
        }
    }
}
