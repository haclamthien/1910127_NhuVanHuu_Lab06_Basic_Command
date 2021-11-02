
namespace Lab06_Basic_Command
{
    partial class AdminForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsm_category_management = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_dinningtable_management = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_bill_management = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_account_management = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_category_management,
            this.tsm_dinningtable_management,
            this.tsm_bill_management,
            this.tsm_account_management});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsm_category_management
            // 
            this.tsm_category_management.Name = "tsm_category_management";
            this.tsm_category_management.Size = new System.Drawing.Size(168, 24);
            this.tsm_category_management.Text = "Quản lý nhóm thức ăn";
            this.tsm_category_management.Click += new System.EventHandler(this.tsm_category_management_Click);
            // 
            // tsm_dinningtable_management
            // 
            this.tsm_dinningtable_management.Name = "tsm_dinningtable_management";
            this.tsm_dinningtable_management.Size = new System.Drawing.Size(122, 24);
            this.tsm_dinningtable_management.Text = "Quản lý bàn ăn";
            this.tsm_dinningtable_management.Click += new System.EventHandler(this.tsm_dinningtable_management_Click);
            // 
            // tsm_bill_management
            // 
            this.tsm_bill_management.Name = "tsm_bill_management";
            this.tsm_bill_management.Size = new System.Drawing.Size(132, 24);
            this.tsm_bill_management.Text = "Quản lý hóa đơn";
            this.tsm_bill_management.Click += new System.EventHandler(this.tsm_bill_management_Click);
            // 
            // tsm_account_management
            // 
            this.tsm_account_management.Name = "tsm_account_management";
            this.tsm_account_management.Size = new System.Drawing.Size(138, 24);
            this.tsm_account_management.Text = "Quản lý tài khoản";
            this.tsm_account_management.Click += new System.EventHandler(this.tsm_account_management_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsm_category_management;
        private System.Windows.Forms.ToolStripMenuItem tsm_dinningtable_management;
        private System.Windows.Forms.ToolStripMenuItem tsm_bill_management;
        private System.Windows.Forms.ToolStripMenuItem tsm_account_management;
    }
}