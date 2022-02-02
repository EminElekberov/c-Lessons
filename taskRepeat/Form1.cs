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
        List<Student> _student;
        List<Group> _groups;
        public Form1()
        {
            InitializeComponent();
            _student = new List<Student>();
            _groups = new List<Group>();
            Group group = new Group("P659");
            Group group2 = new Group("P896");
            Student s1 = new Student("Eli", "Eliyev");
            Student s2 = new Student("Mina", "Farzali");
            Student s3 = new Student("Xeyal", "Eliyev");
            group.AddStudent(s1);
            group2.AddStudent(s2);
            group2.AddStudent(s3);
            _groups.Add(group);
            _groups.Add(group2);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_select.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (var item in _groups)
            {
                cmb_select.Items.Add(item);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text.Trim();
            string surname = txt_surname.Text.Trim();
            Group selectGroup = cmb_select.SelectedItem as Group;
            Student student = new Student(name, surname);
            selectGroup.AddStudent(student);
            dt_grid.DataSource = null;
            dt_grid.DataSource = selectGroup.GetAllStudent();
        }
        private void ListStudent()
        {
        }
        private void cmb_select_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(_groups, cmb_select, dt_grid);
            form2.ShowDialog();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUpdate formUpdate = new FormUpdate(_groups, cmb_select, dt_grid);
            formUpdate.ShowDialog();
        }

        private void dt_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
