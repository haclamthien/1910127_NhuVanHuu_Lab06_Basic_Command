
namespace Lab06_Basic_Command
{
    partial class BillFrom2
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
            this.lb_date = new System.Windows.Forms.ListBox();
            this.dgv_detail = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detail)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_date
            // 
            this.lb_date.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_date.FormattingEnabled = true;
            this.lb_date.ItemHeight = 16;
            this.lb_date.Location = new System.Drawing.Point(13, 13);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(212, 484);
            this.lb_date.TabIndex = 0;
            this.lb_date.Click += new System.EventHandler(this.lb_date_Click);
            // 
            // dgv_detail
            // 
            this.dgv_detail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detail.Location = new System.Drawing.Point(232, 13);
            this.dgv_detail.Name = "dgv_detail";
            this.dgv_detail.RowHeadersWidth = 51;
            this.dgv_detail.RowTemplate.Height = 24;
            this.dgv_detail.Size = new System.Drawing.Size(1115, 484);
            this.dgv_detail.TabIndex = 1;
            // 
            // BillFrom2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 503);
            this.Controls.Add(this.dgv_detail);
            this.Controls.Add(this.lb_date);
            this.Name = "BillFrom2";
            this.Text = "Danh Mục Hóa Đơn";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_date;
        private System.Windows.Forms.DataGridView dgv_detail;
    }
}