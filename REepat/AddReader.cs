using REepat.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REepat
{
    public partial class AddReader : Form
    {
        private readonly LibraryMSEntities db;
        private static int readernumber;
        public AddReader()
        {
            InitializeComponent();
            db = new LibraryMSEntities();
        }
        public void datagridrefresh()
        {
            dataGridView1.DataSource = db.Readers.Select(x => new
            {
               ReaderNum =  x.id,
                x.Fullname,
                x.Email,
                x.IdentityNum

            }).ToList();
        }

        private void cleartxt()
        {
            txtemail.Text = "";
            txtidentity.Text = "";
            txtsearchidentity.Text = "";
            txtname.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            string email = txtemail.Text;
            string identity = txtidentity.Text;

            Model.Reader readerdb = db.Readers.FirstOrDefault(x => x.IdentityNum.ToLower() == identity.ToLower());

            if(name == "" || email =="" || identity == "")
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
            if (identity.Length < 11)
            {
                MessageBox.Show("Identiti Number would be 11 character", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (readerdb == null)
            {
                Model.Reader reader = new Model.Reader
                {
                    Email = email,
                    Fullname = name,
                    IdentityNum = identity.ToUpper()
                };

                db.Readers.Add(reader);
            }
            else
            {
                readerdb.Email = email;
                readerdb.Fullname = name;

            }

           
            datagridrefresh();
            cleartxt();
        }
        //
        private void AddReader_Load(object sender, EventArgs e)
        {
            datagridrefresh();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string identity = txtsearchidentity.Text;
            if (identity == "")
            {
                MessageBox.Show("Please Fill Identit Number !!!", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool identitydb = db.Readers.Any(x => x.IdentityNum.ToLower() == identity.ToLower());
           

            if (!identitydb)
            {
                MessageBox.Show("this not Reader !!!", "Warning",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Reader rdr = db.Readers.FirstOrDefault(x => x.IdentityNum.ToLower() == identity.ToLower());
            
            txtemail.Text = rdr.Email;
            txtidentity.Text = rdr.IdentityNum;
            txtname.Text = rdr.Fullname;
            readernumber = rdr.id;
            dataGridView1.DataSource = db.Readers.Where(x=>x.IdentityNum.ToLower()==identity.ToLower()).Select(x => new
            {
               ReaderNum = x.id,
                x.Fullname,
                x.Email,
                x.IdentityNum

            }).ToList();

            MessageBox.Show(readernumber.ToString());
           
        }
    }
}
