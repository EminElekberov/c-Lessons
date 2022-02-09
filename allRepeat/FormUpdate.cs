using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace allRepeat
{
    public partial class FormUpdate : Form
    {
        private ComboBox _cmb;
        private DataGridView _dgv;
        public FormUpdate(List<Group> groups, ComboBox cmb, DataGridView dgv)
        {

            InitializeComponent();
            _cmb = cmb;
            _dgv = dgv;
            cmb_GroupUpdate.Items.AddRange(groups.ToArray());
        }

        private void FormUpdate_Load(object sender, EventArgs e)
        {
          
        }

        private void cmb_GroupUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
            Group group = cmb_GroupUpdate.SelectedItem as Group;
            cmb_studentUpdate.Items.Clear();
            cmb_studentUpdate.Items.AddRange(group.GetAlLStudent().ToArray());
        }

        private void cmb_studentUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Group group = cmb_GroupUpdate.SelectedItem as Group;
            Student student = cmb_studentUpdate.SelectedItem as Student;
            string name = txt_nameUpdate.Text.Trim();
            string surname = txt_surnameUpdate.Text.Trim();
            if (name==null && surname==null)
            {
                MessageBox.Show("fill area");
            }
            student.Name = name;
            student.Surname = surname;
            if (group == (Group)_cmb.SelectedItem)
            {
                _dgv.DataSource = null;
                _dgv.DataSource = group.GetAlLStudent();
            }
        }
    }
}
