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
    public partial class Readers : Form
    {
        private readonly LibraryEntities2 _db;
        public Readers()
        {
            InitializeComponent();
            _db = new LibraryEntities2();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtname.Text.Trim().ToLower();
            string email = txtemail.Text.Trim().ToLower();
            string identity = txtidentity.Text.Trim().ToLower();
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
            if (identity.Length < 11 && name.Length<3)
            {
                MessageBox.Show("identiy and name wrong", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Model.Reader reader = _db.Readers.FirstOrDefault(x => x.IdentityNum.ToLower() == identity);
            if (reader==null)
            {
                Model.Reader newReader = new Model.Reader
                {
                    Email = email,
                    IdentityNum=identity,
                    Fullanme=name
                    
                };
                MessageBox.Show("success");
                _db.Readers.Add(newReader);
                _db.SaveChanges();
                datagridrefresh();
                txtemail.Text = "";
                txtidentity.Text = "";
                txtname.Text = "";
            }

        }
        public void datagridrefresh()
        {
            StudentListDtv.DataSource = _db.Readers.Select(x => new
            {
                ReaderNum = x.Id,
                x.Fullanme,
                x.Email,
                x.IdentityNum
            }).ToList();
        }

        private void Readers_Load(object sender, EventArgs e)
        {
            datagridrefresh();
        }
    }
}
