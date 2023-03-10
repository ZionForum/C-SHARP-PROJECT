using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS311_MD_2022
{
    public partial class frmUpdateTicket : Form
    {
        Class1 updateTicket = new Class1("CHUA-ZYYY", "CS311-2022", "user-z", "1234");
        private string ticketNumber, problem, details, lastUpdatedDate;
        public frmUpdateTicket(string ticketNumber, string problem, string details, string lastUpdatedDate)
        {
            InitializeComponent();
            this.ticketNumber = ticketNumber;
            this.problem = problem;
            this.details = details;
            this.lastUpdatedDate = lastUpdatedDate;
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
        public void validateticketNumber()
        {
            if (txtticketnumber.Text == "")
            {
                errorProvider1.SetError(txtticketnumber, "Ticket Number is empty!");
            }
            else
            {
                errorProvider1.SetError(txtticketnumber, "");
            }
        }
        public void validatedetails()
        {
            if (txtdetails.Text == "")
            {
                errorProvider1.SetError(txtdetails, "Details is empty!");
            }
            else
            {
                errorProvider1.SetError(txtdetails, "");
            }
        }
        public void validateproblem()
        {
            if (cmbproblem.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbproblem, "Select is required");
            }
            else
            {
                errorProvider1.SetError(cmbproblem, "");
            }
        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            txtdetails.Clear();
        }
        private void frmUpdateTicket_Load(object sender, EventArgs e)
        {
            txtticketnumber.Text = ticketNumber;
            txtdetails.Text = details;
            if (problem == "Hardware")
            {
                cmbproblem.SelectedIndex = 0;
            }
            else if (problem == "Software")
            {
                cmbproblem.SelectedIndex = 1;
            }
            else
            {
                cmbproblem.SelectedIndex = 2;
            }
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            validateticketNumber();
            validatedetails();
            validateproblem();
            countErrors();
            if (errorCount == 0)
            {
                try
                {
                    DialogResult ans = MessageBox.Show("Are you sure you want to update this ticket?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ans == DialogResult.Yes)
                    {
                        updateTicket.executeSQL("UPDATE tbleTickets SET problem = '" + cmbproblem.Text + "', details = '" + txtdetails.Text +
                        "', lastUpdatedDate = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' WHERE ticketNumber = '" + txtticketnumber.Text + "'");
                        if (updateTicket.rowAffected > 0)
                        {
                            MessageBox.Show("Ticket Updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
