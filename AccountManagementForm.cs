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
    public partial class AccountManagementForm : Form
    {
        private List<Role> _list_roles;
        public AccountManagementForm()
        {
            InitializeComponent();
        }

        private void AccountManagementForm_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadRoleAccountToCbb();
        }
        private void LoadRoleAccountToCbb()
        {
            string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string query = "select * from Role";
            sqlCommand.CommandText = query;
            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            _list_roles = new List<Role>();
            while (sqlDataReader.Read())
            {
                _list_roles.Add(new Role(sqlDataReader["ID"].ToString(), sqlDataReader["RoleName"].ToString()));
            }
            cbb_Group.DataSource = _list_roles;
            cbb_Group.DisplayMember = "RoleName";
            cbb_Group.ValueMember = "ID";
            cbb_Group.Text = "";
            cbb_role.DataSource = _list_roles;
            cbb_role.DisplayMember = "RoleName";
            cbb_role.ValueMember = "ID";
            cbb_role.Text = "";
        }
        private void LoadData()
        {
            string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string query = "select a.AccoutName, a.Password, a.FullName, a.Email, a.Tell, a.DateCreated, r.RoleName, ra.Actived " +
                "from Role r, Account a, RoleAccount ra " +
                "where r.ID=ra.RoleID and ra.AccountName = a.AccoutName";
            sqlCommand.CommandText = query;
            sqlConnection.Open();

            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable("Accounts");
            da.Fill(dt);
            dgv_Accounts.DataSource = dt;
            sqlConnection.Close();
            sqlConnection.Dispose();
            da.Dispose();

            SetHeaderTextGDV();
        }
        private void SetHeaderTextGDV()
        {
            dgv_Accounts.Columns[0].HeaderText = "Tên tài khoản";
            dgv_Accounts.Columns[1].HeaderText = "Mật khẩu";
            dgv_Accounts.Columns[2].HeaderText = "Tên đầy đủ";
            dgv_Accounts.Columns[3].HeaderText = "Email";
            dgv_Accounts.Columns[4].HeaderText = "Số điện thoại";
            dgv_Accounts.Columns[5].HeaderText = "Ngày tạo tài khoản";
            dgv_Accounts.Columns[6].HeaderText = "Quyền";
            dgv_Accounts.Columns[7].HeaderText = "Trạng thái";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string query = "";

            string status ="";//= cbb_Status.Text == "Actived" ? "1" : "0";
            string role_id ="";// = _list_roles.Find(s => s.RoleName == cbb_Group.Text).ID;

            if(cbb_Group.Text !="" && cbb_Status.Text != "")
            {
                status = cbb_Status.Text == "Actived" ? "1" : "0";
                role_id = _list_roles.Find(s => s.RoleName == cbb_Group.Text).ID;

                query = "select a.AccoutName, a.Password, a.FullName, a.Email, a.Tell, a.DateCreated, r.RoleName, ra.Actived " +
                "from Role r, Account a, RoleAccount ra " +
                "where r.ID=ra.RoleID and ra.AccountName = a.AccoutName and " +
                "ra.Actived = '" + status + "' and r.ID ='" + role_id + "'";
            }
            else if (cbb_Group.Text == "" && cbb_Status.Text!="")
            {
                status = cbb_Status.Text == "Actived" ? "1" : "0";
                query = "select a.AccoutName, a.Password, a.FullName, a.Email, a.Tell, a.DateCreated, r.RoleName, ra.Actived " +
                "from Role r, Account a, RoleAccount ra " +
                "where r.ID=ra.RoleID and ra.AccountName = a.AccoutName and " +
                "ra.Actived = '" + status+"'";
            }
            else if (cbb_Group.Text !="" && cbb_Status.Text == "")
            {
                role_id = _list_roles.Find(s => s.RoleName == cbb_Group.Text).ID;
                query = "select a.AccoutName, a.Password, a.FullName, a.Email, a.Tell, a.DateCreated, r.RoleName, ra.Actived " +
                "from Role r, Account a, RoleAccount ra " +
                "where r.ID=ra.RoleID and ra.AccountName = a.AccoutName and " +
                " r.ID ='" + role_id + "'";
            }
            else
            {
                query = "select a.AccoutName, a.Password, a.FullName, a.Email, a.Tell, a.DateCreated, r.RoleName, ra.Actived " +
                "from Role r, Account a, RoleAccount ra " +
                "where r.ID=ra.RoleID and ra.AccountName = a.AccoutName";
            }
            sqlCommand.CommandText = query;
            sqlConnection.Open();

            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable("Accounts");
            da.Fill(dt);
            dgv_Accounts.DataSource = dt;
            
            sqlConnection.Close();
            sqlConnection.Dispose();
            da.Dispose();
            SetHeaderTextGDV();
        }

        private void dgv_Accounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Accounts.SelectedRows.Count > 0)
            {
                txt_account_name.Text = dgv_Accounts.SelectedRows[0].Cells[0].Value.ToString();
                txt_password.Text = dgv_Accounts.SelectedRows[0].Cells[1].Value.ToString();
                txt_fullname.Text = dgv_Accounts.SelectedRows[0].Cells[2].Value.ToString();
                txt_email.Text = dgv_Accounts.SelectedRows[0].Cells[3].Value.ToString();
                txt_tell.Text = dgv_Accounts.SelectedRows[0].Cells[4].Value.ToString();
                if (dgv_Accounts.SelectedRows[0].Cells[5].Value.ToString() != "")
                    dtp_create_Date.Value = DateTime.Parse(dgv_Accounts.SelectedRows[0].Cells[5].Value.ToString());
                else dtp_create_Date.Value = DateTime.Now;
                cbb_role.Text = dgv_Accounts.SelectedRows[0].Cells[6].Value.ToString();
                cbb_stt.Text = dgv_Accounts.SelectedRows[0].Cells[7].Value.ToString()=="True"?"Actived": "Nonactived";
            }
        }

        private void btn_Clear_click(object sender, EventArgs e)
        {
            ResetControls();
        }
        private void ResetControls()
        {
            txt_account_name.Text = "";
            txt_fullname.Text = "";
            txt_password.Text = "";
            txt_email.Text = "";
            txt_tell.Text = "";
            cbb_role.Text = "";
            cbb_stt.Text = "";
            dtp_create_Date.Value = DateTime.Now;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string role_id = _list_roles.Find(s => s.RoleName == cbb_role.Text).ID;
            string stt = cbb_stt.Text == "Actived" ? "1" : "0";

            sqlCommand.CommandText = "select * from Account where AccoutName = '" + txt_account_name.Text + "'";
            sqlConnection.Open();

            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable("Accounts");
            da.Fill(dt);
            if(dt.Rows.Count <= 0)
            {
                sqlCommand.CommandText = "insert into Account(AccoutName, Password, FullName, Email, Tell, DateCreated) values " +
                   "(N'" + txt_account_name.Text + "', N'" + txt_password.Text + "', N'" + txt_fullname.Text + "', N'" + txt_email.Text + "'," +
                   "'" + txt_tell.Text + "', '" + dtp_create_Date.Value.Date.ToString() + "')";
                sqlCommand.ExecuteNonQuery();
                sqlCommand.CommandText = "insert into RoleAccount(RoleID, AccountName, Actived) values " +
                    "('" + role_id + "', N'" + txt_account_name.Text + "', '" + stt + "')";
                int num = sqlCommand.ExecuteNonQuery();
                if (num == 1)
                {
                    MessageBox.Show("Thêm tài khoản thành công!");
                    LoadData();
                    ResetControls();
                }
                else
                {
                    MessageBox.Show("Thêm tài khoản không thành công!");
                }
                
            }
            else
            {
                sqlCommand.CommandText = "Update Account set Password = N'" + txt_password.Text + "', FullName = N'" + txt_fullname.Text + "', " +
                    "Email = '" + txt_email.Text + "', Tell = '" + txt_tell.Text + "', DateCreated='" + dtp_create_Date.Value.Date.ToString() + "' " +
                    "where AccoutName = '" + txt_account_name.Text + "'";
                sqlCommand.ExecuteNonQuery();
                sqlCommand.CommandText = "Update RoleAccount set Actived = '"+stt+"' where RoleID = '"+role_id+"' and AccountName = '"+txt_account_name.Text+"'";
                int num2 = sqlCommand.ExecuteNonQuery();
                if (num2 == 1)
                {
                    MessageBox.Show("Cập nhật tài khoản không thành công!");
                    LoadData();
                    ResetControls();
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin không thành công!");
                }

            }



        }

        private void tsm_Remove_Click(object sender, EventArgs e)
        {
            if (dgv_Accounts.SelectedRows.Count > 0)
            {
                string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                SqlCommand sqlCommand = sqlConnection.CreateCommand();

                string roleID = _list_roles.Find(s => s.RoleName == dgv_Accounts.SelectedRows[0].Cells[6].Value.ToString()).ID;

                sqlCommand.CommandText = "Update RoleAccount set Actived = 'false' where AccountName = '" + txt_account_name.Text + "' and RoleID = '" + roleID + "'";
                sqlConnection.Open();
                //sqlCommand.ExecuteNonQuery();
                //sqlCommand.CommandText = "Delete from Account where AccoutName ='"+txt_account_name.Text+"'";
               int num =   sqlCommand.ExecuteNonQuery();
                if(num == 1)
                {
                    MessageBox.Show("Xóa tài khoản thành công!");
                    LoadData();
                    ResetControls();
                }
                else
                {
                    MessageBox.Show("Xóa tài khoản không thành công!");
                }
            }
        }

        private void tsm_viewDetail_Click(object sender, EventArgs e)
        {
            RoleAccountForm roleAccountForm = new RoleAccountForm();
            roleAccountForm.Show();
            roleAccountForm.LoadData(txt_account_name.Text);
        }

        private void btn_Change_Pasword_Click(object sender, EventArgs e)
        {
            ChangePwForm changePwForm = new ChangePwForm(txt_account_name.Text, txt_password.Text);
            changePwForm.Show();
            button1.PerformClick();
        }
    }
}
