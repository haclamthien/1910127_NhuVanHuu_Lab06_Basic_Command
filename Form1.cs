using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06_Basic_Command
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string query = "SELECT ID, Name, Type FROM Category";
            sqlCommand.CommandText = query;
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DislayCategory(sqlDataReader);
            sqlConnection.Close();
        }
        private void DislayCategory(SqlDataReader reader)
        {
            lv_Category.Items.Clear();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["ID"].ToString());
                lv_Category.Items.Add(item);
                item.SubItems.Add(reader["Name"].ToString());
                item.SubItems.Add(reader["Type"].ToString());
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string query = "INSERT INTO Category(Name, [Type]) Values (N'"+txt_Name.Text+"', "+txt_Type.Text+")";
            sqlCommand.CommandText = query;
            sqlConnection.Open();
            int num = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (num == 1)
            {
                MessageBox.Show("Thêm món ăn thành công!");
                btn_Load.PerformClick();
                txt_Name.Text = "";
                txt_Type.Text = "";
            }
            else
            {
                MessageBox.Show("Thêm món ăn không thành công!");
            }
        }

        private void lv_Category_Click(object sender, EventArgs e)
        {
            ListViewItem item = lv_Category.SelectedItems[0];
            txt_ID.Text = item.SubItems[0].Text;
            txt_Name.Text = item.SubItems[1].Text;
            txt_Type.Text = item.SubItems[2].Text == "1" ? "Thức ăn" : "Đồ uống";
            btn_Remove.Enabled = true;
            btn_Update.Enabled = true;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string type = txt_Type.Text == "Thức ăn" ? "1" : "0";
            string query = "Update Category set Name = N'"+txt_Name.Text+"', "+
               " [Type] =" + type + " where ID = "+txt_ID.Text;
            sqlCommand.CommandText = query;
            sqlConnection.Open();
            int num = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (num == 1)
            {
                ListViewItem item = lv_Category.SelectedItems[0];
                item.SubItems[1].Text = txt_Name.Text;
                item.SubItems[2].Text = type;
                MessageBox.Show("Cập nhật món ăn thành công!");
                txt_Name.Text = "";
                txt_Type.Text = "";
                txt_ID.Text = "";
            }
            else
            {
                MessageBox.Show("Thêm món ăn không thành công!");
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                string query = "Delete from Category where id = " + txt_ID.Text;
                sqlCommand.CommandText = query;
                sqlConnection.Open();
                int num = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                if (num == 1)
                {
                    MessageBox.Show("Xóa món ăn thành công!");
                    ListViewItem item = lv_Category.SelectedItems[0];
                    lv_Category.Items.Remove(item);
                    txt_Name.Text = "";
                    txt_Type.Text = "";
                    txt_ID.Text = "";
                    btn_Remove.Enabled = false;
                    btn_Update.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Thêm món ăn không thành công!");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Không thể xóa nhóm món ăn.", "Thông báo");
            }
            
        }

        private void tsm_Delete_Click(object sender, EventArgs e)
        {
            if (lv_Category.SelectedItems.Count > 0)
                btn_Remove.PerformClick();
        }

        private void tsm_ViewFood_Click(object sender, EventArgs e)
        {
            if(txt_ID.Text != "")
            {
                frmFood frmFood = new frmFood();
                frmFood.Show(this);
                frmFood.LoadFood(int.Parse(txt_ID.Text));
            }
        }
    }
}
