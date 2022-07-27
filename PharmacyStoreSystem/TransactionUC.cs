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
    public partial class TransactionUC : UserControl
    {
        public TransactionUC()
        {
            InitializeComponent();
         //   ShowTransactionAll();
        }

        public void ResetTransactionId()
        {
            SqlConnection Con = new SqlConnection(@System.Configuration.ConfigurationManager.ConnectionStrings["DataBaseString"].ConnectionString);

            Con.Open();

            SqlCommand cmd = new SqlCommand("DBCC CHECKIDENT('Transaction_tbl',RESEED,0)", Con);
            cmd.ExecuteNonQuery();

            SqlCommand cmd1 = new SqlCommand("DBCC CHECKIDENT('Transaction_tbl',RESEED)", Con);
            cmd1.ExecuteNonQuery();


            Con.Close();
        }

        public void ShowTransactionAll()
        {
            ResetTransactionId();
            SqlConnection Con = new SqlConnection(@System.Configuration.ConfigurationManager.ConnectionStrings["DataBaseString"].ConnectionString);

            Con.Open();

            string Myquery = "SELECT * FROM Transaction_tbl";
            SqlDataAdapter sda = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cmb = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);

            TransactionDGV1.DataSource = ds.Tables[0];
            TransactionDGV1.ReadOnly = true;

            Con.Close();
        }

        public void ShowTransactionByDay(string Day)
        {
            SqlConnection Con = new SqlConnection(@System.Configuration.ConfigurationManager.ConnectionStrings["DataBaseString"].ConnectionString);

            Con.Open();

            string Myquery = "SELECT * FROM Transaction_tbl";
            SqlDataAdapter sda = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cmb = new SqlCommandBuilder(sda);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            DataView dv = new DataView(dt);

            dv.RowFilter = string.Format("TransacDate LIKE '%{0}%' ", Day);
            TransactionDGV1.DataSource = dv;

            Con.Close();
        }

        public void ShowTransactionByMonth(string Month)
        {
            SqlConnection Con = new SqlConnection(@System.Configuration.ConfigurationManager.ConnectionStrings["DataBaseString"].ConnectionString);

            Con.Open();

            string Myquery = "SELECT * FROM Transaction_tbl";
            SqlDataAdapter sda = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cmb = new SqlCommandBuilder(sda);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            DataView dv = new DataView(dt);

            dv.RowFilter = string.Format("TransacDate LIKE '%{0}%' ", Month);
            TransactionDGV1.DataSource = dv;

            Con.Close();
        }

        public void ShowTransactionByYear(string Year)
        {
            SqlConnection Con = new SqlConnection(@System.Configuration.ConfigurationManager.ConnectionStrings["DataBaseString"].ConnectionString);

            Con.Open();

            string Myquery = "SELECT * FROM Transaction_tbl";
            SqlDataAdapter sda = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cmb = new SqlCommandBuilder(sda);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            DataView dv = new DataView(dt);

            dv.RowFilter = string.Format("TransacDate LIKE '%{0}%' ", Year);
            TransactionDGV1.DataSource = dv;

            Con.Close();
        }

        private void SearchDaycomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Day = SearchDaycomboBox1.SelectedItem.ToString();
            ShowTransactionByDay(Day);
        }

        private void SearchMonthcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Month = SearchMonthcomboBox1.SelectedItem.ToString();
            ShowTransactionByDay(Month);
        }

        private void SearchYearcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Year = SearchYearcomboBox1.SelectedItem.ToString();
            ShowTransactionByDay(Year);
        }

        public void ResetCombobox()
        {
            SearchDaycomboBox1.Text = "Search by Day";
            SearchMonthcomboBox1.Text = "Search by Month";
            SearchYearcomboBox1.Text = "Search by Year";
        }

        private void ShowAllTransacBtn1_Click(object sender, EventArgs e)
        {
            ShowTransactionAll();
            ResetCombobox();
        }

        private void RemoveBtn3_Click(object sender, EventArgs e)
        {

            if (TransactionDGV1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("No row is selected to remove.");
            }
            else if (TransactionDGV1.SelectedRows[0].Cells[0].Value == null)
            {
                MessageBox.Show("User has selected an Empty Row.");
            }
            else if (TransactionDGV1.SelectedRows[0].Cells[0].Value == null || TransactionDGV1.Rows.Count <= 1)
            {
                MessageBox.Show("User has selected an empty Row.");
            }
            else
            {
                try
                {

                    SqlConnection Con = new SqlConnection(@System.Configuration.ConfigurationManager.ConnectionStrings["DataBaseString"].ConnectionString);

                    Con.Open();

                    string Id = TransactionDGV1.SelectedRows[0].Cells[0].Value.ToString();

                    SqlCommand cmd = new SqlCommand("DELETE FROM Transaction_tbl where TransacId = @ID", Con);
                    cmd.Parameters.AddWithValue("@ID", Id);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Transaction Removed Successfully.");

                    Con.Close();

                    ResetTransactionId();
                    ShowTransactionAll();
                    
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void BillDGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TransactionUC_Load(object sender, EventArgs e)
        {

        }


    }
}
