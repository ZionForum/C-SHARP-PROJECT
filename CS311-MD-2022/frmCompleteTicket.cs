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
    public partial class frmCompleteTicket : Form
    {
        Class1 completeTicket = new Class1("CHUA-ZYYY", "CS311-2022", "user-z", "1234");
        private string ticketNumber, problem, details, createdBy, dateCreated, completedBy;
        public frmCompleteTicket(string ticketNumber, string problem, string details, string createdBy, string dateCreated, string completedBy, string username)
        {
            InitializeComponent();
            this.ticketNumber = ticketNumber;
            this.problem = problem;
            this.details = details;
            this.createdBy = createdBy;
            this.dateCreated = dateCreated;
            this.completedBy = username;
        }
        private void frmCompleteTicket_Load(object sender, EventArgs e)
        {
            labelticketnumber.Text = ticketNumber;
            labeldetails.Text = details;
            labelcreatedby.Text = createdBy;
            labeldatecreated.Text = dateCreated;
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
                DialogResult ans = MessageBox.Show("Are you sure you want to complete this ticket?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ans == DialogResult.Yes)
                {
                    completeTicket.executeSQL("UPDATE tbleTickets SET problem = '" + labelproblem.Text + "', details = '" + labeldetails.Text +
                    "', status = 'WAITING', completedBy = '" + completedBy + "', dateCompleted = '" +
                    DateTime.Now.ToString("yyyy-MM-dd") + "' WHERE ticketNumber = '" + labelticketnumber.Text + "'");
                    if (completeTicket.rowAffected > 0)
                    {
                        MessageBox.Show("Ticket Completed!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
