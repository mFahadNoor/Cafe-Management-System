namespace latest
{
    partial class Admin_View_all_items
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
            this.label5.Location = new System.Drawing.Point(420, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 32);
            this.label5.TabIndex = 31;
            this.label5.Text = "All Items";
            // 
            // cellsMain
            // 
            this.cellsMain.AllowUserToAddRows = false;
            this.cellsMain.AllowUserToDeleteRows = false;
            this.cellsMain.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cellsMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cellsMain.Location = new System.Drawing.Point(12, 91);
            this.cellsMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cellsMain.Name = "cellsMain";
            this.cellsMain.ReadOnly = true;
            this.cellsMain.RowHeadersWidth = 62;
            this.cellsMain.RowTemplate.Height = 28;
            this.cellsMain.Size = new System.Drawing.Size(973, 497);
            this.cellsMain.TabIndex = 32;
            this.cellsMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellsMain_CellContentClick);
            // 
            // Admin_View_all_items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(985, 659);
            this.Controls.Add(this.cellsMain);
            this.Controls.Add(this.label5);
            this.Name = "Admin_View_all_items";
            this.Text = "Admin_View_all_tables";
            this.Load += new System.EventHandler(this.Admin_View_all_tables_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cellsMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView cellsMain;
    }
}