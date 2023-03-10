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
    public partial class frmChangePassword : Form
    {
        private string username, password;
        Class1 changePass = new Class1("CHUA-ZYYY", "CS311-2022", "user-z", "1234");
        public frmChangePassword(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            validatePassword();
            countErrors();
            if(errorCount == 0)
            {
                try
                {
                    DialogResult ans = MessageBox.Show("Are you sure you want to change the password?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ans == DialogResult.Yes)
                    {
                        changePass.executeSQL("UPDATE tbleaccts SET password = '" + txtpassword.Text + "' WHERE username = '" + txtusername.Text + "'");
                        if (changePass.rowAffected > 0)
                        {
                            MessageBox.Show("Password Changed Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Error on update button", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
        public void validatePassword()
        {
            if (txtpassword.Text == "")
            {
                errorProvider1.SetError(txtpassword, "Password should not be empty!");
            }
            else
            {
                errorProvider1.SetError(txtpassword, "");
            }
        }

        private void chkshow_CheckedChanged(object sender, EventArgs e)
        {
            txtpassword_TextChanged(sender, e);
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

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToChar(e.KeyChar) == 13)
            {
                btnsave_Click(sender, e);
            }
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            txtusername.Text = username;
            txtpassword.Text = password;
        }
    }
}
