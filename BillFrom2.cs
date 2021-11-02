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
    public partial class BillFrom2 : Form
    {
        private List<string> _list_date;
        public BillFrom2()
        {
            InitializeComponent();
        }
        public void LoadListBoDate(string TableID)
        {
            _list_date = new List<string>();
            string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string query = "SELECT CheckoutDate FROM Bill where TableID = '"+TableID+"'";
            sqlCommand.CommandText = query;
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                _list_date.Add(sqlDataReader["CheckoutDate"].ToString());
            }
            sqlConnection.Close();
            lb_date.DataSource = _list_date;
            this.Text = "Xem Danh Mục Hóa Đơn Bàn: " + TableID;
        }

        private void lb_date_Click(object sender, EventArgs e)
        {
            if (lb_date.SelectedItems.Count > 0)
            {
                string date = lb_date.SelectedItems[0].ToString();
                string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "Select b.ID, b.Name, b.Amount, b.Discount, b.Tax, b.Status," +
                    "b.Account, bd.FoodID, f.Name, f.Unit, f.FoodCategoryID, f.Price, f.Notes, bd.Quantily " +
                    " from Bill b, Food f, BillDetails bd where" +
                    " b.ID = bd.BillID and f.ID = bd.FoodID and Day(b.CheckoutDate) = Day('" + date + "') and Month(b.CheckoutDate)=" +
                    "Month('" + date + "') and Year(b.CheckoutDate) = Year('" + date + "')";
                sqlConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable("Details");
                da.Fill(dt);
                dgv_detail.DataSource = dt;
                sqlConnection.Close();
                sqlConnection.Dispose();
                da.Dispose();
            }
        }
    }
}
