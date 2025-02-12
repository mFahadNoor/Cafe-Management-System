using System;

namespace latest
{
    partial class UserHome
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
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cafeSystemDataSet = new latest.CafeSystemDataSet();
            this.itemTableAdapter = new latest.CafeSystemDataSetTableAdapters.itemTableAdapter();
            this.cartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cafeSystemDataSet1 = new latest.CafeSystemDataSet1();
            this.cartTableAdapter = new latest.CafeSystemDataSet1TableAdapters.cartTableAdapter();
            this.manageButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.browsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.historyButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.checkButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeSystemDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "item";
            this.itemBindingSource.DataSource = this.cafeSystemDataSet;
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
            // manageButton
            // 
            this.manageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageButton.Location = new System.Drawing.Point(244, 163);
            this.manageButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.manageButton.Name = "manageButton";
            this.manageButton.Size = new System.Drawing.Size(436, 40);
            this.manageButton.TabIndex = 0;
            this.manageButton.Text = "Manage Cart";
            this.manageButton.UseVisualStyleBackColor = true;
            this.manageButton.Click += new System.EventHandler(this.manageButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(59, 357);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(144, 48);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logout);
            // 
            // browsButton
            // 
            this.browsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browsButton.Location = new System.Drawing.Point(244, 111);
            this.browsButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.browsButton.Name = "browsButton";
            this.browsButton.Size = new System.Drawing.Size(436, 40);
            this.browsButton.TabIndex = 5;
            this.browsButton.Text = "Browse Items";
            this.browsButton.UseVisualStyleBackColor = true;
            this.browsButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 52);
            this.label1.TabIndex = 6;
            this.label1.Text = "Welcome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // historyButton
            // 
            this.historyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyButton.Location = new System.Drawing.Point(244, 215);
            this.historyButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(436, 40);
            this.historyButton.TabIndex = 0;
            this.historyButton.Text = "View History";
            this.historyButton.UseVisualStyleBackColor = true;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.Location = new System.Drawing.Point(244, 267);
            this.editButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(436, 40);
            this.editButton.TabIndex = 0;
            this.editButton.Text = "Edit Account";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // checkButton
            // 
            this.checkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkButton.Location = new System.Drawing.Point(571, 347);
            this.checkButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(321, 48);
            this.checkButton.TabIndex = 4;
            this.checkButton.Text = "Proceed to Checkout";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // UserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(927, 410);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.browsButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.manageButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "UserHome";
            this.Text = "UserHome";
            this.Load += new System.EventHandler(this.UserHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeSystemDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private CafeSystemDataSet cafeSystemDataSet;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private CafeSystemDataSetTableAdapters.itemTableAdapter itemTableAdapter;
        private CafeSystemDataSet1 cafeSystemDataSet1;
        private System.Windows.Forms.BindingSource cartBindingSource;
        private CafeSystemDataSet1TableAdapters.cartTableAdapter cartTableAdapter;
        private System.Windows.Forms.Button manageButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button browsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button checkButton;
    }
}