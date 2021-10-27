
namespace win_form
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoogteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breedteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diepteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inhoudDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eancodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prijsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.db_ConwayDataSet2 = new win_form.db_ConwayDataSet2();
            this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbConwayDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_ConwayDataSet = new win_form.db_ConwayDataSet();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblSheet = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnopen = new System.Windows.Forms.Button();
            this.dbConwayDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new win_form.db_ConwayDataSetTableAdapters.ProductsTableAdapter();
            this.productsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pMICigarettesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pMI_CigarettesTableAdapter = new win_form.db_ConwayDataSetTableAdapters.PMI_CigarettesTableAdapter();
            this.productsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.productsBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter1 = new win_form.db_ConwayDataSet2TableAdapters.ProductsTableAdapter();
            this.btnImport = new System.Windows.Forms.Button();
            this.productsBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.productsBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.productsBindingSource8 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_ConwayDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConwayDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_ConwayDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConwayDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMICigarettesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource8)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.naamDataGridViewTextBoxColumn,
            this.hoogteDataGridViewTextBoxColumn,
            this.breedteDataGridViewTextBoxColumn,
            this.diepteDataGridViewTextBoxColumn,
            this.inhoudDataGridViewTextBoxColumn,
            this.eancodeDataGridViewTextBoxColumn,
            this.prijsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productsBindingSource8;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1524, 623);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // naamDataGridViewTextBoxColumn
            // 
            this.naamDataGridViewTextBoxColumn.DataPropertyName = "Naam";
            this.naamDataGridViewTextBoxColumn.HeaderText = "Naam";
            this.naamDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.naamDataGridViewTextBoxColumn.Name = "naamDataGridViewTextBoxColumn";
            this.naamDataGridViewTextBoxColumn.Width = 125;
            // 
            // hoogteDataGridViewTextBoxColumn
            // 
            this.hoogteDataGridViewTextBoxColumn.DataPropertyName = "Hoogte";
            this.hoogteDataGridViewTextBoxColumn.HeaderText = "Hoogte";
            this.hoogteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hoogteDataGridViewTextBoxColumn.Name = "hoogteDataGridViewTextBoxColumn";
            this.hoogteDataGridViewTextBoxColumn.Width = 125;
            // 
            // breedteDataGridViewTextBoxColumn
            // 
            this.breedteDataGridViewTextBoxColumn.DataPropertyName = "Breedte";
            this.breedteDataGridViewTextBoxColumn.HeaderText = "Breedte";
            this.breedteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.breedteDataGridViewTextBoxColumn.Name = "breedteDataGridViewTextBoxColumn";
            this.breedteDataGridViewTextBoxColumn.Width = 125;
            // 
            // diepteDataGridViewTextBoxColumn
            // 
            this.diepteDataGridViewTextBoxColumn.DataPropertyName = "Diepte";
            this.diepteDataGridViewTextBoxColumn.HeaderText = "Diepte";
            this.diepteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diepteDataGridViewTextBoxColumn.Name = "diepteDataGridViewTextBoxColumn";
            this.diepteDataGridViewTextBoxColumn.Width = 125;
            // 
            // inhoudDataGridViewTextBoxColumn
            // 
            this.inhoudDataGridViewTextBoxColumn.DataPropertyName = "Inhoud";
            this.inhoudDataGridViewTextBoxColumn.HeaderText = "Inhoud";
            this.inhoudDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.inhoudDataGridViewTextBoxColumn.Name = "inhoudDataGridViewTextBoxColumn";
            this.inhoudDataGridViewTextBoxColumn.Width = 125;
            // 
            // eancodeDataGridViewTextBoxColumn
            // 
            this.eancodeDataGridViewTextBoxColumn.DataPropertyName = "Eancode";
            this.eancodeDataGridViewTextBoxColumn.HeaderText = "Eancode";
            this.eancodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eancodeDataGridViewTextBoxColumn.Name = "eancodeDataGridViewTextBoxColumn";
            this.eancodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // prijsDataGridViewTextBoxColumn
            // 
            this.prijsDataGridViewTextBoxColumn.DataPropertyName = "Prijs";
            this.prijsDataGridViewTextBoxColumn.HeaderText = "Prijs";
            this.prijsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prijsDataGridViewTextBoxColumn.Name = "prijsDataGridViewTextBoxColumn";
            this.prijsDataGridViewTextBoxColumn.Width = 125;
            // 
            // productsBindingSource5
            // 
            this.productsBindingSource5.DataMember = "Products";
            this.productsBindingSource5.DataSource = this.db_ConwayDataSet2;
            // 
            // db_ConwayDataSet2
            // 
            this.db_ConwayDataSet2.DataSetName = "db_ConwayDataSet2";
            this.db_ConwayDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource1
            // 
            this.productsBindingSource1.DataMember = "Products";
            this.productsBindingSource1.DataSource = this.dbConwayDataSetBindingSource;
            // 
            // dbConwayDataSetBindingSource
            // 
            this.dbConwayDataSetBindingSource.DataSource = this.db_ConwayDataSet;
            this.dbConwayDataSetBindingSource.Position = 0;
            // 
            // db_ConwayDataSet
            // 
            this.db_ConwayDataSet.DataSetName = "db_ConwayDataSet";
            this.db_ConwayDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(21, 664);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(71, 17);
            this.lblFileName.TabIndex = 1;
            this.lblFileName.Text = "File Name";
            // 
            // lblSheet
            // 
            this.lblSheet.AutoSize = true;
            this.lblSheet.Location = new System.Drawing.Point(21, 707);
            this.lblSheet.Name = "lblSheet";
            this.lblSheet.Size = new System.Drawing.Size(45, 17);
            this.lblSheet.TabIndex = 2;
            this.lblSheet.Text = "Sheet";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(176, 707);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(176, 664);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(486, 22);
            this.textBox1.TabIndex = 4;
            // 
            // btnopen
            // 
            this.btnopen.Location = new System.Drawing.Point(698, 664);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(68, 28);
            this.btnopen.TabIndex = 5;
            this.btnopen.Text = "...";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // dbConwayDataSetBindingSource1
            // 
            this.dbConwayDataSetBindingSource1.DataSource = this.db_ConwayDataSet;
            this.dbConwayDataSetBindingSource1.Position = 0;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.dbConwayDataSetBindingSource1;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // productsBindingSource2
            // 
            this.productsBindingSource2.DataMember = "Products";
            this.productsBindingSource2.DataSource = this.dbConwayDataSetBindingSource;
            // 
            // pMICigarettesBindingSource
            // 
            this.pMICigarettesBindingSource.DataMember = "PMI_Cigarettes";
            this.pMICigarettesBindingSource.DataSource = this.dbConwayDataSetBindingSource1;
            // 
            // pMI_CigarettesTableAdapter
            // 
            this.pMI_CigarettesTableAdapter.ClearBeforeFill = true;
            // 
            // productsBindingSource3
            // 
            this.productsBindingSource3.DataMember = "Products";
            this.productsBindingSource3.DataSource = this.dbConwayDataSetBindingSource;
            // 
            // productsBindingSource4
            // 
            this.productsBindingSource4.DataMember = "Products";
            this.productsBindingSource4.DataSource = this.db_ConwayDataSet;
            // 
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(335, 707);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(65, 24);
            this.btnImport.TabIndex = 6;
            this.btnImport.Text = "import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // productsBindingSource6
            // 
            this.productsBindingSource6.DataMember = "Products";
            this.productsBindingSource6.DataSource = this.dbConwayDataSetBindingSource;
            // 
            // productsBindingSource7
            // 
            this.productsBindingSource7.DataMember = "Products";
            this.productsBindingSource7.DataSource = this.dbConwayDataSetBindingSource1;
            // 
            // productsBindingSource8
            // 
            this.productsBindingSource8.DataMember = "Products";
            this.productsBindingSource8.DataSource = this.dbConwayDataSetBindingSource;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1643, 868);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblSheet);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_ConwayDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConwayDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_ConwayDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConwayDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMICigarettesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblSheet;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.BindingSource dbConwayDataSetBindingSource1;
        private db_ConwayDataSet db_ConwayDataSet;
        private System.Windows.Forms.BindingSource dbConwayDataSetBindingSource;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private db_ConwayDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.BindingSource productsBindingSource1;
        private System.Windows.Forms.BindingSource productsBindingSource2;
        private System.Windows.Forms.BindingSource pMICigarettesBindingSource;
        private db_ConwayDataSetTableAdapters.PMI_CigarettesTableAdapter pMI_CigarettesTableAdapter;
        private System.Windows.Forms.BindingSource productsBindingSource4;
        private System.Windows.Forms.BindingSource productsBindingSource3;
        private db_ConwayDataSet2 db_ConwayDataSet2;
        private System.Windows.Forms.BindingSource productsBindingSource5;
        private db_ConwayDataSet2TableAdapters.ProductsTableAdapter productsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoogteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn breedteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diepteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inhoudDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eancodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prijsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.BindingSource productsBindingSource8;
        private System.Windows.Forms.BindingSource productsBindingSource6;
        private System.Windows.Forms.BindingSource productsBindingSource7;
    }
}

