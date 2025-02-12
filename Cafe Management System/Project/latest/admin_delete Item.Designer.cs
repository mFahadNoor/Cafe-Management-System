namespace latest
{
    partial class admin_delete_Item
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
            this.cafeSystemDataSet = new latest.CafeSystemDataSet();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemTableAdapter = new latest.CafeSystemDataSetTableAdapters.itemTableAdapter();
            this.tableAdapterManager = new latest.CafeSystemDataSetTableAdapters.TableAdapterManager();
            this.cafeSystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cellsMain = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.delButton = new System.Windows.Forms.Button();
            this.cafeSystemDataSet1 = new latest.CafeSystemDataSet1();
            this.cartTableAdapter = new latest.CafeSystemDataSet1TableAdapters.cartTableAdapter();
            this.cartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cafeSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeSystemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeSystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.itemTableAdapter = this.itemTableAdapter;
            this.tableAdapterManager.UpdateOrder = latest.CafeSystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cafeSystemDataSetBindingSource
            // 
            this.cafeSystemDataSetBindingSource.DataSource = this.cafeSystemDataSet;
            this.cafeSystemDataSetBindingSource.Position = 0;
            // 
            // cellsMain
            // 
            this.cellsMain.AllowUserToAddRows = false;
            this.cellsMain.AllowUserToDeleteRows = false;
            this.cellsMain.AutoGenerateColumns = false;
            this.cellsMain.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cellsMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cellsMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.cellsMain.DataSource = this.itemBindingSource1;
            this.cellsMain.Location = new System.Drawing.Point(0, 35);
            this.cellsMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cellsMain.Name = "cellsMain";
            this.cellsMain.ReadOnly = true;
            this.cellsMain.RowHeadersWidth = 62;
            this.cellsMain.RowTemplate.Height = 28;
            this.cellsMain.Size = new System.Drawing.Size(605, 638);
            this.cellsMain.TabIndex = 29;
            this.cellsMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellsMain_CellContentClick);
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
            // itemBindingSource1
            // 
            this.itemBindingSource1.DataMember = "item";
            this.itemBindingSource1.DataSource = this.cafeSystemDataSetBindingSource;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(634, 169);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(315, 44);
            this.textBox1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(628, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "ID";
            // 
            // delButton
            // 
            this.delButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delButton.Location = new System.Drawing.Point(726, 236);
            this.delButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(124, 52);
            this.delButton.TabIndex = 18;
            this.delButton.Text = "Delete";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // cafeSystemDataSet1
            // 
            this.cafeSystemDataSet1.DataSetName = "CafeSystemDataSet1";
            this.cafeSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cartTableAdapter
            // 
            this.cartTableAdapter.ClearBeforeFill = true;
            // 
            // cartBindingSource
            // 
            this.cartBindingSource.DataMember = "cart";
            this.cartBindingSource.DataSource = this.cafeSystemDataSet1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(628, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(321, 32);
            this.label5.TabIndex = 30;
            this.label5.Text = "Enter ID to Delete Item";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // admin_delete_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(995, 680);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cellsMain);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delButton);
            this.Name = "admin_delete_Item";
            this.Text = "admin_delete_Item";
            this.Load += new System.EventHandler(this.admin_delete_Item_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cafeSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeSystemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeSystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CafeSystemDataSet cafeSystemDataSet;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private CafeSystemDataSetTableAdapters.itemTableAdapter itemTableAdapter;
        private CafeSystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource cafeSystemDataSetBindingSource;
        private System.Windows.Forms.DataGridView cellsMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource itemBindingSource1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delButton;
        private CafeSystemDataSet1 cafeSystemDataSet1;
        private CafeSystemDataSet1TableAdapters.cartTableAdapter cartTableAdapter;
        private System.Windows.Forms.BindingSource cartBindingSource;
        private System.Windows.Forms.Label label5;
    }
}