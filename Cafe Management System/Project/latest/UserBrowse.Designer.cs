namespace latest
{
    partial class UserBrowse
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
            this.button1 = new System.Windows.Forms.Button();
            this.cartGrid = new System.Windows.Forms.DataGridView();
            this.item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemcartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cart_items = new latest.cart_items();
            this.cartBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cafeSystemDataSet2 = new latest.CafeSystemDataSet2();
            this.cartBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cafeSystemDataSet1 = new latest.CafeSystemDataSet1();
            this.itemGrid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cafeSystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cafeSystemDataSet = new latest.CafeSystemDataSet();
            this.itemTableAdapter = new latest.CafeSystemDataSetTableAdapters.itemTableAdapter();
            this.cartTableAdapter = new latest.CafeSystemDataSet1TableAdapters.cartTableAdapter();
            this.quantityBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cartTableAdapter1 = new latest.CafeSystemDataSet2TableAdapters.CartTableAdapter();
            this.cafeSystemDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.item_cartTableAdapter = new latest.cart_itemsTableAdapters.item_cartTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cartGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemcartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cart_items)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeSystemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeSystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeSystemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeSystemDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(698, 478);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 68);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cartGrid
            // 
            this.cartGrid.AllowUserToAddRows = false;
            this.cartGrid.AllowUserToDeleteRows = false;
            this.cartGrid.AutoGenerateColumns = false;
            this.cartGrid.BackgroundColor = System.Drawing.Color.MintCream;
            this.cartGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.cartGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item_name,
            this.quantity,
            this.itemidDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn1,
            this.itemnameDataGridViewTextBoxColumn,
            this.customer_id});
            this.cartGrid.DataSource = this.itemcartBindingSource;
            this.cartGrid.Location = new System.Drawing.Point(14, 338);
            this.cartGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cartGrid.Name = "cartGrid";
            this.cartGrid.RowHeadersWidth = 51;
            this.cartGrid.RowTemplate.Height = 24;
            this.cartGrid.Size = new System.Drawing.Size(578, 208);
            this.cartGrid.TabIndex = 5;
            this.cartGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cartGrid_CellContentClick);
            // 
            // item_name
            // 
            this.item_name.DataPropertyName = "item_name";
            this.item_name.HeaderText = "item_name";
            this.item_name.MinimumWidth = 6;
            this.item_name.Name = "item_name";
            this.item_name.Width = 125;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "quantity";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.Width = 125;
            // 
            // itemidDataGridViewTextBoxColumn
            // 
            this.itemidDataGridViewTextBoxColumn.DataPropertyName = "item_id";
            this.itemidDataGridViewTextBoxColumn.HeaderText = "item_id";
            this.itemidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemidDataGridViewTextBoxColumn.Name = "itemidDataGridViewTextBoxColumn";
            this.itemidDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn1
            // 
            this.quantityDataGridViewTextBoxColumn1.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn1.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn1.Name = "quantityDataGridViewTextBoxColumn1";
            this.quantityDataGridViewTextBoxColumn1.Visible = false;
            this.quantityDataGridViewTextBoxColumn1.Width = 125;
            // 
            // itemnameDataGridViewTextBoxColumn
            // 
            this.itemnameDataGridViewTextBoxColumn.DataPropertyName = "item_name";
            this.itemnameDataGridViewTextBoxColumn.HeaderText = "item_name";
            this.itemnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemnameDataGridViewTextBoxColumn.Name = "itemnameDataGridViewTextBoxColumn";
            this.itemnameDataGridViewTextBoxColumn.Visible = false;
            this.itemnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // customer_id
            // 
            this.customer_id.DataPropertyName = "customer_id";
            this.customer_id.HeaderText = "customer_id";
            this.customer_id.MinimumWidth = 6;
            this.customer_id.Name = "customer_id";
            this.customer_id.Visible = false;
            this.customer_id.Width = 125;
            // 
            // itemcartBindingSource
            // 
            this.itemcartBindingSource.DataMember = "item_cart";
            this.itemcartBindingSource.DataSource = this.cart_items;
            // 
            // cart_items
            // 
            this.cart_items.DataSetName = "cart_items";
            this.cart_items.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cartBindingSource2
            // 
            this.cartBindingSource2.DataMember = "Cart";
            this.cartBindingSource2.DataSource = this.cafeSystemDataSet2;
            // 
            // cafeSystemDataSet2
            // 
            this.cafeSystemDataSet2.DataSetName = "CafeSystemDataSet2";
            this.cafeSystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cartBindingSource1
            // 
            this.cartBindingSource1.DataMember = "Cart";
            this.cartBindingSource1.DataSource = this.cafeSystemDataSet2;
            // 
            // cartBindingSource
            // 
            this.cartBindingSource.DataMember = "cart";
            this.cartBindingSource.DataSource = this.cafeSystemDataSet1;
            // 
            // cafeSystemDataSet1
            // 
            this.cafeSystemDataSet1.DataSetName = "CafeSystemDataSet1";
            this.cafeSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemGrid
            // 
            this.itemGrid.AllowUserToAddRows = false;
            this.itemGrid.AllowUserToDeleteRows = false;
            this.itemGrid.AllowUserToOrderColumns = true;
            this.itemGrid.AutoGenerateColumns = false;
            this.itemGrid.BackgroundColor = System.Drawing.Color.MintCream;
            this.itemGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.itemGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.itemGrid.DataSource = this.itemBindingSource;
            this.itemGrid.Location = new System.Drawing.Point(14, 79);
            this.itemGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.itemGrid.MultiSelect = false;
            this.itemGrid.Name = "itemGrid";
            this.itemGrid.ReadOnly = true;
            this.itemGrid.RowHeadersWidth = 51;
            this.itemGrid.RowTemplate.Height = 24;
            this.itemGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemGrid.Size = new System.Drawing.Size(874, 188);
            this.itemGrid.TabIndex = 4;
            this.itemGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemGrid_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "item";
            this.itemBindingSource.DataSource = this.cafeSystemDataSetBindingSource;
            // 
            // cafeSystemDataSetBindingSource
            // 
            this.cafeSystemDataSetBindingSource.DataSource = this.cafeSystemDataSet;
            this.cafeSystemDataSetBindingSource.Position = 0;
            // 
            // cafeSystemDataSet
            // 
            this.cafeSystemDataSet.DataSetName = "CafeSystemDataSet";
            this.cafeSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // cartTableAdapter
            // 
            this.cartTableAdapter.ClearBeforeFill = true;
            // 
            // quantityBox
            // 
            this.quantityBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quantityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.quantityBox.Location = new System.Drawing.Point(690, 440);
            this.quantityBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(164, 30);
            this.quantityBox.TabIndex = 9;
            this.quantityBox.Tag = "";
            this.quantityBox.TextChanged += new System.EventHandler(this.quantityBox_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(676, 302);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 28);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(690, 338);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 62);
            this.button2.TabIndex = 8;
            this.button2.Text = "Filter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.comboBox1_Filter);
            // 
            // cartTableAdapter1
            // 
            this.cartTableAdapter1.ClearBeforeFill = true;
            // 
            // cafeSystemDataSetBindingSource1
            // 
            this.cafeSystemDataSetBindingSource1.DataSource = this.cafeSystemDataSet;
            this.cafeSystemDataSetBindingSource1.Position = 0;
            // 
            // item_cartTableAdapter
            // 
            this.item_cartTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(299, 52);
            this.label5.TabIndex = 46;
            this.label5.Text = "Browse Items";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 52);
            this.label1.TabIndex = 47;
            this.label1.Text = "Your Cart";
            // 
            // UserBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.quantityBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cartGrid);
            this.Controls.Add(this.itemGrid);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserBrowse";
            this.Text = "UserBrowse";
            this.Load += new System.EventHandler(this.UserBrowse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cartGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemcartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cart_items)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeSystemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeSystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeSystemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeSystemDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView cartGrid;
        private System.Windows.Forms.DataGridView itemGrid;
        private System.Windows.Forms.BindingSource cafeSystemDataSetBindingSource;
        private CafeSystemDataSet cafeSystemDataSet;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private CafeSystemDataSetTableAdapters.itemTableAdapter itemTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private CafeSystemDataSet1 cafeSystemDataSet1;
        private System.Windows.Forms.BindingSource cartBindingSource;
        private CafeSystemDataSet1TableAdapters.cartTableAdapter cartTableAdapter;
        private System.Windows.Forms.TextBox quantityBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private CafeSystemDataSet2 cafeSystemDataSet2;
        private System.Windows.Forms.BindingSource cartBindingSource1;
        private CafeSystemDataSet2TableAdapters.CartTableAdapter cartTableAdapter1;
        private System.Windows.Forms.BindingSource cartBindingSource2;
        private System.Windows.Forms.BindingSource cafeSystemDataSetBindingSource1;
        private cart_items cart_items;
        private System.Windows.Forms.BindingSource itemcartBindingSource;
        private cart_itemsTableAdapters.item_cartTableAdapter item_cartTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}