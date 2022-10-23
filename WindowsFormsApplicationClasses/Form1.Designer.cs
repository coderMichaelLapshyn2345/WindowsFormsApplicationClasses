namespace WindowsFormsApplicationClasses
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

       #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.PackageDateTextBox = new System.Windows.Forms.TextBox();
            this.ExpirationDateTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.UnitTextBox = new System.Windows.Forms.TextBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.DeleteProductBtn = new System.Windows.Forms.Button();
            this.BookNameTextBox = new System.Windows.Forms.TextBox();
            this.BookPriceTextBox = new System.Windows.Forms.TextBox();
            this.BookCountry = new System.Windows.Forms.TextBox();
            this.BookDatePackageTextBox = new System.Windows.Forms.TextBox();
            this.BookDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.BookPagesTextBox = new System.Windows.Forms.TextBox();
            this.BookPublishHouseTextBox = new System.Windows.Forms.TextBox();
            this.BookContributorsTextBox = new System.Windows.Forms.TextBox();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddBookBtn = new System.Windows.Forms.Button();
            this.DeleteBookBtn = new System.Windows.Forms.Button();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datePackageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(29, 12);
            this.NameTextBox.Multiline = true;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(166, 45);
            this.NameTextBox.TabIndex = 0;
            this.NameTextBox.Text = "Name ";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(261, 12);
            this.PriceTextBox.Multiline = true;
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(166, 45);
            this.PriceTextBox.TabIndex = 1;
            this.PriceTextBox.Text = "Price";
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Location = new System.Drawing.Point(510, 12);
            this.CountryTextBox.Multiline = true;
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(166, 45);
            this.CountryTextBox.TabIndex = 2;
            this.CountryTextBox.Text = "Country";
            // 
            // PackageDateTextBox
            // 
            this.PackageDateTextBox.Location = new System.Drawing.Point(29, 90);
            this.PackageDateTextBox.Multiline = true;
            this.PackageDateTextBox.Name = "PackageDateTextBox";
            this.PackageDateTextBox.Size = new System.Drawing.Size(166, 45);
            this.PackageDateTextBox.TabIndex = 3;
            this.PackageDateTextBox.Text = "Date Package";
            // 
            // ExpirationDateTextBox
            // 
            this.ExpirationDateTextBox.Location = new System.Drawing.Point(261, 90);
            this.ExpirationDateTextBox.Multiline = true;
            this.ExpirationDateTextBox.Name = "ExpirationDateTextBox";
            this.ExpirationDateTextBox.Size = new System.Drawing.Size(166, 45);
            this.ExpirationDateTextBox.TabIndex = 4;
            this.ExpirationDateTextBox.Text = "Expriration";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(510, 90);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(166, 45);
            this.DescriptionTextBox.TabIndex = 5;
            this.DescriptionTextBox.Text = "Description";
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(748, 12);
            this.AmountTextBox.Multiline = true;
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(166, 45);
            this.AmountTextBox.TabIndex = 6;
            this.AmountTextBox.Text = "Amount";
            // 
            // UnitTextBox
            // 
            this.UnitTextBox.Location = new System.Drawing.Point(748, 90);
            this.UnitTextBox.Multiline = true;
            this.UnitTextBox.Name = "UnitTextBox";
            this.UnitTextBox.Size = new System.Drawing.Size(166, 45);
            this.UnitTextBox.TabIndex = 7;
            this.UnitTextBox.Text = "Units";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(WindowsFormsApplicationClasses.Form1.Product);
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.Location = new System.Drawing.Point(29, 278);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(187, 54);
            this.AddProductBtn.TabIndex = 9;
            this.AddProductBtn.Text = "Add Product";
            this.AddProductBtn.UseVisualStyleBackColor = true;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // DeleteProductBtn
            // 
            this.DeleteProductBtn.Location = new System.Drawing.Point(714, 278);
            this.DeleteProductBtn.Name = "DeleteProductBtn";
            this.DeleteProductBtn.Size = new System.Drawing.Size(200, 54);
            this.DeleteProductBtn.TabIndex = 10;
            this.DeleteProductBtn.Text = "Delete Product";
            this.DeleteProductBtn.UseVisualStyleBackColor = true;
            this.DeleteProductBtn.Click += new System.EventHandler(this.DeleteProductBtn_Click);
            // 
            // BookNameTextBox
            // 
            this.BookNameTextBox.Location = new System.Drawing.Point(1382, 12);
            this.BookNameTextBox.Multiline = true;
            this.BookNameTextBox.Name = "BookNameTextBox";
            this.BookNameTextBox.Size = new System.Drawing.Size(170, 45);
            this.BookNameTextBox.TabIndex = 11;
            this.BookNameTextBox.Text = "Name ";
            // 
            // BookPriceTextBox
            // 
            this.BookPriceTextBox.Location = new System.Drawing.Point(1624, 7);
            this.BookPriceTextBox.Multiline = true;
            this.BookPriceTextBox.Name = "BookPriceTextBox";
            this.BookPriceTextBox.Size = new System.Drawing.Size(187, 45);
            this.BookPriceTextBox.TabIndex = 12;
            this.BookPriceTextBox.Text = "Price";
            // 
            // BookCountry
            // 
            this.BookCountry.Location = new System.Drawing.Point(1375, 73);
            this.BookCountry.Multiline = true;
            this.BookCountry.Name = "BookCountry";
            this.BookCountry.Size = new System.Drawing.Size(177, 43);
            this.BookCountry.TabIndex = 13;
            this.BookCountry.Text = "Country";
            // 
            // BookDatePackageTextBox
            // 
            this.BookDatePackageTextBox.Location = new System.Drawing.Point(1624, 73);
            this.BookDatePackageTextBox.Multiline = true;
            this.BookDatePackageTextBox.Name = "BookDatePackageTextBox";
            this.BookDatePackageTextBox.Size = new System.Drawing.Size(192, 43);
            this.BookDatePackageTextBox.TabIndex = 14;
            this.BookDatePackageTextBox.Text = "Date Package";
            // 
            // BookDescriptionTextBox
            // 
            this.BookDescriptionTextBox.Location = new System.Drawing.Point(1884, 2);
            this.BookDescriptionTextBox.Multiline = true;
            this.BookDescriptionTextBox.Name = "BookDescriptionTextBox";
            this.BookDescriptionTextBox.Size = new System.Drawing.Size(190, 50);
            this.BookDescriptionTextBox.TabIndex = 15;
            this.BookDescriptionTextBox.Text = "Description ";
            // 
            // BookPagesTextBox
            // 
            this.BookPagesTextBox.Location = new System.Drawing.Point(2110, 11);
            this.BookPagesTextBox.Multiline = true;
            this.BookPagesTextBox.Name = "BookPagesTextBox";
            this.BookPagesTextBox.Size = new System.Drawing.Size(205, 46);
            this.BookPagesTextBox.TabIndex = 16;
            this.BookPagesTextBox.Text = "Number of pages";
            // 
            // BookPublishHouseTextBox
            // 
            this.BookPublishHouseTextBox.Location = new System.Drawing.Point(1884, 73);
            this.BookPublishHouseTextBox.Multiline = true;
            this.BookPublishHouseTextBox.Name = "BookPublishHouseTextBox";
            this.BookPublishHouseTextBox.Size = new System.Drawing.Size(180, 49);
            this.BookPublishHouseTextBox.TabIndex = 17;
            this.BookPublishHouseTextBox.Text = "Publish House";
            // 
            // BookContributorsTextBox
            // 
            this.BookContributorsTextBox.Location = new System.Drawing.Point(2116, 73);
            this.BookContributorsTextBox.Multiline = true;
            this.BookContributorsTextBox.Name = "BookContributorsTextBox";
            this.BookContributorsTextBox.Size = new System.Drawing.Size(199, 51);
            this.BookContributorsTextBox.TabIndex = 18;
            this.BookContributorsTextBox.Text = "List of contributors";
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(WindowsFormsApplicationClasses.Form1.Book);
            // 
            // AddBookBtn
            // 
            this.AddBookBtn.Location = new System.Drawing.Point(1589, 328);
            this.AddBookBtn.Name = "AddBookBtn";
            this.AddBookBtn.Size = new System.Drawing.Size(198, 56);
            this.AddBookBtn.TabIndex = 20;
            this.AddBookBtn.Text = "Add Book";
            this.AddBookBtn.UseVisualStyleBackColor = true;
            this.AddBookBtn.Click += new System.EventHandler(this.AddBookBtn_Click);
            // 
            // DeleteBookBtn
            // 
            this.DeleteBookBtn.Location = new System.Drawing.Point(2629, 321);
            this.DeleteBookBtn.Name = "DeleteBookBtn";
            this.DeleteBookBtn.Size = new System.Drawing.Size(216, 63);
            this.DeleteBookBtn.TabIndex = 21;
            this.DeleteBookBtn.Text = "Delete Book";
            this.DeleteBookBtn.UseVisualStyleBackColor = true;
            this.DeleteBookBtn.Click += new System.EventHandler(this.DeleteBookBtn_Click);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 200;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.Width = 200;
            // 
            // datePackageDataGridViewTextBoxColumn
            // 
            this.datePackageDataGridViewTextBoxColumn.DataPropertyName = "DatePackage";
            this.datePackageDataGridViewTextBoxColumn.HeaderText = "DatePackage";
            this.datePackageDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.datePackageDataGridViewTextBoxColumn.Name = "datePackageDataGridViewTextBoxColumn";
            this.datePackageDataGridViewTextBoxColumn.Width = 200;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 200;
            // 
            // ExpirationDate
            // 
            this.ExpirationDate.DataPropertyName = "ExpirationDate";
            this.ExpirationDate.HeaderText = "ExpirationDate";
            this.ExpirationDate.MinimumWidth = 10;
            this.ExpirationDate.Name = "ExpirationDate";
            this.ExpirationDate.Width = 200;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.Location = new System.Drawing.Point(12, 437);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1121, 615);
            this.dataGridView1.TabIndex = 22;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16});
            this.dataGridView2.Location = new System.Drawing.Point(1570, 448);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 82;
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(1275, 604);
            this.dataGridView2.TabIndex = 23;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name ";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Price ";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Country ";
            this.Column3.MinimumWidth = 10;
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Description";
            this.Column4.MinimumWidth = 10;
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Date Package";
            this.Column5.MinimumWidth = 10;
            this.Column5.Name = "Column5";
            this.Column5.Width = 200;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Amount";
            this.Column6.MinimumWidth = 10;
            this.Column6.Name = "Column6";
            this.Column6.Width = 200;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Date of expiry";
            this.Column7.MinimumWidth = 10;
            this.Column7.Name = "Column7";
            this.Column7.Width = 200;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Units";
            this.Column8.MinimumWidth = 10;
            this.Column8.Name = "Column8";
            this.Column8.Width = 200;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Name ";
            this.Column9.MinimumWidth = 10;
            this.Column9.Name = "Column9";
            this.Column9.Width = 200;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Price";
            this.Column10.MinimumWidth = 10;
            this.Column10.Name = "Column10";
            this.Column10.Width = 200;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Country";
            this.Column11.MinimumWidth = 10;
            this.Column11.Name = "Column11";
            this.Column11.Width = 200;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Description";
            this.Column12.MinimumWidth = 10;
            this.Column12.Name = "Column12";
            this.Column12.Width = 200;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Date Package";
            this.Column13.MinimumWidth = 10;
            this.Column13.Name = "Column13";
            this.Column13.Width = 200;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Number of pages ";
            this.Column14.MinimumWidth = 10;
            this.Column14.Name = "Column14";
            this.Column14.Width = 200;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Publish House ";
            this.Column15.MinimumWidth = 10;
            this.Column15.Name = "Column15";
            this.Column15.Width = 200;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "Contributors ";
            this.Column16.MinimumWidth = 10;
            this.Column16.Name = "Column16";
            this.Column16.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2884, 1082);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DeleteBookBtn);
            this.Controls.Add(this.AddBookBtn);
            this.Controls.Add(this.BookContributorsTextBox);
            this.Controls.Add(this.BookPublishHouseTextBox);
            this.Controls.Add(this.BookPagesTextBox);
            this.Controls.Add(this.BookDescriptionTextBox);
            this.Controls.Add(this.BookDatePackageTextBox);
            this.Controls.Add(this.BookCountry);
            this.Controls.Add(this.BookPriceTextBox);
            this.Controls.Add(this.BookNameTextBox);
            this.Controls.Add(this.DeleteProductBtn);
            this.Controls.Add(this.AddProductBtn);
            this.Controls.Add(this.UnitTextBox);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.ExpirationDateTextBox);
            this.Controls.Add(this.PackageDateTextBox);
            this.Controls.Add(this.CountryTextBox);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox CountryTextBox;
        private System.Windows.Forms.TextBox PackageDateTextBox;
        private System.Windows.Forms.TextBox ExpirationDateTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.TextBox UnitTextBox;
        private System.Windows.Forms.Button AddProductBtn;
        private System.Windows.Forms.Button DeleteProductBtn;
        private System.Windows.Forms.TextBox BookNameTextBox;
        private System.Windows.Forms.TextBox BookPriceTextBox;
        private System.Windows.Forms.TextBox BookCountry;
        private System.Windows.Forms.TextBox BookDatePackageTextBox;
        private System.Windows.Forms.TextBox BookDescriptionTextBox;
        private System.Windows.Forms.TextBox BookPagesTextBox;
        private System.Windows.Forms.TextBox BookPublishHouseTextBox;
        private System.Windows.Forms.TextBox BookContributorsTextBox;
        private System.Windows.Forms.Button AddBookBtn;
        private System.Windows.Forms.Button DeleteBookBtn;
        public System.Windows.Forms.BindingSource productBindingSource;
        public System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datePackageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpirationDate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
    }
}

