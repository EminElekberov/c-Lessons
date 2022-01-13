using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace threadWinform
{
    public partial class Form1 : Form
    {
        private long? Total = null;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            #region
            Sum(9999999);
            textBox1.Text = Total.ToString();
            #endregion
            //Thread t = new Thread(Sum);
            //t.Start(1000000);
            //while (Total == null)
            //{
            //    label1.Text = "buttona click edin";
            //}
            //textBox1.Text = Total.ToString();
        }
        private void Sum(long number)
        {
            long sum = 0;
            for (long i = 0; i < number; i++)
            {
                sum += i;
            }
            Total = sum;
        }
        private void Sum(object number)
        {
            long sum = 0;
            for (long i = 0; i < Convert.ToInt64(number); i++)
            {
                sum += i;
            }
            Total = sum;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
