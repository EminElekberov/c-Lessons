using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            string txt = txtResult.Text.Trim();
            string text1 =(txt1.Text.Trim());
            string text2 = (textBox2.Text.Trim());
            
            int res78 = Convert.ToInt32(text1);
            int res2 = Convert.ToInt32(text2);
            int sum = res78 + res2;
            txtResult.Text = sum.ToString();
        }

        private void buttonCix_Click(object sender, EventArgs e)
        {
            string txt = txtResult.Text.Trim();
            string text1 = (txt1.Text.Trim());
            string text2 = (textBox2.Text.Trim());

            int res78 = Convert.ToInt32(text1);
            int res2 = Convert.ToInt32(text2);
            int sum = res78 - res2;
            txtResult.Text = sum.ToString();
        }

        private void buttonDevide_Click(object sender, EventArgs e)
        {
            string txt = txtResult.Text.Trim();
            string text1 = (txt1.Text.Trim());
            string text2 = (textBox2.Text.Trim());

            int res78 = Convert.ToInt32(text1);
            int res2 = Convert.ToInt32(text2);
            int sum = res78 / res2;
            txtResult.Text = sum.ToString();
        }

        private void buttonMultiple_Click(object sender, EventArgs e)
        {
            string txt = txtResult.Text.Trim();
            string text1 = (txt1.Text.Trim());
            string text2 = (textBox2.Text.Trim());

            int res78 = Convert.ToInt32(text1);
            int res2 = Convert.ToInt32(text2);
            int sum = res78 * res2;
            txtResult.Text = sum.ToString();
        }
    }
}
