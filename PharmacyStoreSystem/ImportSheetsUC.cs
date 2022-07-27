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
using System.IO;
using ExcelDataReader;

namespace PharmacyStoreSystem
{
    public partial class ImportSheetsUC : UserControl
    {
        public ImportSheetsUC()
        {
            InitializeComponent();
        }

        DataTableCollection tablecollection;

        private void BrowseBtn1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fldl = new OpenFileDialog();
            fldl.Title = "Select File";
            fldl.FileName = FileNameTextBox1.Text;
            fldl.Filter = "Excel Sheet (*.xls)|*.xls|Excel Sheet(*.xlsx)|*.xlsx|All Files(*.*)|*.*";
            fldl.FilterIndex = 1;
            fldl.RestoreDirectory = true;

            if (fldl.ShowDialog() == DialogResult.OK)
            {
                FileNameTextBox1.Text = fldl.FileName;

                using (var stream = File.Open(fldl.FileName, FileMode.Open, FileAccess.Read))
                {
                    using (var excelreader = ExcelDataReader.ExcelReaderFactory.CreateReader(stream))
                    {
                        DataSet result = excelreader.AsDataSet(new ExcelDataReader.ExcelDataSetConfiguration()
                        {
                            ConfigureDataTable = (_) => new ExcelDataReader.ExcelDataTableConfiguration()
                            { UseHeaderRow = true }
                        });
                        tablecollection = result.Tables;
                        SelectSheetcomboBox1.Items.Clear();
                        foreach (DataTable table in tablecollection)
                        {
                            SelectSheetcomboBox1.Items.Add(table.TableName);
                        }
                    }
                }
            }   
        }

        private void SelectSheetcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tablecollection[SelectSheetcomboBox1.SelectedItem.ToString()];
            SheetexDGV1.DataSource = dt;
        }

        private void AddBtn3_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@System.Configuration.ConfigurationManager.ConnectionStrings["DataBaseString"].ConnectionString);

            try
            {
                Con.Open();

                for (int i = 0; i < SheetexDGV1.Rows.Count-1; i++)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO MedicineStock_tbl(MedName,MedType,MedQty,MedBprice,MedSprice,MedExpDate) VALUES(@MN,@MT,@MQ,@MBP,@MSP,@MEDT)", Con);
                    cmd.Parameters.AddWithValue("@MN", SheetexDGV1.Rows[i].Cells[0].Value);
                    cmd.Parameters.AddWithValue("@MT", SheetexDGV1.Rows[i].Cells[1].Value);
                    cmd.Parameters.AddWithValue("@MQ", SheetexDGV1.Rows[i].Cells[2].Value);
                    cmd.Parameters.AddWithValue("@MBP", SheetexDGV1.Rows[i].Cells[3].Value);
                    cmd.Parameters.AddWithValue("@MSP", SheetexDGV1.Rows[i].Cells[4].Value);
                    cmd.Parameters.AddWithValue("@MEDT", SheetexDGV1.Rows[i].Cells[5].Value);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Added Medicine stock Successfully.");
                Con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }



}
