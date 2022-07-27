using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyStoreSystem
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
            Homebtn1.Select();
            this.Load += new System.EventHandler(this.Homebtn1_Click);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogOutBtn1_Click_1(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
        }

        private void Homebtn1_Click(object sender, EventArgs e)
        {
            MainUpperHeadinglabel.Text = "Home";
            homeUC1.CountMedStock();
            homeUC1.SumTotalSales();
            homeUC1.SumTotalProfit();
            homeUC1.SumTotalLoss();
            homeUC1.Show();
            medicineStockUC1.Hide();
            invoiceUC1.Hide();
            transactionUC1.Hide();
            importSheetsUC1.Hide();
        }

        private void MedicineStockBtn1_Click(object sender, EventArgs e)
        {
            MainUpperHeadinglabel.Text = "Medicine Stock";
            medicineStockUC1.populateSearchMedcomboBox1();
            medicineStockUC1.ShowMedicineAll();
            medicineStockUC1.Show();
            homeUC1.Hide();
            invoiceUC1.Hide();
            transactionUC1.Hide();
            importSheetsUC1.Hide();
        }

        private void InvoiceBtn1_Click(object sender, EventArgs e)
        {

            MainUpperHeadinglabel.Text = "Invoice";

            invoiceUC1.populateSearchMedcomboBox2();
            // invoiceUC1.fetchQty();
            invoiceUC1.Show();
            homeUC1.Hide();
            medicineStockUC1.Hide();
            transactionUC1.Hide();
            importSheetsUC1.Hide();
        }

        private void TransactionBtn1_Click(object sender, EventArgs e)
        {
            MainUpperHeadinglabel.Text = "Transaction";

            transactionUC1.ShowTransactionAll();
            transactionUC1.Show();
            homeUC1.Hide();
            medicineStockUC1.Hide();
            invoiceUC1.Hide();
            importSheetsUC1.Hide();
        }

        private void ExportSheetBtn1_Click(object sender, EventArgs e)
        {
            MainUpperHeadinglabel.Text = "Import Excel";
            importSheetsUC1.Show();
            homeUC1.Hide();
            medicineStockUC1.Hide();
            invoiceUC1.Hide();
            transactionUC1.Hide();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
        }


    }
}
