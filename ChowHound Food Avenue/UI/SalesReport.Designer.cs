namespace Chowhound_Food_Avenue.UI
{
    partial class SalesReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesReport));
            this.chowhoundDbDataSet = new Chowhound_Food_Avenue.ChowhoundDbDataSet();
            this.chowhoundTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chowhound_TableTableAdapter = new Chowhound_Food_Avenue.ChowhoundDbDataSetTableAdapters.Chowhound_TableTableAdapter();
            this.table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_1TableAdapter = new Chowhound_Food_Avenue.ChowhoundDbDataSetTableAdapters.Table_1TableAdapter();
            this.table1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buffetMealDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plateOfTheDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sisigDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dynamiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buffaloWingsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lechonKawaliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.potatoFriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.potatoWedgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crispyPataWholeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crispyPataHalfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.samyupsalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanMigLightsBucketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanMigLightsPerBottleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMBPalePilsenBucketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMBPalePilsenPerBottleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMealOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDrinksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grandTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.chowhoundDbDataSet1 = new Chowhound_Food_Avenue.ChowhoundDbDataSet();
            this.Home = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chowhoundDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chowhoundTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chowhoundDbDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // chowhoundDbDataSet
            // 
            this.chowhoundDbDataSet.DataSetName = "ChowhoundDbDataSet";
            this.chowhoundDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chowhoundTableBindingSource
            // 
            this.chowhoundTableBindingSource.DataMember = "Chowhound_Table";
            this.chowhoundTableBindingSource.DataSource = this.chowhoundDbDataSet;
            // 
            // chowhound_TableTableAdapter
            // 
            this.chowhound_TableTableAdapter.ClearBeforeFill = true;
            // 
            // table1BindingSource
            // 
            this.table1BindingSource.DataMember = "Table_1";
            this.table1BindingSource.DataSource = this.chowhoundDbDataSet;
            // 
            // table_1TableAdapter
            // 
            this.table_1TableAdapter.ClearBeforeFill = true;
            // 
            // table1BindingSource1
            // 
            this.table1BindingSource1.DataMember = "Table_1";
            this.table1BindingSource1.DataSource = this.chowhoundDbDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNoDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.buffetMealDataGridViewTextBoxColumn,
            this.plateOfTheDayDataGridViewTextBoxColumn,
            this.sisigDataGridViewTextBoxColumn,
            this.dynamiteDataGridViewTextBoxColumn,
            this.buffaloWingsDataGridViewTextBoxColumn,
            this.lechonKawaliDataGridViewTextBoxColumn,
            this.potatoFriesDataGridViewTextBoxColumn,
            this.potatoWedgeDataGridViewTextBoxColumn,
            this.crispyPataWholeDataGridViewTextBoxColumn,
            this.crispyPataHalfDataGridViewTextBoxColumn,
            this.samyupsalDataGridViewTextBoxColumn,
            this.sanMigLightsBucketDataGridViewTextBoxColumn,
            this.sanMigLightsPerBottleDataGridViewTextBoxColumn,
            this.sMBPalePilsenBucketDataGridViewTextBoxColumn,
            this.sMBPalePilsenPerBottleDataGridViewTextBoxColumn,
            this.totalMealOrderDataGridViewTextBoxColumn,
            this.totalDrinksDataGridViewTextBoxColumn,
            this.grandTotalDataGridViewTextBoxColumn,
            this.cashDataGridViewTextBoxColumn,
            this.changeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.table1BindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1098, 640);
            this.dataGridView1.TabIndex = 0;
            // 
            // orderNoDataGridViewTextBoxColumn
            // 
            this.orderNoDataGridViewTextBoxColumn.DataPropertyName = "OrderNo";
            this.orderNoDataGridViewTextBoxColumn.HeaderText = "OrderNo";
            this.orderNoDataGridViewTextBoxColumn.Name = "orderNoDataGridViewTextBoxColumn";
            this.orderNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderNoDataGridViewTextBoxColumn.Width = 120;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 150;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.usernameDataGridViewTextBoxColumn.Width = 120;
            // 
            // buffetMealDataGridViewTextBoxColumn
            // 
            this.buffetMealDataGridViewTextBoxColumn.DataPropertyName = "BuffetMeal";
            this.buffetMealDataGridViewTextBoxColumn.HeaderText = "BuffetMeal";
            this.buffetMealDataGridViewTextBoxColumn.Name = "buffetMealDataGridViewTextBoxColumn";
            this.buffetMealDataGridViewTextBoxColumn.ReadOnly = true;
            this.buffetMealDataGridViewTextBoxColumn.Width = 120;
            // 
            // plateOfTheDayDataGridViewTextBoxColumn
            // 
            this.plateOfTheDayDataGridViewTextBoxColumn.DataPropertyName = "PlateOfTheDay";
            this.plateOfTheDayDataGridViewTextBoxColumn.HeaderText = "PlateOfTheDay";
            this.plateOfTheDayDataGridViewTextBoxColumn.Name = "plateOfTheDayDataGridViewTextBoxColumn";
            this.plateOfTheDayDataGridViewTextBoxColumn.ReadOnly = true;
            this.plateOfTheDayDataGridViewTextBoxColumn.Width = 120;
            // 
            // sisigDataGridViewTextBoxColumn
            // 
            this.sisigDataGridViewTextBoxColumn.DataPropertyName = "Sisig";
            this.sisigDataGridViewTextBoxColumn.HeaderText = "Sisig";
            this.sisigDataGridViewTextBoxColumn.Name = "sisigDataGridViewTextBoxColumn";
            this.sisigDataGridViewTextBoxColumn.ReadOnly = true;
            this.sisigDataGridViewTextBoxColumn.Width = 120;
            // 
            // dynamiteDataGridViewTextBoxColumn
            // 
            this.dynamiteDataGridViewTextBoxColumn.DataPropertyName = "Dynamite";
            this.dynamiteDataGridViewTextBoxColumn.HeaderText = "Dynamite";
            this.dynamiteDataGridViewTextBoxColumn.Name = "dynamiteDataGridViewTextBoxColumn";
            this.dynamiteDataGridViewTextBoxColumn.ReadOnly = true;
            this.dynamiteDataGridViewTextBoxColumn.Width = 120;
            // 
            // buffaloWingsDataGridViewTextBoxColumn
            // 
            this.buffaloWingsDataGridViewTextBoxColumn.DataPropertyName = "BuffaloWings";
            this.buffaloWingsDataGridViewTextBoxColumn.HeaderText = "BuffaloWings";
            this.buffaloWingsDataGridViewTextBoxColumn.Name = "buffaloWingsDataGridViewTextBoxColumn";
            this.buffaloWingsDataGridViewTextBoxColumn.ReadOnly = true;
            this.buffaloWingsDataGridViewTextBoxColumn.Width = 120;
            // 
            // lechonKawaliDataGridViewTextBoxColumn
            // 
            this.lechonKawaliDataGridViewTextBoxColumn.DataPropertyName = "LechonKawali";
            this.lechonKawaliDataGridViewTextBoxColumn.HeaderText = "LechonKawali";
            this.lechonKawaliDataGridViewTextBoxColumn.Name = "lechonKawaliDataGridViewTextBoxColumn";
            this.lechonKawaliDataGridViewTextBoxColumn.ReadOnly = true;
            this.lechonKawaliDataGridViewTextBoxColumn.Width = 120;
            // 
            // potatoFriesDataGridViewTextBoxColumn
            // 
            this.potatoFriesDataGridViewTextBoxColumn.DataPropertyName = "PotatoFries";
            this.potatoFriesDataGridViewTextBoxColumn.HeaderText = "PotatoFries";
            this.potatoFriesDataGridViewTextBoxColumn.Name = "potatoFriesDataGridViewTextBoxColumn";
            this.potatoFriesDataGridViewTextBoxColumn.ReadOnly = true;
            this.potatoFriesDataGridViewTextBoxColumn.Width = 120;
            // 
            // potatoWedgeDataGridViewTextBoxColumn
            // 
            this.potatoWedgeDataGridViewTextBoxColumn.DataPropertyName = "PotatoWedge";
            this.potatoWedgeDataGridViewTextBoxColumn.HeaderText = "PotatoWedge";
            this.potatoWedgeDataGridViewTextBoxColumn.Name = "potatoWedgeDataGridViewTextBoxColumn";
            this.potatoWedgeDataGridViewTextBoxColumn.ReadOnly = true;
            this.potatoWedgeDataGridViewTextBoxColumn.Width = 120;
            // 
            // crispyPataWholeDataGridViewTextBoxColumn
            // 
            this.crispyPataWholeDataGridViewTextBoxColumn.DataPropertyName = "CrispyPataWhole";
            this.crispyPataWholeDataGridViewTextBoxColumn.HeaderText = "CrispyPataWhole";
            this.crispyPataWholeDataGridViewTextBoxColumn.Name = "crispyPataWholeDataGridViewTextBoxColumn";
            this.crispyPataWholeDataGridViewTextBoxColumn.ReadOnly = true;
            this.crispyPataWholeDataGridViewTextBoxColumn.Width = 120;
            // 
            // crispyPataHalfDataGridViewTextBoxColumn
            // 
            this.crispyPataHalfDataGridViewTextBoxColumn.DataPropertyName = "CrispyPataHalf";
            this.crispyPataHalfDataGridViewTextBoxColumn.HeaderText = "CrispyPataHalf";
            this.crispyPataHalfDataGridViewTextBoxColumn.Name = "crispyPataHalfDataGridViewTextBoxColumn";
            this.crispyPataHalfDataGridViewTextBoxColumn.ReadOnly = true;
            this.crispyPataHalfDataGridViewTextBoxColumn.Width = 120;
            // 
            // samyupsalDataGridViewTextBoxColumn
            // 
            this.samyupsalDataGridViewTextBoxColumn.DataPropertyName = "Samyupsal";
            this.samyupsalDataGridViewTextBoxColumn.HeaderText = "Samyupsal";
            this.samyupsalDataGridViewTextBoxColumn.Name = "samyupsalDataGridViewTextBoxColumn";
            this.samyupsalDataGridViewTextBoxColumn.ReadOnly = true;
            this.samyupsalDataGridViewTextBoxColumn.Width = 120;
            // 
            // sanMigLightsBucketDataGridViewTextBoxColumn
            // 
            this.sanMigLightsBucketDataGridViewTextBoxColumn.DataPropertyName = "SanMigLightsBucket";
            this.sanMigLightsBucketDataGridViewTextBoxColumn.HeaderText = "SanMigLightsBucket";
            this.sanMigLightsBucketDataGridViewTextBoxColumn.Name = "sanMigLightsBucketDataGridViewTextBoxColumn";
            this.sanMigLightsBucketDataGridViewTextBoxColumn.ReadOnly = true;
            this.sanMigLightsBucketDataGridViewTextBoxColumn.Width = 120;
            // 
            // sanMigLightsPerBottleDataGridViewTextBoxColumn
            // 
            this.sanMigLightsPerBottleDataGridViewTextBoxColumn.DataPropertyName = "SanMigLightsPerBottle";
            this.sanMigLightsPerBottleDataGridViewTextBoxColumn.HeaderText = "SanMigLightsPerBottle";
            this.sanMigLightsPerBottleDataGridViewTextBoxColumn.Name = "sanMigLightsPerBottleDataGridViewTextBoxColumn";
            this.sanMigLightsPerBottleDataGridViewTextBoxColumn.ReadOnly = true;
            this.sanMigLightsPerBottleDataGridViewTextBoxColumn.Width = 120;
            // 
            // sMBPalePilsenBucketDataGridViewTextBoxColumn
            // 
            this.sMBPalePilsenBucketDataGridViewTextBoxColumn.DataPropertyName = "SMBPalePilsenBucket";
            this.sMBPalePilsenBucketDataGridViewTextBoxColumn.HeaderText = "SMBPalePilsenBucket";
            this.sMBPalePilsenBucketDataGridViewTextBoxColumn.Name = "sMBPalePilsenBucketDataGridViewTextBoxColumn";
            this.sMBPalePilsenBucketDataGridViewTextBoxColumn.ReadOnly = true;
            this.sMBPalePilsenBucketDataGridViewTextBoxColumn.Width = 120;
            // 
            // sMBPalePilsenPerBottleDataGridViewTextBoxColumn
            // 
            this.sMBPalePilsenPerBottleDataGridViewTextBoxColumn.DataPropertyName = "SMBPalePilsenPerBottle";
            this.sMBPalePilsenPerBottleDataGridViewTextBoxColumn.HeaderText = "SMBPalePilsenPerBottle";
            this.sMBPalePilsenPerBottleDataGridViewTextBoxColumn.Name = "sMBPalePilsenPerBottleDataGridViewTextBoxColumn";
            this.sMBPalePilsenPerBottleDataGridViewTextBoxColumn.ReadOnly = true;
            this.sMBPalePilsenPerBottleDataGridViewTextBoxColumn.Width = 120;
            // 
            // totalMealOrderDataGridViewTextBoxColumn
            // 
            this.totalMealOrderDataGridViewTextBoxColumn.DataPropertyName = "TotalMealOrder";
            this.totalMealOrderDataGridViewTextBoxColumn.HeaderText = "TotalMealOrder";
            this.totalMealOrderDataGridViewTextBoxColumn.Name = "totalMealOrderDataGridViewTextBoxColumn";
            this.totalMealOrderDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalMealOrderDataGridViewTextBoxColumn.Width = 120;
            // 
            // totalDrinksDataGridViewTextBoxColumn
            // 
            this.totalDrinksDataGridViewTextBoxColumn.DataPropertyName = "TotalDrinks";
            this.totalDrinksDataGridViewTextBoxColumn.HeaderText = "TotalDrinks";
            this.totalDrinksDataGridViewTextBoxColumn.Name = "totalDrinksDataGridViewTextBoxColumn";
            this.totalDrinksDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDrinksDataGridViewTextBoxColumn.Width = 120;
            // 
            // grandTotalDataGridViewTextBoxColumn
            // 
            this.grandTotalDataGridViewTextBoxColumn.DataPropertyName = "GrandTotal";
            this.grandTotalDataGridViewTextBoxColumn.HeaderText = "GrandTotal";
            this.grandTotalDataGridViewTextBoxColumn.Name = "grandTotalDataGridViewTextBoxColumn";
            this.grandTotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.grandTotalDataGridViewTextBoxColumn.Width = 120;
            // 
            // cashDataGridViewTextBoxColumn
            // 
            this.cashDataGridViewTextBoxColumn.DataPropertyName = "Cash";
            this.cashDataGridViewTextBoxColumn.HeaderText = "Cash";
            this.cashDataGridViewTextBoxColumn.Name = "cashDataGridViewTextBoxColumn";
            this.cashDataGridViewTextBoxColumn.ReadOnly = true;
            this.cashDataGridViewTextBoxColumn.Width = 120;
            // 
            // changeDataGridViewTextBoxColumn
            // 
            this.changeDataGridViewTextBoxColumn.DataPropertyName = "Change";
            this.changeDataGridViewTextBoxColumn.HeaderText = "Change";
            this.changeDataGridViewTextBoxColumn.Name = "changeDataGridViewTextBoxColumn";
            this.changeDataGridViewTextBoxColumn.ReadOnly = true;
            this.changeDataGridViewTextBoxColumn.Width = 120;
            // 
            // table1BindingSource2
            // 
            this.table1BindingSource2.DataMember = "Table_1";
            this.table1BindingSource2.DataSource = this.chowhoundDbDataSet1;
            // 
            // chowhoundDbDataSet1
            // 
            this.chowhoundDbDataSet1.DataSetName = "ChowhoundDbDataSet";
            this.chowhoundDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Home
            // 
            this.Home.BackgroundImage = global::Chowhound_Food_Avenue.Properties.Resources.HomeBtn;
            this.Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Home.Location = new System.Drawing.Point(995, 12);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(115, 54);
            this.Home.TabIndex = 1;
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 18);
            this.label5.TabIndex = 69;
            this.label5.Text = "Search By Username:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(199, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 68;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1122, 736);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SalesReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesReport";
            this.Load += new System.EventHandler(this.SalesReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chowhoundDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chowhoundTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chowhoundDbDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ChowhoundDbDataSet chowhoundDbDataSet;
        private System.Windows.Forms.BindingSource chowhoundTableBindingSource;
        private ChowhoundDbDataSetTableAdapters.Chowhound_TableTableAdapter chowhound_TableTableAdapter;
        private System.Windows.Forms.BindingSource table1BindingSource;
        private ChowhoundDbDataSetTableAdapters.Table_1TableAdapter table_1TableAdapter;
        private System.Windows.Forms.BindingSource table1BindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ChowhoundDbDataSet chowhoundDbDataSet1;
        private System.Windows.Forms.BindingSource table1BindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buffetMealDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plateOfTheDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sisigDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dynamiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buffaloWingsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lechonKawaliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn potatoFriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn potatoWedgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn crispyPataWholeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn crispyPataHalfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn samyupsalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sanMigLightsBucketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sanMigLightsPerBottleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMBPalePilsenBucketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMBPalePilsenPerBottleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMealOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDrinksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grandTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn changeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
    }
}