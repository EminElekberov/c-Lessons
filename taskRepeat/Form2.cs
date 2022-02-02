using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace taskRepeat
{
    public partial class Form2 : Form
    {
        public ComboBox cmb;
        public DataGridView dgv;
        public Form2(List<Group> groups,ComboBox combo,DataGridView dataGrid )
        {
            
            InitializeComponent();
            cmb = combo;
            dgv = dataGrid;
            cmb_GroupDelete.Items.AddRange(groups.ToArray());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Group select = cmb_GroupDelete.SelectedItem as Group;
            Student student = cmb_StudentDelete.SelectedItem as Student;
            select.RemoveStudent(student);
            if (select==cmb.SelectedItem)
            {
                dgv.DataSource = null;
                dgv.DataSource = select.GetAllStudent();
            }
            MessageBox.Show("success");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void cmb_GroupDelete_SelectedIndexChanged(object sender, EventArgs e)
        {
            Group select = cmb_GroupDelete.SelectedItem as Group;
            cmb_StudentDelete.Items.AddRange(select.GetAllStudent().ToArray()); 
        }

        private void cmb_StudentDelete_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
