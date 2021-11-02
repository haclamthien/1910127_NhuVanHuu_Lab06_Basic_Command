
namespace Lab06_Basic_Command
{
    partial class BillCatalogs
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
            this.dgv_BillCatalogs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BillCatalogs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_BillCatalogs
            // 
            this.dgv_BillCatalogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_BillCatalogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BillCatalogs.Location = new System.Drawing.Point(13, 13);
            this.dgv_BillCatalogs.Name = "dgv_BillCatalogs";
            this.dgv_BillCatalogs.RowHeadersWidth = 51;
            this.dgv_BillCatalogs.RowTemplate.Height = 24;
            this.dgv_BillCatalogs.Size = new System.Drawing.Size(593, 425);
            this.dgv_BillCatalogs.TabIndex = 0;
            // 
            // BillCatalogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 450);
            this.Controls.Add(this.dgv_BillCatalogs);
            this.Name = "BillCatalogs";
            this.Text = "BillCatalogs";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BillCatalogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_BillCatalogs;
    }
}