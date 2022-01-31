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
        public List<Student> _students;
        public List<Group> _groups;
        public Form2(List<Student> students,List<Group> groups)
        {
            _students = students;
            _groups = groups;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cmb_GroupDelete.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_StudentDelete.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (var item in _groups)
            {
                cmb_GroupDelete.Items.Add(item);
            }
        }

        private void cmb_GroupDelete_SelectedIndexChanged(object sender, EventArgs e)
        {
            Group selectedGorup = cmb_GroupDelete.SelectedItem as Group;
            mbStuDelete.Items.Clear();
            cmbStuDelete.Text = "";
            cmb_StudentDelete.Items.Add()
        }
    }
}
