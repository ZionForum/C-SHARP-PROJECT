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
    public partial class frmEquipment : Form
    {
        public static frmEquipment dgvRefreshEquipment;
        private string assetNum;
        public frmEquipment(string assetNum)
        {
            InitializeComponent();
            this.assetNum = assetNum;
            dgvRefreshEquipment = this;
        }
        Class1 equipment = new Class1("CHUA-ZYYY", "CS311-2022", "user-z", "1234");
        public void frmEquipment_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = equipment.GetData("SELECT AssetNumber, SerialNumber, Type, manufacturer, YearModel, Description, Branch, Department, " +
                    "Status, createdBy, dateCreated, lastUpdatedBy, lastUpdatedDate FROM tbleEquipments WHERE assetnumber <> '" + assetNum + "' ORDER BY dateCreated ASC");
                dataGridViewEquipment.DataSource = dt;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error on equipments load", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridViewEquipment.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewEquipment.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewEquipment.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewEquipment.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewEquipment.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewEquipment.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = equipment.GetData("SELECT assetNumber, serialNumber, type, manufacturer, yearModel, description, branch, department, status," +
                    "createdBy, dateCreated, lastUpdatedBy, lastUpdatedDate FROM tbleEquipments WHERE assetnumber <> '" + assetNum + 
                    "'AND (assetNumber LIKE '%" + txtsearch.Text + "%' OR serialNumber LIKE '%" + txtsearch.Text + "%' OR type LIKE '%" + txtsearch.Text +
                    "%' OR branch LIKE '%" + txtsearch.Text + "%') ORDER BY dateCreated ASC");
                dataGridViewEquipment.DataSource = dt;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error on equipments load", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int rowSelected;
        public void btnadd_Click(object sender, EventArgs e)
        {
            frmNewEquipment newEquipment = new frmNewEquipment(assetNum);
            newEquipment.Show();
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            string updateAssetNumber, updateSerialNumber, updateType, updateManufacturer, updateYearModel, updateDescription, updateBranch, updateDepartment, updateStatus;
            updateAssetNumber = dataGridViewEquipment.Rows[rowSelected].Cells[0].Value.ToString();
            updateSerialNumber = dataGridViewEquipment.Rows[rowSelected].Cells[1].Value.ToString();
            updateType = dataGridViewEquipment.Rows[rowSelected].Cells[2].Value.ToString();
            updateManufacturer = dataGridViewEquipment.Rows[rowSelected].Cells[3].Value.ToString();
            updateYearModel = dataGridViewEquipment.Rows[rowSelected].Cells[4].Value.ToString();
            updateDescription = dataGridViewEquipment.Rows[rowSelected].Cells[5].Value.ToString();
            updateBranch = dataGridViewEquipment.Rows[rowSelected].Cells[6].Value.ToString();
            updateDepartment = dataGridViewEquipment.Rows[rowSelected].Cells[7].Value.ToString();
            updateStatus = dataGridViewEquipment.Rows[rowSelected].Cells[8].Value.ToString();
            frmUpdateEquipment updateEquipment = new frmUpdateEquipment(updateAssetNumber, updateSerialNumber, updateType, updateManufacturer, 
                updateYearModel, updateDescription, updateBranch, updateDepartment, updateStatus, assetNum);
            updateEquipment.Show();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult ans = MessageBox.Show("Are you sure you want to delete this data?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ans == DialogResult.Yes)
                {
                    equipment.executeSQL("DELETE FROM tbleEquipments WHERE assetNumber = '" + dataGridViewEquipment.Rows[rowSelected].Cells[0].Value.ToString() + "'");
                    if (equipment.rowAffected > 0)
                    {
                        MessageBox.Show("Equipment Deleted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        equipment.executeSQL("INSERT INTO tbleDeletedLogs VALUES ('" + DateTime.Now.ToString("dd-MM-yyyy") + "', '" + DateTime.Now.ToLongTimeString() +
                            "', 'Equipment Management', '" + dataGridViewEquipment.Rows[rowSelected].Cells[0].Value.ToString() + "', '" + assetNum + "')");
                        dgvRefreshEquipment.btnrefresh_Click(sender, e);
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
            frmEquipment_Load(sender, e);
        }

        private void dataGridViewEquipment_SelectionChanged(object sender, EventArgs e)
        {
            rowSelected = dataGridViewEquipment.CurrentCell.RowIndex;
            dataGridViewEquipment.Columns[3].Visible = false;
            dataGridViewEquipment.Columns[4].Visible = false;
            dataGridViewEquipment.Columns[5].Visible = false;
            dataGridViewEquipment.Columns[7].Visible = false;
            dataGridViewEquipment.Columns[9].Visible = false;
            dataGridViewEquipment.Columns[10].Visible = false;
            dataGridViewEquipment.Columns[11].Visible = false;
            dataGridViewEquipment.Columns[12].Visible = false;
        }
    }
}
