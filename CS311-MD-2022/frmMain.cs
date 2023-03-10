using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CS311_MD_2022
{
    public partial class frmMain : Form
    {
        private string username, usertype, password;
        public frmMain(string username, string usertype, string password)
        {
            InitializeComponent();
            toolStripUsername.Text = ": " + username + "  |";
            toolStripUsertype.Text = ": " + usertype;
            this.username = username;
            this.usertype = usertype;
            this.password = password;
        }

        private void accountsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmAcct acct = new frmAcct(username);
            acct.MdiParent = this;
            panel1.Hide();
            acct.Show();
        }
        private void equipmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEquipment equipment = new frmEquipment(username);
            equipment.MdiParent = this;
            panel1.Hide();
            equipment.Show();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }

        private void ticketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTicket ticket = new frmTicket(username, username, username, usertype);
            ticket.MdiParent = this;
            panel1.Hide();
            ticket.Show();
        }

        private void changepassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword changePass = new frmChangePassword(username, password);
            changePass.MdiParent = this;
            panel1.Hide();
            changePass.Show();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Show();
            frmDashboard dashboard = new frmDashboard(username, usertype);
            dashboard.TopLevel = false;
            panel1.Controls.Add(dashboard);
            dashboard.BringToFront();
            dashboard.Show();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogscs logscs = new frmLogscs(username, username);
            logscs.MdiParent = this;
            panel1.Hide();
            logscs.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            panel1.Hide();
            if (usertype == "USER")
            {
                accountsToolStripMenuItem.Visible = false;
                equipmentsToolStripMenuItem.Visible = false;
                ticketsToolStripMenuItem.Visible = true;
                changepassToolStripMenuItem.Visible = true;
                reportsToolStripMenuItem.Visible = false;
                toolsToolStripMenuItem.Visible = true;
                aboutToolStripMenuItem.Visible = true;
                helpToolStripMenuItem.Visible = true;
                changepassToolStripMenuItem.Visible = true;
                reportsToolStripMenuItem.Visible = false;
            }
            else if (usertype == "TECHNICAL")
            {
                accountsToolStripMenuItem.Visible = false;
                equipmentsToolStripMenuItem.Visible = true;
                ticketsToolStripMenuItem.Visible = true;
                changepassToolStripMenuItem.Visible = true;
                reportsToolStripMenuItem.Visible = true;
                toolsToolStripMenuItem.Visible = true;
                aboutToolStripMenuItem.Visible = true;
                helpToolStripMenuItem.Visible = true;
                changepassToolStripMenuItem.Visible = true;
                reportsToolStripMenuItem.Visible = false;
            }
            else
            {
                accountsToolStripMenuItem.Visible = true;
                equipmentsToolStripMenuItem.Visible = true;
                ticketsToolStripMenuItem.Visible = true;
                changepassToolStripMenuItem.Visible = true;
                reportsToolStripMenuItem.Visible = true;
                toolsToolStripMenuItem.Visible = true;
                aboutToolStripMenuItem.Visible = true;
                helpToolStripMenuItem.Visible = true;
                changepassToolStripMenuItem.Visible = false;
                reportsToolStripMenuItem.Visible = true;
            }
        }
    }
}
