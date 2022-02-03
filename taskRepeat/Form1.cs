using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taskRepeat
{
    public partial class Form1 : Form
    {
        public List<Student> _students;
        public List<string> img;
        public Form1()
        {
            InitializeComponent();
            _students = new List<Student>();
            img = new List<string>();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string surname = txtSurname.Text.Trim();
            string email = txtEmail.Text.Trim();
            string img_loctaion;
            try
            {
                img_loctaion = img[0];
                Student st = new Student
                {
                    Name = name,
                    Surname = surname,
                    Email = email,
                    imgFile = img_loctaion
                };
                _students.Add(st);
                pictureBox1.Image = null;
                MessageBox.Show("Success");
                txtEmail.Clear();
                txtName.Clear();
                txtSurname.Clear();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void BtnLoad_Click(object sender, EventArgs e)
        {
            DialogResult dialog = openFileDialog1.ShowDialog();
            if (dialog==DialogResult.OK)
            {
                if (img.Count != 0)
                {
                    img.Clear();
                }
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Load(openFileDialog1.FileName);
                img.Add(openFileDialog1.FileName);
            }
        }

        private void btnStudentMenu_Click(object sender, EventArgs e)
        {
            StudentMenu studentMenu = new StudentMenu(_students);
            studentMenu.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
