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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CS311_MD_2022
{
    public partial class frmNewAcct : Form
    {
        private string createdBy;
        public frmNewAcct(string createdBy)
        {
            InitializeComponent();
            this.createdBy = createdBy;
        }
        Class1 newAcct = new Class1("CHUA-ZYYY", "CS311-2022", "user-z", "1234");
        private int errorCount;
        public void countErrors()
        {
            errorCount = 0;
            foreach (Control c in errorProvider1.ContainerControl.Controls)
            {
                if (errorProvider1.GetError(c) != "")
                {
                    errorCount++;
                }
            }
        }
        private void validateUsername()
        {
            DataTable dt = newAcct.GetData("SELECT * FROM tbleaccts WHERE userName = '" + txtusername.Text + "'");
            if (txtusername.Text == "")
            {
                errorProvider1.SetError(txtusername, "Username is empty!");
            }
            else if (txtusername.TextLength < 4)
            {
                errorProvider1.SetError(txtusername, "Username should be at least 4 characters");
            }
            else if (dt.Rows.Count > 0)
            {
                errorProvider1.SetError(txtusername, "Username is already existing");
            }
            else
            {
                errorProvider1.SetError(txtusername, "");
            }
        }
        private void validatePassword()
        {
            if (txtpassword.Text == "")
            {
                errorProvider1.SetError(txtpassword, "Password is empty!");
            }
            else if (txtpassword.TextLength < 4)
            {
                errorProvider1.SetError(txtpassword, "Password should be at least 4 characters");
            }
            else
            {
                errorProvider1.SetError(txtpassword, "");
            }
        }
        private void validateUsertype()
        {
            if (cmbusertype.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbusertype, "Select usertype");
            }
            else
            {
                errorProvider1.SetError(cmbusertype, "");
            }
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            if (chkshow.Checked)
            {
                txtpassword.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '*';
            }
        }

        private void chkshow_CheckedChanged(object sender, EventArgs e)
        {
            txtpassword_TextChanged(sender, e);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            validateUsername();
            validatePassword();
            validateUsertype();
            countErrors();
            if (errorCount == 0)
            {
                try
                {
                    DialogResult ans = MessageBox.Show("Are you sure you want to save this data?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ans == DialogResult.Yes)
                    {
                        newAcct.executeSQL("INSERT INTO tbleaccts (userName, password, userType, status, createdBy, dateCreated) VALUES ('" + txtusername.Text +
                        "', '" + txtpassword.Text + "', '" + cmbusertype.Text.ToUpper() + "', 'ACTIVE', '" + createdBy + "', '" + DateTime.Now.ToString("dd-MM-yyyy") + "')");
                        if (newAcct.rowAffected > 0)
                        {
                            MessageBox.Show("New Account Added!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            frmAcct.dgvRefresh.btnrefresh_Click(sender, e);
                        }
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Error on login button", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtusername.Focus();
            txtusername.Clear();
            txtpassword.Clear();
        }
    }
}
