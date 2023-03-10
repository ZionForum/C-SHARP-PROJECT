using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CS311_MD_2022
{
    public partial class frmTicket : Form
    {
        public static frmTicket dgvrefreshticket;
        private string ticketNum, createdBy, username, usertype;
        public frmTicket(string ticketNum, string createdBy, string username, string usertype)
        {
            InitializeComponent();
            this.ticketNum = ticketNum;
            this.createdBy = createdBy;
            this.username = username;
            this.usertype = usertype;
            dgvrefreshticket = this;
        }

        Class1 ticket = new Class1("CHUA-ZYYY", "CS311-2022", "user-z", "1234");
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(usertype == "USER")
                {
                    DataTable dt = ticket.GetData("SELECT ticketNumber, problem, details, status, date, time, createdBy, lastUpdatedDate, " +
                    "assignedTo, assignedBy, dateAssigned, completedBy, dateCompleted, approvedBy, " +
                    "dateApproved FROM tbleTickets WHERE createdBy LIKE '%" + username + "%' AND (ticketNumber LIKE '%" +
                    txtsearch.Text + "%' OR problem LIKE '%" + txtsearch.Text + "%' OR status LIKE '%" + txtsearch.Text +
                    "%') ORDER BY ticketNumber DESC");
                    dataGridViewTicket.DataSource = dt;
                }
                else if(usertype == "TECHNICAL")
                {
                    DataTable dt = ticket.GetData("SELECT ticketNumber, problem, details, status, date, time, createdBy, lastUpdatedDate, " +
                    "assignedTo, assignedBy, dateAssigned, completedBy, dateCompleted, approvedBy, " +
                    "dateApproved FROM tbleTickets WHERE assignedTo LIKE '%" + username + "%' AND (ticketNumber LIKE '%" +
                    txtsearch.Text + "%' OR problem LIKE '%" + txtsearch.Text + "%' OR status LIKE '%" + txtsearch.Text +
                    "%') ORDER BY ticketNumber DESC");
                    dataGridViewTicket.DataSource = dt;
                }
                else
                {
                    DataTable dt = ticket.GetData("SELECT ticketNumber, problem, details, status, date, time, createdBy, lastUpdatedDate, " +
                    "assignedTo, assignedBy, dateAssigned, completedBy, dateCompleted, approvedBy, " +
                    "dateApproved FROM tbleTickets WHERE (ticketNumber LIKE '%" + txtsearch.Text + "%' OR problem LIKE '%" + 
                    txtsearch.Text + "%' OR status LIKE '%" + txtsearch.Text + "%') ORDER BY ticketNumber DESC");
                    dataGridViewTicket.DataSource = dt;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error on tickets load", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            frmNewTicket newTicket = new frmNewTicket(ticketNum);
            newTicket.Show();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string updateTicketNumber, updateProblem, updateDetails, updatelastUpdatedDate;
            updateTicketNumber = dataGridViewTicket.Rows[rowSelected].Cells[0].Value.ToString();
            updateProblem = dataGridViewTicket.Rows[rowSelected].Cells[1].Value.ToString();
            updateDetails = dataGridViewTicket.Rows[rowSelected].Cells[2].Value.ToString();
            updatelastUpdatedDate = dataGridViewTicket.Rows[rowSelected].Cells[4].Value.ToString();
            frmUpdateTicket updateTicket = new frmUpdateTicket(updateTicketNumber, updateProblem, updateDetails, updatelastUpdatedDate);
            updateTicket.Show();
        }
        private void btnassign_Click(object sender, EventArgs e)
        {
            string assignTicketNumber, assignProblem, assignDetails, assigncreatedBy, assignTechnician, assigndateCreated, assignedBy;
            assignTicketNumber = dataGridViewTicket.Rows[rowSelected].Cells[0].Value.ToString();
            assignProblem = dataGridViewTicket.Rows[rowSelected].Cells[1].Value.ToString();
            assignDetails = dataGridViewTicket.Rows[rowSelected].Cells[2].Value.ToString();
            assigncreatedBy = dataGridViewTicket.Rows[rowSelected].Cells[6].Value.ToString();
            assignTechnician = dataGridViewTicket.Rows[rowSelected].Cells[8].Value.ToString();
            assignedBy = dataGridViewTicket.Rows[rowSelected].Cells[9].Value.ToString();
            assigndateCreated = dataGridViewTicket.Rows[rowSelected].Cells[10].Value.ToString();
            frmAssignTicket assignTicket = new frmAssignTicket(assignTicketNumber, assignProblem, assignDetails, assigncreatedBy, assignTechnician, assigndateCreated, assignedBy, username);
            assignTicket.Show();
        }
        private void btnapprove_Click(object sender, EventArgs e)
        {
            string approveTicketNumber, approveProblem, approveDetails, approvecompletedBy, approvedateCompleted, approvedBy;
            approveTicketNumber = dataGridViewTicket.Rows[rowSelected].Cells[0].Value.ToString();
            approveProblem = dataGridViewTicket.Rows[rowSelected].Cells[1].Value.ToString();
            approveDetails = dataGridViewTicket.Rows[rowSelected].Cells[2].Value.ToString();
            approvecompletedBy = dataGridViewTicket.Rows[rowSelected].Cells[11].Value.ToString();
            approvedateCompleted = dataGridViewTicket.Rows[rowSelected].Cells[12].Value.ToString();
            approvedBy = dataGridViewTicket.Rows[rowSelected].Cells[13].Value.ToString();
            frmApproveTicket approveTicket = new frmApproveTicket(approveTicketNumber, approveProblem, approveDetails, approvecompletedBy, approvedateCompleted, approvedBy, username);
            approveTicket.Show();
        }

        private void btncomplete_Click(object sender, EventArgs e)
        {
            string complTicketNumber, complProblem, complDetails, complcreatedBy, compldateCreated, complcompleteBy;
            complTicketNumber = dataGridViewTicket.Rows[rowSelected].Cells[0].Value.ToString();
            complProblem = dataGridViewTicket.Rows[rowSelected].Cells[1].Value.ToString();
            complDetails = dataGridViewTicket.Rows[rowSelected].Cells[2].Value.ToString();
            complcreatedBy = dataGridViewTicket.Rows[rowSelected].Cells[6].Value.ToString();
            compldateCreated = dataGridViewTicket.Rows[rowSelected].Cells[10].Value.ToString();
            complcompleteBy = dataGridViewTicket.Rows[rowSelected].Cells[11].Value.ToString();
            frmCompleteTicket completeTicket = new frmCompleteTicket(complTicketNumber, complProblem, complDetails, complcreatedBy, compldateCreated, complcompleteBy, username);
            completeTicket.Show();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult ans = MessageBox.Show("Are you sure you want to delete this data?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ans == DialogResult.Yes)
                {
                    ticket.executeSQL("DELETE FROM tbleTickets WHERE ticketNumber = '" + dataGridViewTicket.Rows[rowSelected].Cells[0].Value.ToString() + "'");
                    if (ticket.rowAffected > 0)
                    {
                        MessageBox.Show("Ticket Deleted Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ticket.executeSQL("INSERT INTO tbleDeletedLogs VALUES ('" + DateTime.Now.ToString("dd-MM-yyyy") + "', '" + DateTime.Now.ToLongTimeString() +
                            "', 'Ticket Management', '" + dataGridViewTicket.Rows[rowSelected].Cells[0].Value.ToString() + "', '" + ticketNum + "')");
                        dgvrefreshticket.btnrefresh_Click(sender, e);
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error on delete button", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void btnrefresh_Click(object sender, EventArgs e)
        {
            frmTicket_Load(sender, e);
        }

        private void frmTicket_Load(object sender, EventArgs e)
        {
            try
            {
                if (usertype == "USER")
                {
                    DataTable dt = ticket.GetData("SELECT * FROM tbleTickets WHERE createdBy LIKE '%" + username + "%' ORDER BY ticketNumber DESC");
                    dataGridViewTicket.DataSource = dt;
                    this.dataGridViewTicket.Columns["details"].Visible = false;
                    this.dataGridViewTicket.Columns["createdBy"].Visible = false;
                    this.dataGridViewTicket.Columns["lastUpdatedDate"].Visible = false;
                    this.dataGridViewTicket.Columns["assignedTo"].Visible = false;
                    this.dataGridViewTicket.Columns["assignedBy"].Visible = false;
                    this.dataGridViewTicket.Columns["dateAssigned"].Visible = false;
                    this.dataGridViewTicket.Columns["completedBy"].Visible = false;
                    this.dataGridViewTicket.Columns["dateCompleted"].Visible = false;
                    this.dataGridViewTicket.Columns["approvedBy"].Visible = false;
                    this.dataGridViewTicket.Columns["dateApproved"].Visible = false;
                }
                else if (usertype == "TECHNICAL")
                {
                    DataTable dt = ticket.GetData("SELECT * FROM tbleTickets WHERE assignedTo LIKE '%" + username + "%' ORDER BY ticketNumber DESC");
                    dataGridViewTicket.DataSource = dt;
                    this.dataGridViewTicket.Columns["details"].Visible = false;
                    this.dataGridViewTicket.Columns["createdBy"].Visible = false;
                    this.dataGridViewTicket.Columns["lastUpdatedDate"].Visible = false;
                    this.dataGridViewTicket.Columns["assignedTo"].Visible = false;
                    this.dataGridViewTicket.Columns["assignedBy"].Visible = false;
                    this.dataGridViewTicket.Columns["dateAssigned"].Visible = false;
                    this.dataGridViewTicket.Columns["completedBy"].Visible = false;
                    this.dataGridViewTicket.Columns["dateCompleted"].Visible = false;
                    this.dataGridViewTicket.Columns["approvedBy"].Visible = false;
                    this.dataGridViewTicket.Columns["dateApproved"].Visible = false;
                }
                else
                {
                    DataTable dt = ticket.GetData("SELECT * FROM tbleTickets ORDER BY ticketNumber DESC");
                    dataGridViewTicket.DataSource = dt;
                    this.dataGridViewTicket.Columns["details"].Visible = false;
                    this.dataGridViewTicket.Columns["createdBy"].Visible = false;
                    this.dataGridViewTicket.Columns["lastUpdatedDate"].Visible = false;
                    this.dataGridViewTicket.Columns["assignedTo"].Visible = false;
                    this.dataGridViewTicket.Columns["assignedBy"].Visible = false;
                    this.dataGridViewTicket.Columns["dateAssigned"].Visible = false;
                    this.dataGridViewTicket.Columns["completedBy"].Visible = false;
                    this.dataGridViewTicket.Columns["dateCompleted"].Visible = false;
                    this.dataGridViewTicket.Columns["approvedBy"].Visible = false;
                    this.dataGridViewTicket.Columns["dateApproved"].Visible = false;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error on tickets load", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridViewTicket.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTicket.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTicket.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTicket.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTicket.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTicket.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private int rowSelected;
        private void dataGridViewTicket_SelectionChanged(object sender, EventArgs e)
        {
            rowSelected = dataGridViewTicket.CurrentCell.RowIndex;
            string status;
            status = dataGridViewTicket.Rows[rowSelected].Cells[3].Value.ToString();
            if (usertype == "USER")
            {
                btnapprove.Hide();
                btnassign.Hide();
                btncomplete.Hide();
                if (status != "PENDING")
                {
                    btnupdate.Enabled = false;
                    btndelete.Enabled = false;
                }
                else
                {
                    btnupdate.Enabled = true;
                    btndelete.Enabled = true;
                }
            }
            else if (usertype == "ADMINISTRATOR")
            {
                btncomplete.Hide();
                if (status != "PENDING")
                {
                    btnassign.Enabled = false;
                }
                else
                {
                    btnassign.Enabled = true;
                }
                if (status != "WAITING")
                {
                    btnapprove.Enabled = false;
                }
                else
                {
                    btnapprove.Enabled = true;
                }
            }
            else
            {
                btnassign.Hide();
                btnapprove.Hide();
                btnadd.Hide();
                btnupdate.Hide();
                btndelete.Hide();
                btnrefresh.Hide();
                if (status != "ON-GOING")
                {
                    btncomplete.Enabled = false;
                }
                else
                {
                    btncomplete.Enabled = true;
                }
            }
        }
    }
}
