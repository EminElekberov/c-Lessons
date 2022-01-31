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
        public List<Group> _groups;
        public List<Student> _student;
        public Form1()
        {
            _student = new List<Student>();
            _groups = new List<Group>();
            InitializeComponent();
            _groups.Add(new Group("P609"));
            _groups.Add(new Group("P506"));
            foreach (var item in _groups)
            {
                cmb_select.Items.Add(item);
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_select.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_select.SelectedIndex = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text.Trim().ToLower();
            string surname = txt_surname.Text.Trim().ToLower();
            string bGorupNo = cmb_select.Text.Trim();
            Student student = new Student
            {
                Name = name,
                Surname = surname,
                GroupNo = bGorupNo
            };
            _student.Add(student);
            dt_grid.DataSource = _student;
        }
        private void ListStudent()
        {
            dt_grid.DataSource = cmb_select;
        }
        private void cmb_select_SelectedIndexChanged(object sender, EventArgs e)
        {

            string name = cmb_select.Text.Trim();
            foreach (Student item in _student)
            {
                if (cmb_select.Text.Trim() == item.Name)
                {
                    dt_grid.DataSource = _student;
                }
            }
            ListStudent();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(_student,_groups);
            form2.ShowDialog();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dt_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
