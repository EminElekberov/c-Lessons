using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace allRepeat
{
    public partial class Form1 : Form
    {
        public List<Group> _groups = new List<Group>();
        public Form1()
        {
            
            InitializeComponent();
            Student s1 = new Student("Eli", "Eliyev");
            Student s2 = new Student("Mina", "Farzali");
            Student s3 = new Student("Xeyal", "Eliyev");

            Group group1 = new Group("P500");
            Group group2 = new Group("P505");

            group1.AddStudent(s1);
            group1.AddStudent(s2);
            group2.AddStudent(s3);

            _groups.Add(group1);
            _groups.Add(group2);
            cmb_select.Items.AddRange(_groups.ToArray());
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_select.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text.Trim();
            string surname = txt_surname.Text.Trim();

            if (name == "" || surname == "")
            {
                MessageBox.Show("Doldur", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Student student = new Student(name, surname);
            Group selectGroup = (Group)cmb_select.SelectedItem;
            selectGroup.AddStudent(student);
            dt_grid.DataSource = null;
            dt_grid.DataSource = selectGroup.GetAlLStudent();
            txt_name.Text = "";
            txt_surname.Text = "";

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
            FormUpdate update = new FormUpdate(_groups, cmb_select, dt_grid);
            update.ShowDialog();
        }
       
    }
}
