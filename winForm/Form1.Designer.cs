
namespace winForm
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
            this.db_ConwayDataSet = new winForm.db_ConwayDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new winForm.db_ConwayDataSetTableAdapters.ProductsTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activatieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabrikantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoogteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breedteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diepteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inhoudDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eancodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prijsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_ConwayDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.naamDataGridViewTextBoxColumn,
            this.activatieDataGridViewTextBoxColumn,
            this.fabrikantDataGridViewTextBoxColumn,
            this.hoogteDataGridViewTextBoxColumn,
            this.breedteDataGridViewTextBoxColumn,
            this.diepteDataGridViewTextBoxColumn,
            this.inhoudDataGridViewTextBoxColumn,
            this.eancodeDataGridViewTextBoxColumn,
            this.prijsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productsBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(362, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(848, 349);
            this.dataGridView1.TabIndex = 0;
            // 
            // db_ConwayDataSet
            // 
            this.db_ConwayDataSet.DataSetName = "db_ConwayDataSet";
            this.db_ConwayDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.db_ConwayDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(489, 609);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(402, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1105, 523);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(638, 524);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(392, 22);
            this.textBox1.TabIndex = 3;
            // 
            // productsBindingSource1
            // 
            this.productsBindingSource1.DataMember = "Products";
            this.productsBindingSource1.DataSource = this.db_ConwayDataSet;
            // 
            // productsBindingSource2
            // 
            this.productsBindingSource2.DataMember = "Products";
            this.productsBindingSource2.DataSource = this.db_ConwayDataSet;
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
            // activatieDataGridViewTextBoxColumn
            // 
            this.activatieDataGridViewTextBoxColumn.DataPropertyName = "Activatie";
            this.activatieDataGridViewTextBoxColumn.HeaderText = "Activatie";
            this.activatieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.activatieDataGridViewTextBoxColumn.Name = "activatieDataGridViewTextBoxColumn";
            this.activatieDataGridViewTextBoxColumn.Width = 125;
            // 
            // fabrikantDataGridViewTextBoxColumn
            // 
            this.fabrikantDataGridViewTextBoxColumn.DataPropertyName = "Fabrikant";
            this.fabrikantDataGridViewTextBoxColumn.HeaderText = "Fabrikant";
            this.fabrikantDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fabrikantDataGridViewTextBoxColumn.Name = "fabrikantDataGridViewTextBoxColumn";
            this.fabrikantDataGridViewTextBoxColumn.Width = 125;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(923, 621);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1651, 812);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_ConwayDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private db_ConwayDataSet db_ConwayDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private db_ConwayDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource productsBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activatieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabrikantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoogteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn breedteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diepteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inhoudDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eancodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prijsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productsBindingSource2;
        private System.Windows.Forms.Button button2;
    }
}

