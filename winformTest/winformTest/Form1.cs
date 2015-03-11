using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace winformTest
{
    public partial class Form1 : Form
    {
        private int errorTimes = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string[] lines = this.txtInput.Lines;
            string name = "";
            int score = 0;
            int maxScore = 0;

            foreach(string line in lines)
            {
                string[] str = line.Split('=');
                
                if(int.TryParse(str[1],out score))
                {
                    if (score>maxScore)
                    {

                        maxScore = score;
                       name = str[0].Trim();

                    }


                }
                else 
                {
                    MessageBox.Show("格式错误");
                    return;
                }
            
            }
            txtOutput.AppendText(name);
            txtOutput.AppendText("=");
            txtOutput.AppendText(maxScore.ToString());


        }
    }
}
