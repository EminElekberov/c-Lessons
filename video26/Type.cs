using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using video26.Model;

namespace video26
{
    public partial class Type : Form
    {
        private readonly MedicineCsharp03Entities _db;

        public Type()
        {
            InitializeComponent();
            _db = new MedicineCsharp03Entities();

        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            string typeName = txtType.Text.Trim();
            if (typeName=="")
            {
                MessageBox.Show("Error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_db.Types.Any(x=>x.Name==typeName))
            {
                MessageBox.Show("Bu ad var", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            video26.Model.Type test = new Model.Type
            {
                Name=typeName
            };
            _db.Types.Add(test);
            _db.SaveChanges();
            MessageBox.Show("Successfully added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close();
        }

        private void Type_Load(object sender, EventArgs e)
        {

        }
    }
}
