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

namespace CS311_MD_2022
{
    public partial class frmAcct : Form
    {
        private string username;
        public static frmAcct dgvRefresh;
        public frmAcct(string username)
        {
            InitializeComponent();
            this.username = username;
            dgvRefresh = this;
        }
        Class1 acct = new Class1("CHUA-ZYYY", "CS311-2022", "user-z", "1234");
        private void frmAcct_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = acct.GetData("SELECT Username, Password, Usertype, Status, CreatedBy FROM tbleaccts WHERE username <> '" + username + "' ORDER BY userName");
                dataGridView1.DataSource = dt;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error on accounts load", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = acct.GetData("SELECT userName, password, userType, status, createdBy FROM tbleaccts WHERE username <> '" + username + "'AND (userName LIKE '%" +
                    txtsearch.Text + "%' OR userType LIKE '%" + txtsearch.Text + "%') ORDER BY userName");
                dataGridView1.DataSource = dt;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error on accounts load", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            frmNewAcct newAcct = new frmNewAcct(username);
            newAcct.Show();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string updateUsername, updatePassword, updateUsertype, updateStatus;
            updateUsername = dataGridView1.Rows[rowSelected].Cells[0].Value.ToString();
            updatePassword = dataGridView1.Rows[rowSelected].Cells[1].Value.ToString();
            updateUsertype = dataGridView1.Rows[rowSelected].Cells[2].Value.ToString();
            updateStatus = dataGridView1.Rows[rowSelected].Cells[3].Value.ToString();
            frmUpdateAcct updateAcct = new frmUpdateAcct(updateUsername, updatePassword, updateUsertype, updateStatus, username);
            updateAcct.Show();
        }
        private int rowSelected;

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            rowSelected = dataGridView1.CurrentCell.RowIndex;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult ans = MessageBox.Show("Are you sure you want to delete this data?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ans == DialogResult.Yes)
                {
                    acct.executeSQL("DELETE FROM tbleaccts WHERE userName = '" + dataGridView1.Rows[rowSelected].Cells[0].Value.ToString() + "'");
                    if (acct.rowAffected > 0)
                    {
                        MessageBox.Show("Account Deleted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        acct.executeSQL("INSERT INTO tbleDeletedLogs VALUES ('" + DateTime.Now.ToString("dd-MM-yyyy") + "', '" + DateTime.Now.ToLongTimeString() + 
                            "', 'Accounts Management', '" + dataGridView1.Rows[rowSelected].Cells[0].Value.ToString() + "', '" + username + "')");
                        dgvRefresh.btnrefresh_Click(sender, e);
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error on delete button", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void btnrefresh_Click(object sender, EventArgs e)
        {
            frmAcct_Load(sender, e);
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 1 && e.Value !=null)
            {
                e.Value = new String('#', e.Value.ToString().Length);
            }
        }
    }
}
