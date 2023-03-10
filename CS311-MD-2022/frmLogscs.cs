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
    public partial class frmLogscs : Form
    {
        private string date, time;
        public frmLogscs(string date, string time)
        {
            InitializeComponent();
            this.date = date;
            this.time = time;
        }
        Class1 logscs = new Class1("CHUA-ZYYY", "CS311-2022", "user-z", "1234");

        private void frmLogscs_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = logscs.GetData("SELECT Date, Time, Module, ID, DeletedBy FROM tbleDeletedLogs WHERE date <> '" + date + "' ORDER BY time DESC");
                dataGridViewLogs.DataSource = dt;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error on delete logs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridViewLogs.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewLogs.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewLogs.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewLogs.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewLogs.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewLogs.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private int rowSelected;
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = logscs.GetData("SELECT date, time, module, ID, deletedBy FROM tbleDeletedLogs WHERE date <> '" + date + "'AND (ID LIKE '%" +
                    txtsearch.Text + "%') ORDER BY date");
                dataGridViewLogs.DataSource = dt;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error on accounts load", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewLogs_SelectionChanged(object sender, EventArgs e)
        {
            rowSelected = dataGridViewLogs.CurrentCell.RowIndex;
        }
    }
}
