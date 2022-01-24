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
using video26.View;

namespace video26
{
    public partial class TypeDelete : Form
    {
        private readonly MedicineCsharp03Entities _db;

        public TypeDelete()
        {
            InitializeComponent();
            _db = new MedicineCsharp03Entities();

        }

        private void TypeDelete_Load(object sender, EventArgs e)
        {
            cmbDeleteType.DataSource = _db.Types.Where(t => t.Deleted == false).Select(t => new Cb_Types
            {
                Id = t.id,
                Name = t.Name
            }).ToArray();
        }

        private void BtnTypeDelete_Click(object sender, EventArgs e)
        {
            int id = ((Cb_Types)cmbDeleteType.SelectedItem).Id;
            video26.Model.Type type = _db.Types.Find(id);
            type.Deleted = true;
            _db.SaveChanges();
            MessageBox.Show("Succesfully deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
