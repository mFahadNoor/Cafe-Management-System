namespace latest
{
    partial class admin_add_table
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
            this.itemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cafeSystemDataSet1 = new latest.CafeSystemDataSet1();
            this.cartTableAdapter = new latest.CafeSystemDataSet1TableAdapters.cartTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.categoryDrop = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cafeSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeSystemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeSystemDataSet1)).BeginInit();
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
            // cartTableAdapter
            // 
            this.cartTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(457, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 32);
            this.label5.TabIndex = 45;
            this.label5.Text = "Add Table";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(386, 239);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(273, 44);
            this.textBox2.TabIndex = 40;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(380, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 32);
            this.label2.TabIndex = 39;
            this.label2.Text = "Quantity";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(386, 160);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 44);
            this.textBox1.TabIndex = 38;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(380, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 32);
            this.label1.TabIndex = 37;
            this.label1.Text = "ID";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(463, 413);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 52);
            this.button1.TabIndex = 36;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // categoryDrop
            // 
            this.categoryDrop.FormattingEnabled = true;
            this.categoryDrop.Location = new System.Drawing.Point(386, 346);
            this.categoryDrop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categoryDrop.Name = "categoryDrop";
            this.categoryDrop.Size = new System.Drawing.Size(273, 28);
            this.categoryDrop.TabIndex = 46;
            this.categoryDrop.SelectedIndexChanged += new System.EventHandler(this.categoryDrop_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(380, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 32);
            this.label6.TabIndex = 47;
            this.label6.Text = "Category";
            // 
            // admin_add_table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(983, 662);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.categoryDrop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "admin_add_table";
            this.Text = "admin_add_table";
            this.Load += new System.EventHandler(this.admin_add_table_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cafeSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeSystemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeSystemDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CafeSystemDataSet cafeSystemDataSet;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private CafeSystemDataSetTableAdapters.itemTableAdapter itemTableAdapter;
        private CafeSystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource cafeSystemDataSetBindingSource;
        private System.Windows.Forms.BindingSource itemBindingSource1;
        private System.Windows.Forms.BindingSource cartBindingSource;
        private CafeSystemDataSet1 cafeSystemDataSet1;
        private CafeSystemDataSet1TableAdapters.cartTableAdapter cartTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox categoryDrop;
        private System.Windows.Forms.Label label6;
    }
}