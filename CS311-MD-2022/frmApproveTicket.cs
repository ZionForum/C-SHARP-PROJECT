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
    public partial class frmApproveTicket : Form
    {
        Class1 approveTicket = new Class1("CHUA-ZYYY", "CS311-2022", "user-z", "1234");
        private string ticketNumber, problem, details, completedBy, dateCompleted, approvedBy;
        public frmApproveTicket(string ticketNumber, string problem, string details, string completedBy, string dateCompleted, string approvedBy, string username)
        {
            InitializeComponent();
            this.ticketNumber = ticketNumber;
            this.problem = problem;
            this.details = details;
            this.completedBy = completedBy;
            this.dateCompleted = dateCompleted;
            this.approvedBy = username;
        }
        private void frmApproveTicket_Load(object sender, EventArgs e)
        {
            labelticketnumber.Text = ticketNumber;
            labelcompletedby.Text = completedBy;
            labeldatecompleted.Text = dateCompleted;
            labeldetails.Text = details;
            if (problem == "Hardware")
            {
                labelproblem.Text = "Hardware";
            }
            else if (problem == "Software")
            {
                labelproblem.Text = "Software";
            }
            else
            {
                labelproblem.Text = "Connection";
            }
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult ans = MessageBox.Show("Are you sure you want to approve this ticket?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ans == DialogResult.Yes)
                {
                    approveTicket.executeSQL("UPDATE tbleTickets SET problem = '" + labelproblem.Text + "', details = '" + labeldetails.Text +
                    "', status = 'APPROVED', completedBy = '" + labelcompletedby.Text + "', dateCompleted = '" +
                    DateTime.Now.ToString("yyyy-MM-dd") + "', approvedBy = '" + approvedBy + "', dateApproved = '" +
                    DateTime.Now.ToString("yyyy-MM-dd") + "' WHERE ticketNumber = '" + labelticketnumber.Text + "'");
                    if (approveTicket.rowAffected > 0)
                    {
                        MessageBox.Show("Ticket Approved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        frmTicket.dgvrefreshticket.btnrefresh_Click(sender, e);
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error on update button", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
