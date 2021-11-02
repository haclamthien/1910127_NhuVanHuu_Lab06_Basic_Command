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
    public partial class BillCatalogs : Form
    {
        public BillCatalogs()
        {
            InitializeComponent();
        }
        public void LoadData(string tableID)
        {
            string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "select COUNT(ID) as SoHoaDon ,  SUM(Amount) as TongAmount, Sum(Amount*Discount) as TongDiscount, Sum(Tax*Amount) as TongTax " +
                "from Bill where TableID = '"+tableID+"' " +
                "Group by TableID";
            sqlConnection.Open();
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable("Details");
            da.Fill(dt);
            dgv_BillCatalogs.DataSource = dt;
            sqlConnection.Close();
            sqlConnection.Dispose();
            da.Dispose();
            this.Text = "Nhật Ký Hóa Đơn Bàn: " + tableID;
        }
    }
}
