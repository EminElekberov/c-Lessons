using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using video26.Model;
using video26.View;

namespace video26
{
    public partial class Medicines : Form
    {
        private readonly MedicineCsharp03Entities _db;

        public Medicines()
        {
            InitializeComponent();
            _db = new MedicineCsharp03Entities();
        }

        private void Medicines_Load(object sender, EventArgs e)
        {
            #region
            //cmbType.DataSource = _db.Types.Select(x => x.Name).ToList();
            #endregion
            cmbType.DataSource = _db.Types.Where(t => t.Deleted == false).Select(t => new Cb_Types
            {
                Id = t.id,
                Name = t.Name
            }).ToArray();
            Refreshdgv();
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = ((Cb_Types)cmbType.SelectedItem).Id;
            dataGridView1.DataSource = _db.Medicines.Where(m => m.Isdeleted == false && m.TypesId == id).Select(x => new
            {
                x.Name,
                Type = x.Type.Name,
                x.Price,
                x.Amount
            }).ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region
            //string conn = ConfigurationManager.ConnectionStrings["FirstRegisterApiStudent"].ConnectionString;
            //SqlConnection sqlConnection = null;
            //SqlCommand sqlCommand = null;
            //SqlDataReader sqlDataReader = null;
            //try
            //{

            //    sqlConnection=new SqlConnection(conn);
            //    sqlConnection.Open();
            //    sqlCommand = new SqlCommand("insert into Medicines([Name],Price,Amount,TypesId) values ('" + txtMedicines.Text.Trim()+ "','" + txtPrice.Text.Trim() + "','" + txtAmount.Text.Trim() + "','" + cmbType.Text.Trim() + "')" + sqlConnection);
            //    SqlDataReader dr = sqlCommand.ExecuteReader();
            //    if (dr.Read() == true)
            //    {
            //        MessageBox.Show("Success");
            //    }
            //}
            //catch (Exception)
            //{

            //    throw new Exception();
            //}
            //finally
            //{
            //    sqlConnection.Close();
            //}
            #endregion
            #region
            //string type = cmbType.Text.Trim();
            //string Fullname = txtMedicines.Text.Trim();
            //float price = Convert.ToSingle(txtPrice);
            //int amount = Convert.ToInt32(txtAmount);
            //if (!(IsValid(type, Fullname, amount, price)))
            //{
            //    MessageBox.Show("Error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //bool TypeinDb = _db.Medicines.Any(x => x.Name == Fullname);
            //if (TypeinDb)
            //{
            //    MessageBox.Show("Email alredat exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //try
            //{
            //    Medicine user = new Medicine
            //    {
            //       Name=Fullname,
            //       Price=price,
            //       Amount=amount,
            //       TypesId=Convert.ToInt32(type)
            //    };
            //    _db.Medicines.Add(user);
            //    _db.SaveChanges();
            //}
            //catch (Exception)
            //{

            //    throw;
            //}


            //MessageBox.Show("Successfully Registr", "Success", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            #endregion
            string name = txtMedicines.Text.Trim().ToLower();
            if (name=="")
            {
                MessageBox.Show("Please filled", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            int typeId = ((Cb_Types)cmbType.SelectedItem).Id;
            int amount = int.Parse(txtAmount.Value.ToString());
            float price =float.Parse(txtPrice.Value.ToString());
            Medicine medicine = _db.Medicines.FirstOrDefault(x => x.Name.ToLower() == name);
            if (medicine==null)
            {
                Medicine medicineDb = new Medicine
                {
                    Name=name,
                    TypesId=typeId,
                    Price=price,
                    Amount=amount,
                    Isdeleted=false
                };
                _db.Medicines.Add(medicineDb);
            }
            else
            {
                medicine.Amount += amount;
                medicine.TypesId = typeId;
                medicine.Price = price;
            }
            _db.SaveChanges();
            MessageBox.Show("Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Refreshdgv();
            RefreshAllFields();

        }
        private bool IsValid(string type, string fullname, int amount, float price)
        {
            if (type == "" || fullname == "" || amount ==null|| price ==null)
            {
                MessageBox.Show("Fill", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        public void Refreshdgv()
        {
            dataGridView1.DataSource = _db.Medicines.Where(m => m.Isdeleted == false).Select(x => new
            {
                x.Name,
                Type=x.Type.Name,
                x.Price,
                x.Amount
            }).ToList();
        }
        public void RefreshAllFields()
        {
            txtMedicines.Text = "";
            txtAmount.Value = 0;
            txtPrice.Value = 0;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string name = txtMedicines.Text.Trim().ToLower();
            Medicine medicine = _db.Medicines.FirstOrDefault(x => x.Name.ToLower() == name);
            if (medicine!=null)
            {
                medicine.Isdeleted = true;
                _db.SaveChanges();
                Refreshdgv();
                RefreshAllFields();
                MessageBox.Show("Deleted", "DEleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("This is not exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
         
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RefreshAllFields();
            string name = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            Medicine med = _db.Medicines.FirstOrDefault(m => m.Name == name);
            txtMedicines.Text = name;
            txtAmount.Value = decimal.Parse(med.Amount.ToString());
            txtPrice.Value =decimal.Parse(med.Price.ToString());
            cmbType.SelectedIndex = cmbType.FindString(med.Type.Name);
        }
    }
}
