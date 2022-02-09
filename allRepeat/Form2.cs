using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace allRepeat
{
    public partial class Form2 : Form
    {
        private ComboBox _cmb;
        private DataGridView _dgv;
        public Form2(List<Group> groups,ComboBox cmb,DataGridView dataGridView)
        {
           
            InitializeComponent();
            _cmb = cmb;
            _dgv = dataGridView;
            cmb_GroupDelete.Items.AddRange(groups.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Group selgroup = cmb_GroupDelete.SelectedItem as Group;
            Student student = cmb_StudentDelete.SelectedItem as Student;
            selgroup.RemoveStudent(student);
            if (selgroup == (Group)_cmb.SelectedItem)
            {
                _dgv.DataSource = null;
                _dgv.DataSource = selgroup.GetAlLStudent();
            }
            cmb_GroupDelete.Text = "";
            cmb_StudentDelete.Text = "";
            MessageBox.Show("Deleted");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void cmb_GroupDelete_SelectedIndexChanged(object sender, EventArgs e)
        {
            Group selectGroup = cmb_GroupDelete.SelectedItem as Group;
            cmb_StudentDelete.Items.Clear();
            cmb_StudentDelete.Items.AddRange(selectGroup.GetAlLStudent().ToArray());
        }
    }
}
