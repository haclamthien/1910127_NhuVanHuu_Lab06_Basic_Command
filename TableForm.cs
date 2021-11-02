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
    public partial class TableForm : Form
    {
        public TableForm()
        {
            InitializeComponent();
        }

        private void TableForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            sqlCommand.CommandText = "select * from DiningTable";
            sqlConnection.Open();

            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable("Tables");
            da.Fill(dt);
            dgv_Tabels.DataSource = dt;
            sqlConnection.Close();
            sqlConnection.Dispose();
            da.Dispose();

            dgv_Tabels.Columns[0].HeaderText = "Mã bàn";
            dgv_Tabels.Columns[1].HeaderText = "Tên bàn";
            dgv_Tabels.Columns[2].HeaderText = "Trạng thái";
            dgv_Tabels.Columns[3].HeaderText = "Số chổ ngồi";


        }
        private void dgv_Tabels_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv_Tabels.SelectedRows.Count > 0)
            {
                txt_id.Text = dgv_Tabels.SelectedRows[0].Cells[0].Value.ToString();
                txt_name.Text = dgv_Tabels.SelectedRows[0].Cells[1].Value.ToString();
                txt_Capacity.Text = dgv_Tabels.SelectedRows[0].Cells[3].Value.ToString();
                cbb_stt.Text = dgv_Tabels.SelectedRows[0].Cells[2].Value.ToString() == "0"? "Trống":"Có Người";
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ResetControlls();
        }
        private void ResetControlls()
        {
            txt_id.Text = "";
            txt_name.Text = "";
            txt_Capacity.Text = "";
            cbb_stt.Text = "";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            string stt = cbb_stt.Text == "Trống" ? "0" : "1";
            string query = "";
            if (txt_id.Text == "")
            {
                query = "Insert into DiningTable(Name, Status, Capacity) values " +
                    "(N'"+txt_name.Text+"', '"+stt+"', '"+txt_Capacity.Text+"')";
                sqlCommand.CommandText = query;
                sqlConnection.Open();
                int num = sqlCommand.ExecuteNonQuery();
                if (num == 1)
                {
                    MessageBox.Show("Thêm bàn ăn thành công");
                    ResetControlls();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Thêm bàn ăn không thành công");
                }

            }
            else
            {
                query = "Update DiningTable set Name = N'" + txt_name.Text + "', Status = '" + stt + "', Capacity = '" + txt_Capacity.Text + "'" +
                    "where ID = '" + txt_id.Text + "'";
                sqlCommand.CommandText = query;
                sqlConnection.Open();
                int num = sqlCommand.ExecuteNonQuery();
                if (num == 1)
                {
                    MessageBox.Show("Cập nhật bàn ăn thành công");
                    ResetControlls();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Cập nhật bàn ăn không thành công");
                }
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (dgv_Tabels.SelectedRows.Count > 0)
            {
                string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "Delete from DiningTable where ID = '" + txt_id.Text + "'";
                sqlConnection.Open();
                int num = sqlCommand.ExecuteNonQuery();
                if (num == 1)
                {
                    MessageBox.Show("Xóa bàn ăn thành công");
                    ResetControlls();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Xóa bàn ăn không thành công");
                }
            }
        }

        private void btn_viewDetail_Click(object sender, EventArgs e)
        {
            if (dgv_Tabels.SelectedRows.Count > 0)
            {
                BillForm billForm = new BillForm(txt_id.Text);
                billForm.Show();
            }
        }

        private void xóaBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_Remove.PerformClick();
        }

        private void xemDanhMụcHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dgv_Tabels.SelectedRows.Count > 0)
            {
                BillFrom2 billFrom2 = new BillFrom2();
                billFrom2.Show();
                billFrom2.LoadListBoDate(txt_id.Text);
            }
        }

        private void xemNhậtKýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_Tabels.SelectedRows.Count > 0)
            {
                BillCatalogs billCatalogs = new BillCatalogs();
                billCatalogs.Show();
                billCatalogs.LoadData(txt_id.Text);
            }
        }
    }
}
