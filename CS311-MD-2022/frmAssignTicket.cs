using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CS311_MD_2022
{
    public partial class frmAssignTicket : Form
    {
        Class1 assignTicket = new Class1("CHUA-ZYYY", "CS311-2022", "user-z", "1234");
        private string ticketNumber, problem, details, createdBy, dateCreated, technicians, assignedBy;

        public frmAssignTicket(string ticketNumber, string problem, string details, string createdBy, string technicians, string dateCreated, string assignedBy, string username)
        {
            InitializeComponent();
            this.ticketNumber = ticketNumber;
            this.problem = problem;
            this.details = details;
            this.createdBy = createdBy;
            this.technicians = technicians;
            this.dateCreated = dateCreated;
            this.assignedBy = username;
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
        public void validateTechnician()
        {
            if (cmbtechnicians.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbtechnicians, "Select is required");
            }
            else
            {
                errorProvider1.SetError(cmbtechnicians, "");
            }
        }
        private void frmAssignTicket_Load(object sender, EventArgs e)
        {
            labelticketnumber.Text = ticketNumber;
            labelcreatedby.Text = createdBy;
            labeldatecreated.Text = dateCreated;
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
            validateTechnician();
            countErrors();
            if(errorCount == 0)
            {
                try
                {
                    DialogResult ans = MessageBox.Show("Are you sure you want to assign this ticket?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ans == DialogResult.Yes)
                    {
                        assignTicket.executeSQL("UPDATE tbleTickets SET problem = '" + labelproblem.Text + "', details = '" + labeldetails.Text +
                        "', status = 'ON-GOING', date = '" + labeldatecreated.Text + "', createdBy = '" + createdBy +
                        "',  assignedTo = '" + cmbtechnicians.Text + "', assignedBy = '" + assignedBy + "', dateAssigned = '" +
                        DateTime.Now.ToString("yyyy-MM-dd") + "' WHERE ticketNumber = '" + labelticketnumber.Text + "'");
                        if (assignTicket.rowAffected > 0)
                        {
                            MessageBox.Show("Ticket Assigned!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
}
