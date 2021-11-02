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
using Lab06_Basic_Command.Model;

namespace Lab06_Basic_Command
{
    public partial class frmFood : Form
    {
        private int _category_id;
        List<Category> _list_category;
        public frmFood()
        {
            InitializeComponent();
        }

        public void LoadFood(int CategoryID)
        {
            this._category_id = CategoryID;
            string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string query = "Select Name from Category where ID = "+ CategoryID;
            sqlCommand.CommandText = query;
            sqlConnection.Open();
            string catName = sqlCommand.ExecuteScalar().ToString();
            this.Text = "Danh sách các món ăn thuộc nhóm: " + catName;
            sqlCommand.CommandText = "Select * from food where FoodCategoryID = " + CategoryID;
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable("Food");
            da.Fill(dt);
            dgv_Food.DataSource = dt;
            sqlConnection.Close();
            sqlConnection.Dispose();
            da.Dispose();

            dgv_Food.Columns[0].HeaderText = "ID";
            dgv_Food.Columns[1].HeaderText = "Tên món ăn";
            dgv_Food.Columns[2].HeaderText = "Đơn vị";
            dgv_Food.Columns[3].HeaderText = "Mã nhóm món ăn";
            dgv_Food.Columns[4].HeaderText = "Đơn giá";
            dgv_Food.Columns[5].HeaderText = "Mô tả";
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (dgv_Food.SelectedRows.Count > 0)
            {
                //this.Text = dgv_Food.SelectedRows[0].Cells[0].Value.ToString();
                string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "Delete from Billdetails where FoodID = " + dgv_Food.SelectedRows[0].Cells[0].Value.ToString();

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.CommandText = "Delete from Food where ID = " + dgv_Food.SelectedRows[0].Cells[0].Value.ToString();
                int num = sqlCommand.ExecuteNonQuery();
                if (num == 1)
                {
                    MessageBox.Show("Xóa thành công!");
                    dgv_Food.Rows.Remove(dgv_Food.SelectedRows[0]);
                    ResetControls();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!");
                }
            }
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string fc_id = _list_category.Find(s => s.Name == cbb_FoodCategoryID.Text).ID;
            if (txt_ID.Text == "")
            {
                sqlCommand.CommandText = "Insert into Food(Name, Unit, FoodCategoryID, [Price], Notes) values (N'"+
                    txt_Name.Text+"',N'"+txt_Unit.Text +"', '"+fc_id+"', "+txt_Price.Text+",N'"+txt_Notes.Text+"')";
                sqlConnection.Open();
                
                int num = sqlCommand.ExecuteNonQuery();
                if (num == 1)
                {
                    MessageBox.Show("Thêm món ăn thành công!");
                    LoadFood(_category_id);
                    ResetControls();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!");
                }
            }
            else if(txt_ID.Text != "")
            {
                sqlCommand.CommandText = "Update Food set Name = N'" +txt_Name.Text + "'," +
                    "Unit = N'"+txt_Unit.Text+"'," +
                    "FoodCategoryID = '"+fc_id+"', " +
                    "[Price] = "+txt_Price.Text+"," +
                    "Notes = N'"+txt_Notes.Text+"' where ID = '"+txt_ID.Text+"'";
                sqlConnection.Open();

                int num = sqlCommand.ExecuteNonQuery();
                if (num == 1)
                {
                    MessageBox.Show("Cập nhật món ăn thành công!");
                    LoadFood(_category_id);
                    ResetControls();
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công!");
                }
            }
        }

        private void ResetControls()
        {
            txt_ID.Text = "";
            txt_Name.Text = "";
            txt_Unit.Text = "";
            txt_Price.Text = "";
            txt_Notes.Text = "";
            cbb_FoodCategoryID.Text = "";
        }

        private void dgv_Food_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv_Food.SelectedRows.Count > 0)
            {
                txt_ID.Text = dgv_Food.SelectedRows[0].Cells[0].Value.ToString();
                txt_Name.Text = dgv_Food.SelectedRows[0].Cells[1].Value.ToString();
                txt_Unit.Text = dgv_Food.SelectedRows[0].Cells[2].Value.ToString();
                txt_Price.Text = dgv_Food.SelectedRows[0].Cells[4].Value.ToString();
                txt_Notes.Text = dgv_Food.SelectedRows[0].Cells[5].Value.ToString();
                cbb_FoodCategoryID.Text = _list_category.Find(s=>s.ID ==  dgv_Food.SelectedRows[0].Cells[3].Value.ToString()).ToString();
            }
            
        }

        private void frmFood_Load(object sender, EventArgs e)
        {
            string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string query = "SELECT ID, Name, Type FROM Category";
            sqlCommand.CommandText = query;
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DisplayFoodCategory(sqlDataReader);
            sqlConnection.Close();
            cbb_FoodCategoryID.Text = "";
        }
        private void DisplayFoodCategory(SqlDataReader reader)
        {
           _list_category = new List<Category>();
            while (reader.Read())
            {
                _list_category.Add(new Category(reader["ID"].ToString(), reader["Name"].ToString()));
            }
            cbb_FoodCategoryID.DataSource = _list_category;
            cbb_FoodCategoryID.DisplayMember = "Name";
            cbb_FoodCategoryID.ValueMember = "ID";
        }

        private void btn_clear_click(object sender, EventArgs e)
        {
            ResetControls();
        }
    }
}
