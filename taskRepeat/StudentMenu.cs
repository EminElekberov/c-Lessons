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
    public partial class StudentMenu : Form
    {
        List<Student> _st;

        public StudentMenu(List<Student> students)
        {
            InitializeComponent();
            _st = students;
            cmbAllShowStudent.Items.AddRange(students.ToArray());
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student select = cmbAllShowStudent.SelectedItem as Student;
            //listBox1.Items.Clear();
            //foreach (var item in _st)
            //{
            //    listBox1.Items.Add(item.FullName);
            //}
            txtName.Text = select.Name;
            txtEmail.Text = select.Email;
            txtSurname.Text = select.Surname;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Load(select.imgFile);
        }
        private void StudentMenu_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
        }

        private void cmbAllShowStudent_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }
    }
}
