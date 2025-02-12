namespace latest
{
    partial class userManageCart
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
            this.cartGrid = new System.Windows.Forms.DataGridView();
            this.item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartitemsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cart_items = new latest.cart_items();
            this.cartitemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cafeSystemDataSet2 = new latest.CafeSystemDataSet2();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cartTableAdapter = new latest.CafeSystemDataSet2TableAdapters.CartTableAdapter();
            this.cafeSystemDataSet = new latest.CafeSystemDataSet();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemTableAdapter = new latest.CafeSystemDataSetTableAdapters.itemTableAdapter();
            this.cafeSystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cartGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartitemsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cart_items)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartitemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeSystemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeSystemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // cartGrid
            // 
            this.cartGrid.AllowUserToAddRows = false;
            this.cartGrid.AllowUserToDeleteRows = false;
            this.cartGrid.AutoGenerateColumns = false;
            this.cartGrid.BackgroundColor = System.Drawing.Color.White;
            this.cartGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cartGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.cartGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item_name,
            this.quantity,
            this.item_id});
            this.cartGrid.DataSource = this.cartitemsBindingSource1;
            this.cartGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.cartGrid.Location = new System.Drawing.Point(2, 97);
            this.cartGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cartGrid.MultiSelect = false;
            this.cartGrid.Name = "cartGrid";
            this.cartGrid.RowHeadersWidth = 51;
            this.cartGrid.RowTemplate.Height = 24;
            this.cartGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cartGrid.Size = new System.Drawing.Size(659, 452);
            this.cartGrid.TabIndex = 6;
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
            // item_id
            // 
            this.item_id.DataPropertyName = "item_id";
            this.item_id.HeaderText = "item_id";
            this.item_id.MinimumWidth = 6;
            this.item_id.Name = "item_id";
            this.item_id.Width = 125;
            // 
            // cartitemsBindingSource1
            // 
            this.cartitemsBindingSource1.DataSource = this.cart_items;
            this.cartitemsBindingSource1.Position = 0;
            // 
            // cart_items
            // 
            this.cart_items.DataSetName = "cart_items";
            this.cart_items.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cartitemsBindingSource
            // 
            this.cartitemsBindingSource.DataSource = this.cart_items;
            this.cartitemsBindingSource.Position = 0;
            // 
            // cartBindingSource
            // 
            this.cartBindingSource.DataMember = "Cart";
            this.cartBindingSource.DataSource = this.cafeSystemDataSet2;
            // 
            // cafeSystemDataSet2
            // 
            this.cafeSystemDataSet2.DataSetName = "CafeSystemDataSet2";
            this.cafeSystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(667, 232);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "Set";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(661, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Set Quantity";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(667, 193);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 26);
            this.textBox1.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(667, 302);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 41);
            this.button2.TabIndex = 7;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cartTableAdapter
            // 
            this.cartTableAdapter.ClearBeforeFill = true;
            // 
            // cafeSystemDataSet
            // 
            this.cafeSystemDataSet.DataSetName = "CafeSystemDataSet";
            this.cafeSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "item";
            this.itemBindingSource.DataSource = this.cafeSystemDataSet;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // cafeSystemDataSetBindingSource
            // 
            this.cafeSystemDataSetBindingSource.DataSource = this.cafeSystemDataSet;
            this.cafeSystemDataSetBindingSource.Position = 0;
            // 
            // itemBindingSource1
            // 
            this.itemBindingSource1.DataMember = "item";
            this.itemBindingSource1.DataSource = this.cafeSystemDataSetBindingSource;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(394, 52);
            this.label2.TabIndex = 48;
            this.label2.Text = "Manage Your Cart";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // userManageCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cartGrid);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "userManageCart";
            this.Text = "userManageCart";
            this.Load += new System.EventHandler(this.userManageCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cartGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartitemsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cart_items)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartitemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeSystemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeSystemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView cartGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private CafeSystemDataSet2 cafeSystemDataSet2;
        private System.Windows.Forms.BindingSource cartBindingSource;
        private CafeSystemDataSet2TableAdapters.CartTableAdapter cartTableAdapter;
        private CafeSystemDataSet cafeSystemDataSet;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private CafeSystemDataSetTableAdapters.itemTableAdapter itemTableAdapter;
        private System.Windows.Forms.BindingSource itemBindingSource1;
        private System.Windows.Forms.BindingSource cafeSystemDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_id;
        private System.Windows.Forms.BindingSource cartitemsBindingSource;
        private cart_items cart_items;
        private System.Windows.Forms.BindingSource cartitemsBindingSource1;
        private System.Windows.Forms.Label label2;
    }
}