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
    public partial class MedicineStockUC : UserControl
    {

        public MedicineStockUC()
        {
            InitializeComponent();
 //           populateSearchMedcomboBox1();
 //           ShowMedicineAll();
        }

        public void populateSearchMedcomboBox1()
        {


            SqlConnection Con = new SqlConnection(@System.Configuration.ConfigurationManager.ConnectionStrings["DataBaseString"].ConnectionString);
            Con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM MedicineStock_tbl",Con);
            SqlDataReader reader;
            DataTable dt = new DataTable();
            dt.Columns.Add("MedName", typeof(string));
            reader = cmd.ExecuteReader();
            dt.Load(reader);
            
            SearchMedcomboBox1.ValueMember = "MedName";
            SearchMedcomboBox1.DataSource = dt;
            Con.Close();

            ClearFields();

        }


        public void ShowMedicineAll()
        {

             SqlConnection Con = new SqlConnection(@System.Configuration.ConfigurationManager.ConnectionStrings["DataBaseString"].ConnectionString);

             Con.Open();

             string Myquery = "SELECT * FROM MedicineStock_tbl";
             SqlDataAdapter sda = new SqlDataAdapter(Myquery , Con);
             SqlCommandBuilder cmb = new SqlCommandBuilder(sda);
             var ds = new DataSet();
             sda.Fill(ds);

             MedStockDGV1.DataSource = ds.Tables[0];
             MedStockDGV1.ReadOnly = true;

             Con.Close();

            ClearFields();

        }

        public void ShowMedicineOfName(string MedicineName)
        {
            MedTypecomboBox2.SelectedItem = "All";
            SqlConnection Con = new SqlConnection(@System.Configuration.ConfigurationManager.ConnectionStrings["DataBaseString"].ConnectionString);

            Con.Open();

            string Myquery = "SELECT * FROM MedicineStock_tbl";
            SqlDataAdapter sda = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cmb = new SqlCommandBuilder(sda);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            DataView dv = new DataView(dt);

            dv.RowFilter = string.Format("MedName LIKE '%{0}%' ", MedicineName);
            MedStockDGV1.DataSource = dv;

            Con.Close();

            ClearFields();
        }

        public void ShowMedicineOfType(string MedicineType)
        {

            SqlConnection Con = new SqlConnection(@System.Configuration.ConfigurationManager.ConnectionStrings["DataBaseString"].ConnectionString);

            Con.Open();

            string Myquery = "SELECT * FROM MedicineStock_tbl";
            SqlDataAdapter sda = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cmb = new SqlCommandBuilder(sda);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            DataView dv = new DataView(dt);

            dv.RowFilter = string.Format("MedType LIKE '%{0}%' ", MedicineType);
            MedStockDGV1.DataSource = dv;

            Con.Close();

            ClearFields();

        }

        private void AddButton1_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@System.Configuration.ConfigurationManager.ConnectionStrings["DataBaseString"].ConnectionString);

            if (MedNameTextBox1.Text == "" || MedTypecomboBox1.Text == "" || MedQuantityTextBox1.Text == "" || BuyingPTextBox1.Text == "" || SellingPTextBox1.Text == "")
            {
                MessageBox.Show("Missing Information.");
            }
            else
            {
                try
                {
                    Con.Open();
                    
                    SqlCommand cmd = new SqlCommand("INSERT INTO MedicineStock_tbl(MedName,MedType,MedQty,MedBprice,MedSprice,MedExpDate) VALUES(@MN,@MT,@MQ,@MBP,@MSP,@MEDT)", Con);
                    cmd.Parameters.AddWithValue("@MN",MedNameTextBox1.Text);
                    cmd.Parameters.AddWithValue("@MT", MedTypecomboBox1.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@MQ", MedQuantityTextBox1.Text);
                    cmd.Parameters.AddWithValue("@MBP", BuyingPTextBox1.Text);
                    cmd.Parameters.AddWithValue("@MSP", SellingPTextBox1.Text);
                    cmd.Parameters.AddWithValue("@MEDT", MedExpDatePicker1.Value.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Medicine Added Successfully.");

                    Con.Close();

                    ClearFields();
                    SearchMedcomboBox1.Refresh();

                    populateSearchMedcomboBox1();
                    ShowMedicineAll();
                    MedTypecomboBox2.SelectedItem = "All";

                }
                catch (Exception Ex) 
                {
                    MessageBox.Show(Ex.Message);
                }
            }


        }

        private void MedicineStockUC_Load(object sender, EventArgs e)
        {
        }

        private void MedTypecomboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MedTypecomboBox2.SelectedItem.ToString() == "Scissor")
            {
                ShowMedicineOfType("Scissor");
            }
            else if (MedTypecomboBox2.SelectedItem.ToString() == "Delivery")
            {
                ShowMedicineOfType("Delivery");
            }
            else
            {
                ShowMedicineAll();
            }
        }

        public void ClearFields()
        {
            MedNameTextBox1.Text = "";
            MedTypecomboBox1.Text = "Type";
            MedQuantityTextBox1.Text = "";
            SellingPTextBox1.Text = "";
            BuyingPTextBox1.Text = "";
            SearchMedcomboBox1.Text = "Search Medicine";

        }

        private void MedStockDGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MedNameTextBox1.Text = MedStockDGV1.SelectedRows[0].Cells[0].Value.ToString();
            MedTypecomboBox1.Text = MedStockDGV1.SelectedRows[0].Cells[1].Value.ToString();
            MedQuantityTextBox1.Text = MedStockDGV1.SelectedRows[0].Cells[2].Value.ToString();
            BuyingPTextBox1.Text = MedStockDGV1.SelectedRows[0].Cells[3].Value.ToString();
            SellingPTextBox1.Text = MedStockDGV1.SelectedRows[0].Cells[4].Value.ToString();
            MedExpDatePicker1.Text = MedStockDGV1.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void RemoveButton1_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@System.Configuration.ConfigurationManager.ConnectionStrings["DataBaseString"].ConnectionString);

            if (MedNameTextBox1.Text == "")
            {
                MessageBox.Show("Select a Medicine to remove from Database.");
            }
            else
            {
                try
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("DELETE FROM MedicineStock_tbl where MedName = @MN", Con);
                    cmd.Parameters.AddWithValue("@MN", MedNameTextBox1.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Medicine Removed Successfully.");


                    Con.Close();

                    populateSearchMedcomboBox1();
                    ShowMedicineAll();
                    MedTypecomboBox2.SelectedItem = "All";

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void UpdateButton1_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@System.Configuration.ConfigurationManager.ConnectionStrings["DataBaseString"].ConnectionString);

            if (MedNameTextBox1.Text == "" || MedQuantityTextBox1.Text == "" || BuyingPTextBox1.Text == "" || SellingPTextBox1.Text == "")
            {
                MessageBox.Show("Select a Medicine to Update.");
            }
            else
            {
                try
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE MedicineStock_tbl SET MedType=@MT,MedQty=@MQ,MedBprice=@MBP,MedSprice=@MSP,MedExpDate=@MEDT where MedName=@MN", Con);
                    cmd.Parameters.AddWithValue("@MN", MedNameTextBox1.Text);
                    cmd.Parameters.AddWithValue("@MT", MedTypecomboBox1.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@MQ", MedQuantityTextBox1.Text);
                    cmd.Parameters.AddWithValue("@MBP", BuyingPTextBox1.Text);
                    cmd.Parameters.AddWithValue("@MSP", SellingPTextBox1.Text);
                    cmd.Parameters.AddWithValue("@MEDT", MedExpDatePicker1.Value.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Medicine Updated Successfully.");

                    Con.Close();

                    ShowMedicineAll();
                    MedTypecomboBox2.SelectedItem = "All";

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }


        private void SearchMedcomboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string MedicineName = SearchMedcomboBox1.SelectedValue.ToString();
            ShowMedicineOfName(MedicineName);
        }

        private void SearchMedcomboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && SearchMedcomboBox1.SelectedItem != null)
            {
                SearchMedcomboBox1_SelectionChangeCommitted(sender, e);
            }
        }
    }
}
