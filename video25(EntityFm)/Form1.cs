using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using video25_EntityFm_.NewFolder1;

namespace video25_EntityFm_
{
    public partial class Form1 : Form
    {

        private readonly Csharp03Entities1 db;
        public Form1()
        {
            InitializeComponent();
            db = new Csharp03Entities1();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCountry.DataSource = db.Countries.Select(x => x.Name).ToList();
        }

        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            string country = cmbCountry.Text;
            if (!string.IsNullOrEmpty(country))
            {
                Country countryResult = db.Countries.FirstOrDefault(x => x.Name == country);
                if (countryResult.Cities.Count==0)
                {
                    MessageBox.Show("null");
                    cmbcity.Text = "";
                }
                cmbcity.DataSource = countryResult.Cities.Select(x => x.Name).ToList();
            }
        }
    }
}
