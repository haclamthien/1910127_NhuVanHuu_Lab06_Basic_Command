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
    public partial class BillForm : Form
    {
        public BillForm()
        {
            InitializeComponent();
        }
        public BillForm(string tableID)
        {
            InitializeComponent();
            string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string query = "SELECT * from Bill where TableID ='" + tableID + "' " +
                "and Day(CheckoutDate) = Day(GetDate()) and Month(CheckoutDate) = Month(GetDate()) and Year(CheckoutDate)= Year(GetDate())";
            sqlConnection.Open();
            sqlCommand.CommandText = query;
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DislayBill(sqlDataReader);
            sqlConnection.Close();
        }


        private void btn_Load_Click(object sender, EventArgs e)
        {
            //this.Text = dtp_start.Value.Date.ToString();
            string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string query = "SELECT * from Bill where CheckoutDate >= '"+dtp_start.Value.Date.ToString()+ "' and CheckoutDate <= '"
                +dtp_end.Value.Date.ToString()+"'";
            sqlCommand.CommandText = "set dateFormat mdy";
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlCommand.CommandText = query;
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DislayBill(sqlDataReader);
            sqlConnection.Close();
        }

        private void DislayBill(SqlDataReader sqlDataReader)
        {
            lv_Bills.Items.Clear();
            while (sqlDataReader.Read())
            {
                ListViewItem item = new ListViewItem(sqlDataReader["ID"].ToString());
                item.SubItems.Add(sqlDataReader["Name"].ToString());
                item.SubItems.Add(sqlDataReader["TableID"].ToString());
                item.SubItems.Add(sqlDataReader["Amount"].ToString());
                item.SubItems.Add(sqlDataReader["Discount"].ToString());
                item.SubItems.Add(sqlDataReader["Status"].ToString());
                item.SubItems.Add(sqlDataReader["CheckoutDate"].ToString());
                item.SubItems.Add(sqlDataReader["Account"].ToString());
                item.SubItems.Add(sqlDataReader["Tax"].ToString());
                lv_Bills.Items.Add(item);
            }
        }

        private void lv_Bills_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            BillDetailForm billDetailForm = new BillDetailForm();
            billDetailForm.Show();
            billDetailForm.LoadBillDetails(lv_Bills.SelectedItems[0].SubItems[0].Text);
        }
    }
}
