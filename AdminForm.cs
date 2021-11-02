using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06_Basic_Command
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void tsm_category_management_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void tsm_dinningtable_management_Click(object sender, EventArgs e)
        {
            TableForm tableForm = new TableForm();
            tableForm.Show();
        }

        private void tsm_bill_management_Click(object sender, EventArgs e)
        {
            BillForm billForm = new BillForm();
            billForm.Show();
        }

        private void tsm_account_management_Click(object sender, EventArgs e)
        {
            AccountManagementForm accountManagementForm = new AccountManagementForm();
            accountManagementForm.Show();
        }
    }
}
