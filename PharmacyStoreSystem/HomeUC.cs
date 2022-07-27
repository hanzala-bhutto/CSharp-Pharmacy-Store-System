using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PharmacyStoreSystem
{
    public partial class HomeUC : UserControl
    {
        public HomeUC()
        {
            InitializeComponent();
            //CountMedStock();
        }

        public void CountMedStock()
        {
            SqlConnection Con = new SqlConnection(@System.Configuration.ConfigurationManager.ConnectionStrings["DataBaseString"].ConnectionString);

            Con.Open();

            SqlCommand cmd = new SqlCommand("SELECT Count(*) FROM MedicineStock_tbl",Con);
            MedCountValueLabel1.Text = cmd.ExecuteScalar().ToString();

            Con.Close();

        }

        public void SumTotalSales()
        {
            SqlConnection Con = new SqlConnection(@System.Configuration.ConfigurationManager.ConnectionStrings["DataBaseString"].ConnectionString);

            Con.Open();

            SqlCommand cmd = new SqlCommand("SELECT SUM(TotAmnt) FROM Transaction_tbl", Con);
            TotSalesValueLabel1.Text = cmd.ExecuteScalar().ToString();

            Con.Close();

            if(TotSalesValueLabel1.Text == "")
            {
                TotSalesValueLabel1.Text = "0";
            }

        }
        
        public void SumTotalProfit()
        {
            SqlConnection Con = new SqlConnection(@System.Configuration.ConfigurationManager.ConnectionStrings["DataBaseString"].ConnectionString);

            Con.Open();

            SqlCommand cmd = new SqlCommand("SELECT SUM(Profit) FROM Transaction_tbl", Con);
            TotProfitValueLabel1.Text = cmd.ExecuteScalar().ToString();

            Con.Close();

            if (TotProfitValueLabel1.Text == "")
            {
                TotProfitValueLabel1.Text = "0";
            }
        }

        public void SumTotalLoss()
        {
            SqlConnection Con = new SqlConnection(@System.Configuration.ConfigurationManager.ConnectionStrings["DataBaseString"].ConnectionString);

            Con.Open();

            SqlCommand cmd = new SqlCommand("SELECT SUM(Loss) FROM Transaction_tbl", Con);
            TotLossValueLabel1.Text = cmd.ExecuteScalar().ToString();

            Con.Close();

            if (TotLossValueLabel1.Text == "")
            {
                TotLossValueLabel1.Text = "0";
            }
        }


        private void HomeUC_Load(object sender, EventArgs e)
        {

        }
    }
}
