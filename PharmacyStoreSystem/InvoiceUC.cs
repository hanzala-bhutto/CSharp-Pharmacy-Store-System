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


    public partial class InvoiceUC : UserControl
    {

        public InvoiceUC()
        {
            InitializeComponent();
//            populateSearchMedcomboBox2();
//            fetchQty();

        }

        int availablestock;
        int sellprice;
        int buyprice;

        public void fetchQty()
        {

            SqlConnection Con = new SqlConnection(@System.Configuration.ConfigurationManager.ConnectionStrings["DataBaseString"].ConnectionString);

            try
            {

                Con.Open();

                string Myquery = "SELECT * FROM  MedicineStock_tbl WHERE MedName = @MN";
                SqlCommand cmd = new SqlCommand(Myquery, Con);
                cmd.Parameters.AddWithValue("@MN", SearchMedcomboBox2.SelectedValue.ToString());
                DataTable dt = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dt);


                foreach (DataRow dataRow in dt.Rows)
                {
                    availablestock = Convert.ToInt32(dataRow["MedQty"].ToString());
                    buyprice = Convert.ToInt32(dataRow["MedBprice"].ToString());
                    sellprice = Convert.ToInt32(dataRow["MedSprice"].ToString());

                    MedStocklabel1.Text = "Stock Available = " + dataRow["MedQty"].ToString();
                    MedStocklabel1.Visible = true;
                    BPriceTextBox2.Text = dataRow["MedBPrice"].ToString();
                    SPriceTextBox2.Text = dataRow["MedSPrice"].ToString();

                }
                Con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        public void resetText() 
        {
            SearchMedcomboBox2.Text = "Select Medicine";
            MedStocklabel1.Text = "Stock Available";
            BPriceTextBox2.Text = "";
            SPriceTextBox2.Text = "";
            MedQtyTextBox2.Text = "";
        }

        public void populateSearchMedcomboBox2()
        {

            SqlConnection Con = new SqlConnection(@System.Configuration.ConfigurationManager.ConnectionStrings["DataBaseString"].ConnectionString);
            
            Con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM MedicineStock_tbl", Con);
            SqlDataReader reader;
            DataTable dt = new DataTable();
            dt.Columns.Add("MedName", typeof(string));
            reader = cmd.ExecuteReader();
            dt.Load(reader);

            SearchMedcomboBox2.ValueMember = "MedName";
            SearchMedcomboBox2.DataSource = dt;

            Con.Close();

            resetText();
        }


        /*
               private void SearchMedcomboBox2_SelectionChangeCommitted(object sender, EventArgs e)
               {
                   fetchQty();
               }

               private void MedcomboBox_KeyDown(object sender, KeyEventArgs e)
               {
                   if (e.KeyCode == Keys.Enter && SearchMedcomboBox2.SelectedItem != null) 
                   {
                       SearchMedcomboBox2_SelectionChangeCommitted(sender, e);
                   }
               }
        */

 
        private void SearchMedcomboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            fetchQty();
        }

        public void updateMedicineStock()
        {
            SqlConnection Con = new SqlConnection(@System.Configuration.ConfigurationManager.ConnectionStrings["DataBaseString"].ConnectionString);

            Con.Open();

            int newMedQty = availablestock - Convert.ToInt32(MedQtyTextBox2.Text);

            string Myquery = "UPDATE MedicineStock_tbl SET MedQty = @MQ WHERE MedName = @MN";
            SqlCommand cmd = new SqlCommand(Myquery, Con);
            cmd.Parameters.AddWithValue("@MN", SearchMedcomboBox2.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@MQ", newMedQty.ToString());
            cmd.ExecuteNonQuery();

            Con.Close();
        }

        private void BillDGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        float GrandBuyingP = 0;
        float GrandSellingP = 0;
        float GrandTotal = 0;

        private void AddBtn2_Click(object sender, EventArgs e)
        {
            if (MedQtyTextBox2.Text == "")
            {
                MessageBox.Show("Medicine Quantity is not selected !");
            }
            else if (SearchMedcomboBox2.SelectedValue == null) 
            {
                MessageBox.Show("No such medicine exists in Medicine Stock.");
            }
            else if (SearchMedcomboBox2.Text == "")
            {
                MessageBox.Show("Medicine is not selected !");
            }
            else if (Convert.ToInt32(MedQtyTextBox2.Text) > availablestock)
            {
                MessageBox.Show("Medicine Stock is insufficient for selected quantity !");
            }
            else if (Convert.ToInt32(MedQtyTextBox2.Text) <= 0)
            {
                MessageBox.Show("Medicine Quantity cannot be negative or zero !");
            }
            else
            {
                float totalBuyP = buyprice * Convert.ToInt32(MedQtyTextBox2.Text);
                float totalSellP = sellprice * Convert.ToInt32(MedQtyTextBox2.Text);
                DataGridViewRow gridRow = new DataGridViewRow();
                gridRow.CreateCells(BillDGV1);

                gridRow.Cells[0].Value = SearchMedcomboBox2.SelectedValue.ToString();
                gridRow.Cells[1].Value = MedQtyTextBox2.Text;
                gridRow.Cells[2].Value = sellprice;
                gridRow.Cells[3].Value = totalBuyP;
                gridRow.Cells[4].Value = totalSellP;

                BillDGV1.Rows.Add(gridRow);

                GrandBuyingP += totalBuyP;
                GrandSellingP += totalSellP;

                // TotalBilllabel1.Text = "Total Amount = " + GrandTotal + " pkr";
                TotalBpTextBox1.Text = GrandBuyingP.ToString();
                TotalSpTextBox1.Text = GrandSellingP.ToString();
                DiscountTextBox1_TextChanged(sender, e);

                updateMedicineStock();
                fetchQty();

            }


        }

        private void RemoveBtn2_Click(object sender, EventArgs e)
        {

            SqlConnection Con = new SqlConnection(@System.Configuration.ConfigurationManager.ConnectionStrings["DataBaseString"].ConnectionString);


            if (BillDGV1.SelectedRows.Count <= 0) 
            {
                MessageBox.Show("No row is selected to remove.");
            }
            else if (BillDGV1.SelectedRows[0].Cells[0].Value == null)
            {
                MessageBox.Show("User has selected an Empty Row.");
            }
            else 
            {

                Con.Open();

                string Medicinename = BillDGV1.SelectedRows[0].Cells[0].Value.ToString();
                int addQuantity = Convert.ToInt32(BillDGV1.SelectedRows[0].Cells[1].Value.ToString());
                int removedBprice = Convert.ToInt32(BillDGV1.SelectedRows[0].Cells[3].Value);
                int removedSprice = Convert.ToInt32(BillDGV1.SelectedRows[0].Cells[4].Value);

                GrandBuyingP -= removedBprice;
                GrandSellingP -= removedSprice;
                TotalSpTextBox1.Text = GrandSellingP.ToString();
                TotalBpTextBox1.Text = GrandBuyingP.ToString();

                DiscountTextBox1_TextChanged(sender,e);

                // TotalBilllabel1.Text = "Total Amount = " + GrandTotal + " pkr";

                string Myquery1 = "SELECT MedQty FROM  MedicineStock_tbl WHERE MedName = @MN";
                SqlCommand cmd1 = new SqlCommand(Myquery1, Con);
                cmd1.Parameters.AddWithValue("@MN", Medicinename);
                int actualQuantity = Convert.ToInt32(cmd1.ExecuteScalar());

                int newQty = addQuantity + actualQuantity;

                BillDGV1.Rows.RemoveAt(BillDGV1.SelectedRows[0].Index);

                string Myquery = "UPDATE MedicineStock_tbl SET MedQty = @MQ WHERE MedName = @MN";
                SqlCommand cmd2 = new SqlCommand(Myquery, Con);
                cmd2.Parameters.AddWithValue("@MN", Medicinename);
                cmd2.Parameters.AddWithValue("@MQ", newQty);
                cmd2.ExecuteNonQuery();

                Con.Close();

                fetchQty();
            }

        }

        private void RemoveAllBtn_Click(object sender, EventArgs e)
        {

            if (BillDGV1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("No row is selected to remove.");
            }
            
            else if (BillDGV1.SelectedRows[0].Cells[0].Value == null && BillDGV1.Rows.Count <= 1)
            {
                MessageBox.Show("There are no more medicines to remove.");
            }
            else if (BillDGV1.SelectedRows[0].Cells[0].Value == null || BillDGV1.Rows.Count > 1)
            {
                BillDGV1.CurrentCell = BillDGV1.Rows[0].Cells[0];

                while (BillDGV1.SelectedRows[0].Cells[0].Value != null)
                {
                    RemoveBtn2_Click(sender, e);
                }
            }

        }

        private void GenerateReport()
        {
            MedBillReports1.Clear();

            MedBillReports1.AddString("<h1><b><center>PHARMACY STORE</center></b></h1>");
            MedBillReports1.AddLineBreak();
            MedBillReports1.AddString("<h2><b>INVOICE</b></h2>");
            MedBillReports1.AddHorizontalRule();
            MedBillReports1.AddLineBreak();
            MedBillReports1.AddLineBreak();

            MedBillReports1.AddDatagridView(BillDGV1);
            MedBillReports1.AddLineBreak();
            MedBillReports1.AddString("<h3 style = 'float : right'>  " + TotalAmntTextBox1.Text+ " pkr" + "</h3>");
        }

        private void PrintBtn1_Click(object sender, EventArgs e)
        {
            GenerateReport();
            MedBillReports1.ShowPrintPreviewDialog();
        }

        private void AddTransaction()
        {

            SqlConnection Con = new SqlConnection(@System.Configuration.ConfigurationManager.ConnectionStrings["DataBaseString"].ConnectionString);


            try
            {


                float revenue = GrandTotal - GrandBuyingP;

                if(revenue > 0)
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO Transaction_tbl(TotAmntBP,TotAmntSP,TotAmnt,Profit,Loss,TransacDate) VALUES(@BP,@SP,@TA,@PT,@LS,@TD)", Con);
                    cmd.Parameters.AddWithValue("@BP", GrandBuyingP);
                    cmd.Parameters.AddWithValue("@SP", GrandSellingP);
                    cmd.Parameters.AddWithValue("@TA", TotalAmntTextBox1.Text);
                    cmd.Parameters.AddWithValue("@PT", revenue.ToString());
                    cmd.Parameters.AddWithValue("@LS", "0");
                    cmd.Parameters.AddWithValue("@TD", DateTime.Now.ToString("dddd, dd MMMM, yyyy HH:mm:ss tt"));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Transaction Added Successfully.");

                    Con.Close();
                }
                else if (revenue == 0)
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO Transaction_tbl(TotAmntBP,TotAmntSP,TotAmnt,TransacDate) VALUES(@BP,@SP,@TA,@TD)", Con);
                    cmd.Parameters.AddWithValue("@BP", GrandBuyingP);
                    cmd.Parameters.AddWithValue("@SP", GrandSellingP);
                    cmd.Parameters.AddWithValue("@TA", TotalAmntTextBox1.Text);
                    cmd.Parameters.AddWithValue("@TD", DateTime.Now.ToString("dddd, dd MMMM, yyyy HH:mm:ss"));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Transaction Added Successfully.");

                    Con.Close();
                }
                else
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO Transaction_tbl(TotAmntBP,TotAmntSP,TotAmnt,Profit,Loss,TransacDate) VALUES(@BP,@SP,@TA,@PT,@LS,@TD)", Con);
                    cmd.Parameters.AddWithValue("@BP", GrandBuyingP);
                    cmd.Parameters.AddWithValue("@SP", GrandSellingP);
                    cmd.Parameters.AddWithValue("@TA", TotalAmntTextBox1.Text);
                    cmd.Parameters.AddWithValue("@PT", "0");
                    cmd.Parameters.AddWithValue("@LS", revenue.ToString());
                    cmd.Parameters.AddWithValue("@TD", DateTime.Now.ToString("dddd, dd MMMM, yyyy HH:mm:ss"));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Transaction Added Successfully.");

                    Con.Close();
                }


            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ClearAllBtn_Click(object sender, EventArgs e)
        {
            BillDGV1.Rows.Clear();
            GrandTotal = 0;
            GrandBuyingP = 0;
            GrandSellingP = 0;
            DiscountTextBox1.Text = "0";
            TotalBpTextBox1.Text = "";
            TotalSpTextBox1.Text = "";
            TotalAmntTextBox1.Text = "";
        }

        private void SaveToFileBtn1_Click(object sender, EventArgs e)
        {
            SaveToFileReceipt.ShowDialog();

        }

        private void SaveToFileReceipt_FileOk(object sender, CancelEventArgs e)
        {
            GenerateReport();
            MedBillReports1.SavePDF(SaveToFileReceipt.FileName);
            MessageBox.Show("PDF successfully generated.");
            AddTransaction();
            
        }

        private void InvoiceUC_Load(object sender, EventArgs e)
        {

        }

        private void DiscountTextBox1_TextChanged(object sender, EventArgs e)
        {

            try
            {
                string discount;
                if (DiscountTextBox1.Text == "")
                {
                    discount = "0";
                }
                else
                {
                    discount = DiscountTextBox1.Text;
                }
                GrandTotal = GrandSellingP - Convert.ToInt32(discount);
                TotalAmntTextBox1.Text = GrandTotal.ToString();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
