namespace latest
{
    partial class Admin_Delete_Table
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
            this.label5 = new System.Windows.Forms.Label();
            this.cafeSystemDataSet = new latest.CafeSystemDataSet();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemTableAdapter = new latest.CafeSystemDataSetTableAdapters.itemTableAdapter();
            this.tableAdapterManager = new latest.CafeSystemDataSetTableAdapters.TableAdapterManager();
            this.cafeSystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cafeSystemDataSet1 = new latest.CafeSystemDataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.delButton = new System.Windows.Forms.Button();
            this.cartTableAdapter = new latest.CafeSystemDataSet1TableAdapters.cartTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cellsMain = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.cafeSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeSystemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeSystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellsMain)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(628, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(340, 32);
            this.label5.TabIndex = 36;
            this.label5.Text = "Enter ID to Delete Table";
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
            // itemBindingSource1
            // 
            this.itemBindingSource1.DataMember = "item";
            this.itemBindingSource1.DataSource = this.cafeSystemDataSetBindingSource;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(628, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 32);
            this.label1.TabIndex = 33;
            this.label1.Text = "ID";
            // 
            // delButton
            // 
            this.delButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delButton.Location = new System.Drawing.Point(726, 230);
            this.delButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(124, 52);
            this.delButton.TabIndex = 32;
            this.delButton.Text = "Delete";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click_1);
            // 
            // cartTableAdapter
            // 
            this.cartTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(634, 163);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(315, 44);
            this.textBox1.TabIndex = 34;
            // 
            // cellsMain
            // 
            this.cellsMain.AllowUserToAddRows = false;
            this.cellsMain.AllowUserToDeleteRows = false;
            this.cellsMain.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cellsMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cellsMain.Location = new System.Drawing.Point(12, 35);
            this.cellsMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cellsMain.Name = "cellsMain";
            this.cellsMain.ReadOnly = true;
            this.cellsMain.RowHeadersWidth = 62;
            this.cellsMain.RowTemplate.Height = 28;
            this.cellsMain.Size = new System.Drawing.Size(551, 551);
            this.cellsMain.TabIndex = 37;
            this.cellsMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellsMain_CellContentClick);
            // 
            // Admin_Delete_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(985, 661);
            this.Controls.Add(this.cellsMain);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.textBox1);
            this.Name = "Admin_Delete_Table";
            this.Text = "Admin_Delete_Table";
            this.Load += new System.EventHandler(this.Admin_Delete_Table_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cafeSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeSystemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeSystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellsMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private CafeSystemDataSet cafeSystemDataSet;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private CafeSystemDataSetTableAdapters.itemTableAdapter itemTableAdapter;
        private CafeSystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource cafeSystemDataSetBindingSource;
        private System.Windows.Forms.BindingSource itemBindingSource1;
        private System.Windows.Forms.BindingSource cartBindingSource;
        private CafeSystemDataSet1 cafeSystemDataSet1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delButton;
        private CafeSystemDataSet1TableAdapters.cartTableAdapter cartTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView cellsMain;
    }
}