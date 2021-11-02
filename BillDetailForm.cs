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
    public partial class BillDetailForm : Form
    {
        public BillDetailForm()
        {
            InitializeComponent();
        }

        private void BillDetailForm_Load(object sender, EventArgs e)
        {

        }
        public void LoadBillDetails(string BillID)
        {
            string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string query = "Select * from BillDetails where BillID = " + BillID;
            sqlCommand.CommandText = query;
            sqlConnection.Open();
            
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable("BillDetails");
            da.Fill(dt);
            dgv_BillDetail.DataSource = dt;
            sqlConnection.Close();
            sqlConnection.Dispose();
            da.Dispose();

            dgv_BillDetail.Columns[0].HeaderText = "Mã số";
            dgv_BillDetail.Columns[1].HeaderText = "Mã số hóa đơn";
            dgv_BillDetail.Columns[2].HeaderText = "Mã số món ăn";
            dgv_BillDetail.Columns[3].HeaderText = "Số lượng";
        }
    }
}
