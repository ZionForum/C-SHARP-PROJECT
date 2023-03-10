using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS311_MD_2022
{
    public partial class frmUpdateAcct : Form
    {
        private string username, password, usertype, status, updateBy;
        Class1 updateAcct = new Class1("CHUA-ZYYY", "CS311-2022", "user-z", "1234");
        public frmUpdateAcct(string username, string password, string usertype, string status, string updateBy)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            this.usertype = usertype;
            this.status = status;
            this.updateBy = updateBy;
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
        private void btnclear_Click(object sender, EventArgs e)
        {
            txtusername.Focus();
            txtusername.Clear();
            txtpassword.Clear();
        }
        private void frmUpdateAcct_Load(object sender, EventArgs e)
        {
            txtusername.Enabled = false;
            txtusername.Text = username;
            txtpassword.Text = password;
            if (usertype == "ADMINISTRATOR")
            {
                cmbusertype.SelectedIndex = 0;
            }
            else if (usertype == "TECHNICAL")
            {
                cmbusertype.SelectedIndex = 1;
            }
            else
            {
                cmbusertype.SelectedIndex = 2;
            }
            if (status == "ACTIVE")
            {
                rbactive.Checked = true;
            }
            else
            {
                rbinactive.Checked = true;
            }
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            validatePassword();
            validateUsertype();
            countErrors();
            if(errorCount ==0)
            {
                string newStatus;
                if(rbactive.Checked)
                {
                    newStatus = rbactive.Text.ToUpper();
                }
                else
                {
                    newStatus = rbinactive.Text.ToUpper();
                }
                try
                {
                    updateAcct.executeSQL("UPDATE tbleaccts SET password = '" + txtpassword.Text + "' , userType = '" + cmbusertype.Text.ToUpper() +
                        "', status = '" + newStatus + "', lastUpdatedBy = '" + updateBy + "', dataUpdated = '" + DateTime.Now.ToString("dd-MM-yyyy") + 
                        "' WHERE username = '" + txtusername.Text + "'");
                    if(updateAcct.rowAffected > 0)
                    {
                        MessageBox.Show("Account Updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        frmAcct.dgvRefresh.btnrefresh_Click(sender, e);
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Error on update button", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
