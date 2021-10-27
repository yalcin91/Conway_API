using ExcelDataReader;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Z.Dapper.Plus;

namespace win_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTableCollection tableCollection;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[comboBox1.SelectedItem.ToString()];
            dataGridView1.DataSource = dt;
            if(dt != null)
            {
                List<ProductenClas> productenClass = new List<ProductenClas>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ProductenClas productenClas = new ProductenClas();
                    productenClas.Id = dt.Rows[i]["Id"].ToString();
                    productenClas.Naam = dt.Rows[i]["Naam"].ToString();
                    productenClas.Fabrikant = dt.Rows[i]["Fabrikant"].ToString();
                    productenClas.Hoogte = dt.Rows[i]["Hoogte"].ToString();
                    productenClas.Breedte = dt.Rows[i]["Breedte"].ToString();
                    productenClas.Diepte = dt.Rows[i]["Diepte"].ToString();
                    productenClas.Inhoud = dt.Rows[i]["Inhoud"].ToString();
                    productenClas.Eancode = dt.Rows[i]["EAN"].ToString();
                    productenClas.Prijs = dt.Rows[i]["Prijs"].ToString();
                    productenClass.Add(productenClas);
                }
                dataGridView1.DataSource = productenClass;
            }
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollection = result.Tables;
                            comboBox1.Items.Clear();
                            foreach (DataTable table in tableCollection)
                            {
                                comboBox1.Items.Add(table.TableName);
                            }
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_ConwayDataSet2.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter1.Fill(this.db_ConwayDataSet2.Products);
            // TODO: This line of code loads data into the 'db_ConwayDataSet.PMI_Cigarettes' table. You can move, or remove it, as needed.
            this.pMI_CigarettesTableAdapter.Fill(this.db_ConwayDataSet.PMI_Cigarettes);
            // TODO: This line of code loads data into the 'db_ConwayDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.db_ConwayDataSet.Products);

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=LAPTOP-DI4L7OAA\\SQLEXPRESS;Initial Catalog=db_Conway;Integrated Security=True";
                DapperPlusManager.Entity<ProductenClas>().Table("Products");
                List<ProductenClas> productenClas = dataGridView1.DataSource as List<ProductenClas>;
                if (productenClas != null)
                {
                    using (IDbConnection db = new SqlConnection(connectionString))
                    {
                        db.BulkInsert(productenClas);
                    }
                }
                MessageBox.Show("Finish !!!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
