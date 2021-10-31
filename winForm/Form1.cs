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

namespace winForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTableCollection tableCollection;
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_ConwayDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.db_ConwayDataSet.Products);

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[comboBox1.SelectedItem.ToString()];
            //dataGridView1.DataSource = dt;
            if (dt != null)
            {
                List<Product> lijsten = new List<Product>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Product lijst = new Product();
                    lijst.Id = dt.Rows[i]["Id"].ToString();
                    lijst.Naam = dt.Rows[i]["Naam"].ToString();
                    lijst.Activatie = dt.Rows[i]["Activatie"].ToString();
                    lijst.Fabrikant = dt.Rows[i]["Fabrikant"].ToString();
                    lijst.Hoogte = dt.Rows[i]["Hoogte"].ToString();
                    lijst.Breedte = dt.Rows[i]["Breedte"].ToString();
                    lijst.Diepte = dt.Rows[i]["Diepte"].ToString();
                    lijst.Inhoud = dt.Rows[i]["Inhoud"].ToString();
                    lijst.Eancode = dt.Rows[i]["Eancode"].ToString();
                    lijst.Prijs = dt.Rows[i]["Prijs"].ToString();
                    lijsten.Add(lijst);
                }
                productsBindingSource2.DataSource = lijsten;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string connectie = "Data Source=LAPTOP-DI4L7OAA\\SQLEXPRESS;Initial Catalog=db_Conway;Integrated Security=True";
                DapperPlusManager.Entity<Product>().Table("Producten");
                List<Product> lijstVoorData = productsBindingSource2.DataSource as List<Product>;
                if (lijstVoorData != null)
                {
                    using (IDbConnection db = new SqlConnection(connectie))
                    {
                        db.BulkInsert(lijstVoorData);
                    }
                }
                MessageBox.Show("Finish !!!!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
