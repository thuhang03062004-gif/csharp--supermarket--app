namespace QLSieuThi
{
    partial class Sanpham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sanpham));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityPerUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsInStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsOnOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorderLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discontinuedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.northWindDataSet1 = new QLSieuThi.NorthWindDataSet1();
            this.productsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.northWindDataSet2 = new QLSieuThi.NorthWindDataSet2();
            this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.northWindDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.northWindDataSet = new QLSieuThi.NorthWindDataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTen = new System.Windows.Forms.TextBox();
            this.textBoxDgia = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttoncapnhat = new System.Windows.Forms.Button();
            this.buttonxoa = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonnhom = new System.Windows.Forms.Button();
            this.XemSP = new System.Windows.Forms.Button();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new QLSieuThi.NorthWindDataSetTableAdapters.ProductsTableAdapter();
            this.productsTableAdapter1 = new QLSieuThi.NorthWindDataSet2TableAdapters.ProductsTableAdapter();
            this.productsTableAdapter2 = new QLSieuThi.NorthWindDataSet1TableAdapters.ProductsTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northWindDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northWindDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northWindDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northWindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Ten,
            this.Nhom,
            this.NCC,
            this.Dongia,
            this.productIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.supplierIDDataGridViewTextBoxColumn,
            this.categoryIDDataGridViewTextBoxColumn,
            this.quantityPerUnitDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.unitsInStockDataGridViewTextBoxColumn,
            this.unitsOnOrderDataGridViewTextBoxColumn,
            this.reorderLevelDataGridViewTextBoxColumn,
            this.discontinuedDataGridViewCheckBoxColumn});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.DataSource = this.productsBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(15, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(554, 263);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ProductID";
            this.ID.HeaderText = "ID Sản phẩm";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "ProductName";
            this.Ten.HeaderText = "Tên sản phẩm";
            this.Ten.Name = "Ten";
            // 
            // Nhom
            // 
            this.Nhom.DataPropertyName = "CategoryID";
            this.Nhom.HeaderText = "Nhóm sản phẩm";
            this.Nhom.Name = "Nhom";
            this.Nhom.Width = 110;
            // 
            // NCC
            // 
            this.NCC.DataPropertyName = "SupplierID";
            this.NCC.HeaderText = "Nhà cung cấp";
            this.NCC.Name = "NCC";
            // 
            // Dongia
            // 
            this.Dongia.DataPropertyName = "UnitPrice";
            this.Dongia.HeaderText = "Đơn giá";
            this.Dongia.Name = "Dongia";
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // supplierIDDataGridViewTextBoxColumn
            // 
            this.supplierIDDataGridViewTextBoxColumn.DataPropertyName = "SupplierID";
            this.supplierIDDataGridViewTextBoxColumn.HeaderText = "SupplierID";
            this.supplierIDDataGridViewTextBoxColumn.Name = "supplierIDDataGridViewTextBoxColumn";
            // 
            // categoryIDDataGridViewTextBoxColumn
            // 
            this.categoryIDDataGridViewTextBoxColumn.DataPropertyName = "CategoryID";
            this.categoryIDDataGridViewTextBoxColumn.HeaderText = "CategoryID";
            this.categoryIDDataGridViewTextBoxColumn.Name = "categoryIDDataGridViewTextBoxColumn";
            // 
            // quantityPerUnitDataGridViewTextBoxColumn
            // 
            this.quantityPerUnitDataGridViewTextBoxColumn.DataPropertyName = "QuantityPerUnit";
            this.quantityPerUnitDataGridViewTextBoxColumn.HeaderText = "QuantityPerUnit";
            this.quantityPerUnitDataGridViewTextBoxColumn.Name = "quantityPerUnitDataGridViewTextBoxColumn";
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            // 
            // unitsInStockDataGridViewTextBoxColumn
            // 
            this.unitsInStockDataGridViewTextBoxColumn.DataPropertyName = "UnitsInStock";
            this.unitsInStockDataGridViewTextBoxColumn.HeaderText = "UnitsInStock";
            this.unitsInStockDataGridViewTextBoxColumn.Name = "unitsInStockDataGridViewTextBoxColumn";
            // 
            // unitsOnOrderDataGridViewTextBoxColumn
            // 
            this.unitsOnOrderDataGridViewTextBoxColumn.DataPropertyName = "UnitsOnOrder";
            this.unitsOnOrderDataGridViewTextBoxColumn.HeaderText = "UnitsOnOrder";
            this.unitsOnOrderDataGridViewTextBoxColumn.Name = "unitsOnOrderDataGridViewTextBoxColumn";
            // 
            // reorderLevelDataGridViewTextBoxColumn
            // 
            this.reorderLevelDataGridViewTextBoxColumn.DataPropertyName = "ReorderLevel";
            this.reorderLevelDataGridViewTextBoxColumn.HeaderText = "ReorderLevel";
            this.reorderLevelDataGridViewTextBoxColumn.Name = "reorderLevelDataGridViewTextBoxColumn";
            // 
            // discontinuedDataGridViewCheckBoxColumn
            // 
            this.discontinuedDataGridViewCheckBoxColumn.DataPropertyName = "Discontinued";
            this.discontinuedDataGridViewCheckBoxColumn.HeaderText = "Discontinued";
            this.discontinuedDataGridViewCheckBoxColumn.Name = "discontinuedDataGridViewCheckBoxColumn";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tToolStripMenuItem,
            this.toolStripMenuItem1,
            this.tToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(243, 54);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // tToolStripMenuItem
            // 
            this.tToolStripMenuItem.Name = "tToolStripMenuItem";
            this.tToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.tToolStripMenuItem.Text = "Tính số lượng sản phẩm đã bán";
            this.tToolStripMenuItem.Click += new System.EventHandler(this.tToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(239, 6);
            // 
            // tToolStripMenuItem1
            // 
            this.tToolStripMenuItem1.Name = "tToolStripMenuItem1";
            this.tToolStripMenuItem1.Size = new System.Drawing.Size(242, 22);
            this.tToolStripMenuItem1.Text = "Thông tin chi tiết của sản phẩm";
            this.tToolStripMenuItem1.Click += new System.EventHandler(this.tToolStripMenuItem1_Click);
            // 
            // productsBindingSource3
            // 
            this.productsBindingSource3.DataMember = "Products";
            this.productsBindingSource3.DataSource = this.northWindDataSet1;
            // 
            // northWindDataSet1
            // 
            this.northWindDataSet1.DataSetName = "NorthWindDataSet1";
            this.northWindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource2
            // 
            this.productsBindingSource2.DataMember = "Products";
            this.productsBindingSource2.DataSource = this.northWindDataSet2;
            // 
            // northWindDataSet2
            // 
            this.northWindDataSet2.DataSetName = "NorthWindDataSet2";
            this.northWindDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource1
            // 
            this.productsBindingSource1.DataMember = "Products";
            this.productsBindingSource1.DataSource = this.northWindDataSetBindingSource;
            // 
            // northWindDataSetBindingSource
            // 
            this.northWindDataSetBindingSource.DataSource = this.northWindDataSet;
            this.northWindDataSetBindingSource.Position = 0;
            // 
            // northWindDataSet
            // 
            this.northWindDataSet.DataSetName = "NorthWindDataSet";
            this.northWindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(119, 121);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(109, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhóm sản phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nhà cung cấp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Đơn giá";
            // 
            // textBoxTen
            // 
            this.textBoxTen.Location = new System.Drawing.Point(119, 95);
            this.textBoxTen.Name = "textBoxTen";
            this.textBoxTen.Size = new System.Drawing.Size(155, 20);
            this.textBoxTen.TabIndex = 9;
            // 
            // textBoxDgia
            // 
            this.textBoxDgia.Location = new System.Drawing.Point(378, 91);
            this.textBoxDgia.Name = "textBoxDgia";
            this.textBoxDgia.Size = new System.Drawing.Size(85, 20);
            this.textBoxDgia.TabIndex = 10;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(119, 69);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 11;
            // 
            // buttonThem
            // 
            this.buttonThem.BackColor = System.Drawing.SystemColors.Control;
            this.buttonThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThem.Image = ((System.Drawing.Image)(resources.GetObject("buttonThem.Image")));
            this.buttonThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThem.Location = new System.Drawing.Point(300, 125);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(81, 23);
            this.buttonThem.TabIndex = 13;
            this.buttonThem.Text = "Thêm mới";
            this.buttonThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonThem.UseVisualStyleBackColor = false;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttoncapnhat
            // 
            this.buttoncapnhat.BackColor = System.Drawing.SystemColors.Control;
            this.buttoncapnhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttoncapnhat.Image = ((System.Drawing.Image)(resources.GetObject("buttoncapnhat.Image")));
            this.buttoncapnhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttoncapnhat.Location = new System.Drawing.Point(387, 125);
            this.buttoncapnhat.Name = "buttoncapnhat";
            this.buttoncapnhat.Size = new System.Drawing.Size(81, 23);
            this.buttoncapnhat.TabIndex = 14;
            this.buttoncapnhat.Text = "Cập nhật";
            this.buttoncapnhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttoncapnhat.UseVisualStyleBackColor = false;
            this.buttoncapnhat.Click += new System.EventHandler(this.buttoncapnhat_Click);
            // 
            // buttonxoa
            // 
            this.buttonxoa.BackColor = System.Drawing.SystemColors.Control;
            this.buttonxoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonxoa.Image = ((System.Drawing.Image)(resources.GetObject("buttonxoa.Image")));
            this.buttonxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonxoa.Location = new System.Drawing.Point(474, 125);
            this.buttonxoa.Name = "buttonxoa";
            this.buttonxoa.Size = new System.Drawing.Size(61, 23);
            this.buttonxoa.TabIndex = 15;
            this.buttonxoa.Text = "Xóa";
            this.buttonxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonxoa.UseVisualStyleBackColor = false;
            this.buttonxoa.Click += new System.EventHandler(this.buttonxoa_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 37);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // buttonnhom
            // 
            this.buttonnhom.Image = ((System.Drawing.Image)(resources.GetObject("buttonnhom.Image")));
            this.buttonnhom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonnhom.Location = new System.Drawing.Point(119, 148);
            this.buttonnhom.Name = "buttonnhom";
            this.buttonnhom.Size = new System.Drawing.Size(109, 24);
            this.buttonnhom.TabIndex = 17;
            this.buttonnhom.Text = "Tìm theo nhóm";
            this.buttonnhom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonnhom.UseVisualStyleBackColor = true;
            this.buttonnhom.Click += new System.EventHandler(this.buttonnhom_Click);
            // 
            // XemSP
            // 
            this.XemSP.BackColor = System.Drawing.SystemColors.Control;
            this.XemSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XemSP.Image = ((System.Drawing.Image)(resources.GetObject("XemSP.Image")));
            this.XemSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.XemSP.Location = new System.Drawing.Point(365, 154);
            this.XemSP.Name = "XemSP";
            this.XemSP.Size = new System.Drawing.Size(131, 23);
            this.XemSP.TabIndex = 18;
            this.XemSP.Text = "Xem DS Sản phẩm";
            this.XemSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.XemSP.UseVisualStyleBackColor = false;
            this.XemSP.Click += new System.EventHandler(this.XemSP_Click);
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.northWindDataSetBindingSource;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // productsTableAdapter2
            // 
            this.productsTableAdapter2.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(378, 63);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 19;
            // 
            // Sanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 508);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.XemSP);
            this.Controls.Add(this.buttonnhom);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonxoa);
            this.Controls.Add(this.buttoncapnhat);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxDgia);
            this.Controls.Add(this.textBoxTen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Sanpham";
            this.Text = "Sanpham";
            this.Load += new System.EventHandler(this.Sanpham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northWindDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northWindDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northWindDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northWindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTen;
        private System.Windows.Forms.TextBox textBoxDgia;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttoncapnhat;
        private System.Windows.Forms.Button buttonxoa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonnhom;
        private System.Windows.Forms.Button XemSP;
        private System.Windows.Forms.BindingSource northWindDataSetBindingSource;
        private NorthWindDataSet northWindDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private NorthWindDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.BindingSource productsBindingSource1;
        private NorthWindDataSet2 northWindDataSet2;
        private System.Windows.Forms.BindingSource productsBindingSource2;
        private NorthWindDataSet2TableAdapters.ProductsTableAdapter productsTableAdapter1;
        private NorthWindDataSet1 northWindDataSet1;
        private System.Windows.Forms.BindingSource productsBindingSource3;
        private NorthWindDataSet1TableAdapters.ProductsTableAdapter productsTableAdapter2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn NCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityPerUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsInStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsOnOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reorderLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn discontinuedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}