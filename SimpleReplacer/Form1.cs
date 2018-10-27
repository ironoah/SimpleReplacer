using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;

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
            string dirpath = @"";
            string filename = "replace_data.tsv";
            string[] strReplArray = File.ReadAllLines(dirpath + filename, Encoding.UTF8);

            string strBuff = "";
            strBuff = txtBefore.Text;

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
            txtAfter.Text = strBuff.TrimEnd();
        }

        private void txtBefore_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
                txtBefore.SelectAll();
        }
        private void txtAfter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
                txtAfter.SelectAll();
        }
    }
}
