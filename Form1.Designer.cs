
namespace Lab06_Basic_Command
{
    partial class Form1
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
            this.lv_Category = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Load = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Type = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsm_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_ViewFood = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_Category
            // 
            this.lv_Category.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chName,
            this.chType});
            this.lv_Category.ContextMenuStrip = this.contextMenuStrip1;
            this.lv_Category.FullRowSelect = true;
            this.lv_Category.GridLines = true;
            this.lv_Category.HideSelection = false;
            this.lv_Category.Location = new System.Drawing.Point(12, 194);
            this.lv_Category.MultiSelect = false;
            this.lv_Category.Name = "lv_Category";
            this.lv_Category.Size = new System.Drawing.Size(777, 396);
            this.lv_Category.TabIndex = 0;
            this.lv_Category.UseCompatibleStateImageBehavior = false;
            this.lv_Category.View = System.Windows.Forms.View.Details;
            this.lv_Category.Click += new System.EventHandler(this.lv_Category_Click);
            // 
            // chID
            // 
            this.chID.Text = "Mã Loại";
            this.chID.Width = 80;
            // 
            // chName
            // 
            this.chName.Text = "Tên Loại Món Ăn";
            this.chName.Width = 300;
            // 
            // chType
            // 
            this.chType.Text = "Loại";
            this.chType.Width = 200;
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(12, 149);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(218, 30);
            this.btn_Load.TabIndex = 1;
            this.btn_Load.Text = "Lấy Danh Sách";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(420, 149);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(100, 30);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Enabled = false;
            this.btn_Update.Location = new System.Drawing.Point(555, 149);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(100, 30);
            this.btn_Update.TabIndex = 2;
            this.btn_Update.Text = "Cập Nhật";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Enabled = false;
            this.btn_Remove.Location = new System.Drawing.Point(689, 149);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(100, 30);
            this.btn_Remove.TabIndex = 2;
            this.btn_Remove.Text = "Xóa";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Nhóm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Nhóm Thức Ăn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Loại";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(207, 15);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(262, 22);
            this.txt_ID.TabIndex = 4;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(207, 52);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(262, 22);
            this.txt_Name.TabIndex = 4;
            // 
            // txt_Type
            // 
            this.txt_Type.Location = new System.Drawing.Point(207, 91);
            this.txt_Type.Name = "txt_Type";
            this.txt_Type.Size = new System.Drawing.Size(262, 22);
            this.txt_Type.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_Delete,
            this.tsm_ViewFood});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(275, 52);
            // 
            // tsm_Delete
            // 
            this.tsm_Delete.Name = "tsm_Delete";
            this.tsm_Delete.Size = new System.Drawing.Size(274, 24);
            this.tsm_Delete.Text = "Xóa nhóm sản phảm";
            this.tsm_Delete.Click += new System.EventHandler(this.tsm_Delete_Click);
            // 
            // tsm_ViewFood
            // 
            this.tsm_ViewFood.Name = "tsm_ViewFood";
            this.tsm_ViewFood.Size = new System.Drawing.Size(274, 24);
            this.tsm_ViewFood.Text = "Xem danh sách nhóm món ăn";
            this.tsm_ViewFood.Click += new System.EventHandler(this.tsm_ViewFood_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 600);
            this.Controls.Add(this.txt_Type);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.lv_Category);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_Category;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chType;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Type;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsm_Delete;
        private System.Windows.Forms.ToolStripMenuItem tsm_ViewFood;
    }
}

