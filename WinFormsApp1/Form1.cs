using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Student> _student;
        public Form1()
        {
            _student = new List<Student>();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string fname = txt_Name.Text.Trim();
            string fsurname = txtSurname.Text.Trim();
            string femail = txtEmail.Text.Trim();
            try
            {
                Student student = new Student
                {
                    Name = fname,
                    Surname = fsurname,
                    Email = femail
                };
                _student.Add(student);
            }
            catch (Exception)
            {
                MessageBox.Show("xais olunur xanali doldurun ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            FillLIst();
        }
        private void FillLIst()
        {
            listStudent.Items.Clear();//updte edir. demelio bunun  yazmasa idik bizim evvelce yadigimiz melumatlarda yeniden gelecekdi
            foreach (var item in _student)
            {
                listStudent.Items.Add(item.Fullname+" "+item.Email);
            }
        }

        private void listStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
