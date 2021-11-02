
namespace Lab06_Basic_Command
{
    partial class TableForm
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
            this.dgv_Tabels = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaBànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemDanhMụcHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemNhậtKýHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_Capacity = new System.Windows.Forms.TextBox();
            this.cbb_stt = new System.Windows.Forms.ComboBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_viewDetail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tabels)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Tabels
            // 
            this.dgv_Tabels.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Tabels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Tabels.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_Tabels.Location = new System.Drawing.Point(13, 152);
            this.dgv_Tabels.Name = "dgv_Tabels";
            this.dgv_Tabels.RowHeadersWidth = 51;
            this.dgv_Tabels.RowTemplate.Height = 24;
            this.dgv_Tabels.Size = new System.Drawing.Size(590, 454);
            this.dgv_Tabels.TabIndex = 0;
            this.dgv_Tabels.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Tabels_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaBànToolStripMenuItem,
            this.xemDanhMụcHóaĐơnToolStripMenuItem,
            this.xemNhậtKýHóaĐơnToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(244, 76);
            // 
            // xóaBànToolStripMenuItem
            // 
            this.xóaBànToolStripMenuItem.Name = "xóaBànToolStripMenuItem";
            this.xóaBànToolStripMenuItem.Size = new System.Drawing.Size(243, 24);
            this.xóaBànToolStripMenuItem.Text = "Xóa Bàn";
            this.xóaBànToolStripMenuItem.Click += new System.EventHandler(this.xóaBànToolStripMenuItem_Click);
            // 
            // xemDanhMụcHóaĐơnToolStripMenuItem
            // 
            this.xemDanhMụcHóaĐơnToolStripMenuItem.Name = "xemDanhMụcHóaĐơnToolStripMenuItem";
            this.xemDanhMụcHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(243, 24);
            this.xemDanhMụcHóaĐơnToolStripMenuItem.Text = "Xem Danh Mục Hóa Đơn";
            this.xemDanhMụcHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.xemDanhMụcHóaĐơnToolStripMenuItem_Click);
            // 
            // xemNhậtKýHóaĐơnToolStripMenuItem
            // 
            this.xemNhậtKýHóaĐơnToolStripMenuItem.Name = "xemNhậtKýHóaĐơnToolStripMenuItem";
            this.xemNhậtKýHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(243, 24);
            this.xemNhậtKýHóaĐơnToolStripMenuItem.Text = "Xem Nhật Ký Hóa Đơn";
            this.xemNhậtKýHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.xemNhậtKýHóaĐơnToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã bàn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên bàn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Trạng thái";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số chổ ngồi";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(103, 13);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(180, 22);
            this.txt_id.TabIndex = 2;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(103, 42);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(180, 22);
            this.txt_name.TabIndex = 3;
            // 
            // txt_Capacity
            // 
            this.txt_Capacity.Location = new System.Drawing.Point(103, 107);
            this.txt_Capacity.Name = "txt_Capacity";
            this.txt_Capacity.Size = new System.Drawing.Size(180, 22);
            this.txt_Capacity.TabIndex = 3;
            // 
            // cbb_stt
            // 
            this.cbb_stt.FormattingEnabled = true;
            this.cbb_stt.Items.AddRange(new object[] {
            "Trống",
            "Có Người"});
            this.cbb_stt.Location = new System.Drawing.Point(103, 76);
            this.cbb_stt.Name = "cbb_stt";
            this.cbb_stt.Size = new System.Drawing.Size(180, 24);
            this.cbb_stt.TabIndex = 4;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(503, 13);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(100, 30);
            this.btn_Clear.TabIndex = 5;
            this.btn_Clear.Text = "Xóa Trắng";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(503, 49);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(100, 30);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(503, 85);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(100, 30);
            this.btn_Remove.TabIndex = 5;
            this.btn_Remove.Text = "Xóa";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_viewDetail
            // 
            this.btn_viewDetail.Location = new System.Drawing.Point(302, 13);
            this.btn_viewDetail.Name = "btn_viewDetail";
            this.btn_viewDetail.Size = new System.Drawing.Size(185, 30);
            this.btn_viewDetail.TabIndex = 5;
            this.btn_viewDetail.Text = "Xem Danh Sách Hóa Đơn";
            this.btn_viewDetail.UseVisualStyleBackColor = true;
            this.btn_viewDetail.Click += new System.EventHandler(this.btn_viewDetail_Click);
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 618);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_viewDetail);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.cbb_stt);
            this.Controls.Add(this.txt_Capacity);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Tabels);
            this.Name = "TableForm";
            this.Text = "TableForm";
            this.Load += new System.EventHandler(this.TableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tabels)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Tabels;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_Capacity;
        private System.Windows.Forms.ComboBox cbb_stt;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_viewDetail;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xóaBànToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemDanhMụcHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemNhậtKýHóaĐơnToolStripMenuItem;
    }
}