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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        //create object using the class
        Class1 login = new Class1("CHUA-ZYYY", "CS311-2022", "user-z", "1234");
        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                // create a data table containing your SQL SELECT Command
                DataTable dt = login.GetData("SELECT * FROM tbleaccts WHERE username = '" + txtusername.Text + "' AND password = '" + txtpassword.Text +
                    "' AND status = 'ACTIVE '");
                //login successful
                if (dt.Rows.Count > 0)
                {
                    frmMain main = new frmMain(txtusername.Text, dt.Rows[0].Field<string>("userType"), txtpassword.Text);
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password or account is inactive", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error on login button", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtusername.Focus();
            txtusername.Clear();
            txtpassword.Clear();
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Convert.ToChar(e.KeyChar) == 13)
            {
                btnlogin_Click(sender, e);
            }
        }
    }
}
