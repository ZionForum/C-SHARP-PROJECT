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
    public partial class frmNewTicket : Form
    {
        private string createdBy;
        public frmNewTicket(string createdBy)
        {
            InitializeComponent();
            this.createdBy = createdBy;
        }
        Class1 newTicket = new Class1("CHUA-ZYYY", "CS311-2022", "user-z", "1234");
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
            if(txtticketnumber.Text == "")
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
            txtticketnumber.Clear();
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
                    DialogResult ans = MessageBox.Show("Are you sure you want to save this ticket?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ans == DialogResult.Yes)
                    {
                        newTicket.executeSQL("INSERT INTO tbleTickets (ticketNumber, problem, details, status, date, time, createdBy, dateAssigned," +
                            "dateCompleted, dateApproved) VALUES ('" + txtticketnumber.Text + "', '" + cmbproblem.Text + "', '" +
                            txtdetails.Text + "', 'PENDING', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + DateTime.Now.ToString("hh:mm:ss tt") +
                            "', '" + createdBy + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + DateTime.Now.ToString("yyyy-MM-dd") +
                            "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                        if (newTicket.rowAffected > 0)
                        {
                            MessageBox.Show("Ticket Created Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            frmTicket.dgvrefreshticket.btnrefresh_Click(sender, e);
                        }
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Error on save button", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmNewTicket_Load(object sender, EventArgs e)
        {
            txtticketnumber.Text = String.Format("{0:yyyyMMddhhmmss}", DateTime.Now);
        }
    }
}
