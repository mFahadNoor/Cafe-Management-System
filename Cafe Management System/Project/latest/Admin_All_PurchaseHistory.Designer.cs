namespace latest
{
    partial class Admin_All_PurchaseHistory
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
            this.label5 = new System.Windows.Forms.Label();
            this.cellsMain = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.cellsMain)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(384, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 32);
            this.label5.TabIndex = 39;
            this.label5.Text = "Purchase History";
            // 
            // cellsMain
            // 
            this.cellsMain.AllowUserToAddRows = false;
            this.cellsMain.AllowUserToDeleteRows = false;
            this.cellsMain.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cellsMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cellsMain.Location = new System.Drawing.Point(-1, 107);
            this.cellsMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cellsMain.Name = "cellsMain";
            this.cellsMain.ReadOnly = true;
            this.cellsMain.RowHeadersWidth = 62;
            this.cellsMain.RowTemplate.Height = 28;
            this.cellsMain.Size = new System.Drawing.Size(973, 497);
            this.cellsMain.TabIndex = 38;
            this.cellsMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellsMain_CellContentClick);
            // 
            // Admin_All_PurchaseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(971, 658);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cellsMain);
            this.Name = "Admin_All_PurchaseHistory";
            this.Text = "Admin_All_PurchaseHistory";
            ((System.ComponentModel.ISupportInitialize)(this.cellsMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView cellsMain;
    }
}