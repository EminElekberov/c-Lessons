using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace taskRepeat
{
    public partial class FormUpdate : Form
    {
        ComboBox cmb;
        DataGridView dgv;
        public FormUpdate(List<Group> _groups,ComboBox combo,DataGridView data)
        {

            InitializeComponent();
            cmb = combo;
            dgv = data;
            cmb_GroupUpdate.Items.AddRange(_groups.ToArray());
           
        }

        private void FormUpdate_Load(object sender, EventArgs e)
        {
           
        }

        private void cmb_GroupUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            Group group = cmb_GroupUpdate.SelectedItem as Group;
            cmb_studentUpdate.Items.AddRange(group.GetAllStudent().ToArray());
        }

        private void cmb_studentUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = txt_nameUpdate.Text.Trim();
            string surname = txt_surnameUpdate.Text.Trim();
            Group group = cmb_GroupUpdate.SelectedItem as Group;
            Student student = cmb_studentUpdate.SelectedItem as Student;
            if (name!=null && surname!=null)
            {
                student.Name = name;
                student.Surname = surname;
                if (group==cmb_GroupUpdate.SelectedItem)
                {
                    dgv.DataSource = null;
                    dgv.DataSource = group.GetAllStudent();
                }
                MessageBox.Show("success");
            }
        }
    }
}
