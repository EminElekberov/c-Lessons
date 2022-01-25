using LibraryApi.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApi
{
    public partial class AddReader : Form
    {
        private readonly LibraryEntities3 _db;

        public AddReader()
        {
            InitializeComponent();
            _db = new LibraryEntities3();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtname.Text.Trim();
            string email = txtemail.Text.Trim();
            string identity = txtidentity.Text.Trim();
            Model.Reader readerdb = _db.Readers.FirstOrDefault(x => x.IdentityNum.ToLower() == identity.ToLower());

            if (name == "" || email == "" || identity == "")
            {
                MessageBox.Show("Please Fill All TextBox !!!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!email.Contains("@"))
            {
                MessageBox.Show("email does not Correct !!!", "Warning",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (identity.Length < 11 && name.Length < 3)
            {
                MessageBox.Show("Identiti and name are wrong", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (readerdb == null)
            {
                Model.Reader reader = new Model.Reader
                {
                    Email = email,
                    Fullanme = name,
                    IdentityNum = identity.ToUpper()
                };
                MessageBox.Show("success");
                _db.Readers.Add(reader);
                _db.SaveChanges();
                DgvRefreh();
            }
        }
        private void DgvRefreh()
        {
            dataGridView1.DataSource = _db.Readers.Select(x => new
            {
                ReaderNum = x.Id,
                x.Fullanme,
                x.Email,
                x.IdentityNum
            }).ToList();
        }

        private void AddReader_Load(object sender, EventArgs e)
        {
            DgvRefreh();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = txtname.Text.Trim();
            string email = txtemail.Text.Trim();
            string identity = txtidentity.Text.Trim();
            Model.Reader updatereader = _db.Readers.FirstOrDefault(x => x.IdentityNum.ToLower() == identity.ToLower());
            if (updatereader == null)
            {
                MessageBox.Show("This name is not exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                updatereader.Email = email;
                updatereader.Fullanme = name;
            }
            MessageBox.Show("success");
            _db.SaveChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtname.Text.Trim();
            string email = txtemail.Text.Trim();
            if (name == "" && email == "")
            {
                MessageBox.Show("Please Fill All TextBox !!!", "Warning",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Model.Reader reader = _db.Readers.FirstOrDefault(x => x.Email.ToLower() == email.ToLower());
            if (reader == null)
            {
                MessageBox.Show("this User does not Registered", "Warning",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _db.Readers.Remove(reader);
            _db.SaveChanges();
            DgvRefreh();
            // MessageBox.Show("succcess");
        }
    }
}
