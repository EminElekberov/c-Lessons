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
  
        private ComboBox _cmb;
        private DataGridView _dgv;
        public Form2(List<Group> groups, ComboBox cmb, DataGridView dgv)
        {
            
            InitializeComponent();
            _cmb = cmb;
            _dgv = dgv;
            cmb_GroupDelete.Items.AddRange(groups.ToArray());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Group selectgroup = cmb_GroupDelete.SelectedItem as Group;
                Student selectStudent = cmb_StudentDelete.SelectedItem as Student;
                selectgroup.DeleteStudent(selectStudent);
                if (selectgroup == (Group)_cmb.SelectedItem)
                {
                    _dgv.DataSource = null;
                    _dgv.DataSource = selectgroup.GetAlLStudent();
                }
                cmb_GroupDelete.Text = "";
                cmb_StudentDelete.Text = "";
                MessageBox.Show("Deleted");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //cmb_GroupDelete.DropDownStyle = ComboBoxStyle.DropDownList;
            //cmb_StudentDelete.DropDownStyle = ComboBoxStyle.DropDownList;
            //foreach (var item in _groups)
            //{
            //    cmb_GroupDelete.Items.Add(item);
            //}
        }

        private void cmb_GroupDelete_SelectedIndexChanged(object sender, EventArgs e)
        {
            Group selected_group = cmb_GroupDelete.SelectedItem as Group;
          
            cmb_StudentDelete.Items.AddRange(selected_group.GetAlLStudent().ToArray());
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
