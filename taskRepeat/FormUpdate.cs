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
        private ComboBox _cmb;
        private DataGridView _dgv;
        List<Group> _groups;
        public FormUpdate(List<Group> groups,ComboBox combo,DataGridView dtv)
        {

            InitializeComponent();
            _cmb = combo;
            _groups = groups;
            _dgv = dtv;
            //cmb_GroupUpdate.Items.AddRange(groups.ToArray());
        }

        private void FormUpdate_Load(object sender, EventArgs e)
        {
            foreach (var item in _groups)
            {
                cmb_GroupUpdate.Items.Add(item);
            }
        }

        private void cmb_GroupUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            Group select = cmb_GroupUpdate.SelectedItem as Group;
            cmb_studentUpdate.Items.AddRange(select.GetAlLStudent().ToArray());
        }

        private void cmb_studentUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Group selectGroup = cmb_GroupUpdate.SelectedItem as Group;
            Student student = cmb_studentUpdate.SelectedItem as Student;
            string name = txt_nameUpdate.Text.Trim().ToLower();
            string surnme = txt_surnameUpdate.Text.Trim().ToLower();
            if (name=="" || surnme=="")
            {
                MessageBox.Show("doldur xanalari");
            }
            student.Name = name;
            student.Surname = surnme;
            MessageBox.Show("Success");
            if (selectGroup==_cmb.SelectedItem)
            {
                _dgv.DataSource = null;
                _dgv.DataSource = selectGroup.GetAlLStudent();
            }
        }
    }
}
