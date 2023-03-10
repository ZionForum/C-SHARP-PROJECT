using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection;
using System.Threading;

namespace CS311_MD_2022
{
    public partial class frmUpdateEquipment : Form
    {
        private string assetNumber, serialNumber, type, manufacturer, yearModel, description, branch, department, status, lastUpdatedBy;

        Class1 updateEquipment = new Class1("CHUA-ZYYY", "CS311-2022", "user-z", "1234");
        public frmUpdateEquipment(string assetNumber, string serialNumber, string type, string manufacturer, string yearModel, string description, 
            string branch, string department, string status, string lastUpdatedBy)
        {
            InitializeComponent();
            this.assetNumber = assetNumber;
            this.serialNumber = serialNumber;
            this.type = type;
            this.manufacturer = manufacturer;
            this.yearModel = yearModel;
            this.description = description;
            this.branch = branch;
            this.department = department;
            this.status = status;
            this.lastUpdatedBy = lastUpdatedBy;
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

        private void validateSerialNumber()
        {
            DataTable dt = updateEquipment.GetData("SELECT * FROM tbleEquipments WHERE serialNumber = '" + txtserialNumber.Text + "'");
            if (txtserialNumber.Text == "")
            {
                errorProvider1.SetError(txtserialNumber, "Serial Number is empty!");
            }
            else if (dt.Rows.Count > 0)
            {
                errorProvider1.SetError(txtserialNumber, "Serial Number should be unique");
            }
            else
            {
                errorProvider1.SetError(txtserialNumber, "");
            }
        }
        private void validateType()
        {
            if (cmbtype.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbtype, "Select Type is required");
            }
            else
            {
                errorProvider1.SetError(cmbtype, "");
            }
        }
        private void validateManufacturer()
        {
            if (txtmanufacturer.Text == "")
            {
                errorProvider1.SetError(txtmanufacturer, "Manufacturer is empty!");
            }
            else
            {
                errorProvider1.SetError(txtmanufacturer, "");
            }
        }
        private void validateYearModel()
        {
            if (txtyearmodel.Text == "")
            {
                errorProvider1.SetError(txtyearmodel, "Year Model is empty!");
            }
            else if (txtyearmodel.TextLength < 4 || txtyearmodel.TextLength > 5)
            {
                errorProvider1.SetError(txtyearmodel, "Should contain 4 characters only");
            }
            else if (int.Parse(txtyearmodel.Text) < 1990 || int.Parse(txtyearmodel.Text) > 3000)
            {
                errorProvider1.SetError(txtyearmodel, "Year Model should only between 1990 to 3000");
            }
            else
            {
                errorProvider1.SetError(txtyearmodel, "");
            }
        }
        private void txtyearmodel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        private void validateBranch()
        {
            if (cmbbranch.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbbranch, "Select branch is required");
            }
            else
            {
                errorProvider1.SetError(cmbtype, "");
            }
        }
        private void validateDepartment()
        {
            if (cmbdepartments.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbdepartments, "Select department is required");
            }
            else
            {
                errorProvider1.SetError(cmbdepartments, "");
            }
        }

        private void frmUpdateEquipment_Load(object sender, EventArgs e)
        {
            txtassetNumber.Text = assetNumber;
            txtserialNumber.Text = serialNumber;
            txtmanufacturer.Text = manufacturer;
            txtyearmodel.Text = yearModel;
            txtdescription.Text = description;
            if (type == "Monitor")
            {
                cmbtype.SelectedIndex = 0;
            }
            else if (type == "CPU")
            {
                cmbtype.SelectedIndex = 1;
            }
            else if (type == "Keyboard")
            {
                cmbtype.SelectedIndex = 2;
            }
            else if (type == "Mouse")
            {
                cmbtype.SelectedIndex = 3;
            }
            else if (type == "AVR")
            {
                cmbtype.SelectedIndex = 4;
            }
            else if (type == "MAC")
            {
                cmbtype.SelectedIndex = 5;
            }
            else if (type == "Printer")
            {
                cmbtype.SelectedIndex = 6;
            }
            else
            {
                cmbtype.SelectedIndex = 7;
            }
            if (branch == "Juan Sumulong Campus (AU Legarda/Main)")
            {
                cmbbranch.SelectedIndex = 0;
            }
            else if (branch == "Jose Abad Santos (AU Pasay)")
            {
                cmbbranch.SelectedIndex = 1;
            }
            else if (branch == "Andres Bonifacio Campus (AU Pasig)")
            {
                cmbbranch.SelectedIndex = 2;
            }
            else if (branch == "Jose Rizal Campus (AU Malabon)")
            {
                cmbbranch.SelectedIndex = 3;
            }
            else if (branch == "Plaridel Campus (AU Mandaluyong)")
            {
                cmbbranch.SelectedIndex = 4;
            }
            else if (branch == "Apolinario Mabini Campus (AU Pasay)")
            {
                cmbbranch.SelectedIndex = 5;
            }
            else
            {
                cmbbranch.SelectedIndex = 6;
            }
            if (department == "Dean, Graduate School of Education")
            {
                cmbdepartments.SelectedIndex = 0;
            }
            else if (department == "Dean, Graduate School of Nursing")
            {
                cmbdepartments.SelectedIndex = 1;
            }
            else if (department == "Dean, Graduate School of Business")
            {
                cmbdepartments.SelectedIndex = 2;
            }
            else if (department == "OIC, School of Liberal Arts, Social Sciences, and Humanities")
            {
                cmbdepartments.SelectedIndex = 3;
            }
            else if (department == "Cluster Dean, School of Business, Technology & Management")
            {
                cmbdepartments.SelectedIndex = 4;
            }
            else if (department == "Department Chair, College of Business Administration")
            {
                cmbdepartments.SelectedIndex = 5;
            }
            else if (department == "Cluster Dean, School of Science and Mathematics")
            {
                cmbdepartments.SelectedIndex = 6;
            }
            else if (department == "Department Chair, College of Nursing")
            {
                cmbdepartments.SelectedIndex = 7;
            }
            else if (department == "Dean, School of Education, Industrial Arts, Skills Training and Continuing Education")
            {
                cmbdepartments.SelectedIndex = 8;
            }
            else if (department == "Department Chair, College of Education")
            {
                cmbdepartments.SelectedIndex = 9;
            }
            else if (department == "Department Chair, Hospitality & Tourism Mgt.")
            {
                cmbdepartments.SelectedIndex = 10;
            }
            else if (department == "Department Chair, Institute of Accountancy")
            {
                cmbdepartments.SelectedIndex = 11;
            }
            else if (department == "Department Chair, College of Radiologic Technology")
            {
                cmbdepartments.SelectedIndex = 12;
            }
            else if (department == "Department Chair, School of Computer Science")
            {
                cmbdepartments.SelectedIndex = 13;
            }
            else if (department == "Director, International Nursing Program")
            {
                cmbdepartments.SelectedIndex = 14;
            }
            else if (department == "Department Chair, College of Medical Laboratory Science")
            {
                cmbdepartments.SelectedIndex = 15;
            }
            else if (department == "Department Chair, College of Pharmacy")
            {
                cmbdepartments.SelectedIndex = 16;
            }
            else if (department == "Department Chair, College of Physical Therapy")
            {
                cmbdepartments.SelectedIndex = 17;
            }
            else if (department == "Department Chair, School of Midwifery")
            {
                cmbdepartments.SelectedIndex = 18;
            }
            else if (department == "Department Chair, BS Psychology")
            {
                cmbdepartments.SelectedIndex = 19;
            }
            else if (department == "Department Chair, College of Criminal Justice")
            {
                cmbdepartments.SelectedIndex = 20;
            }
            else
            {
                cmbdepartments.SelectedIndex = 21;
            }
            if (status == "WORKING")
            {
                rbworking.Checked = true;
            }
            else if (status == "ON-REPAIR")
            {
                rbrepair.Checked = true;
            }
            else
            {
                rbretired.Checked = true;
            }
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            validateSerialNumber();
            validateType();
            validateManufacturer();
            validateYearModel();
            validateBranch();
            validateDepartment();
            countErrors();
            if (errorCount == 0)
            {
                string updatedStatus;
                if (rbworking.Checked)
                {
                    updatedStatus = rbworking.Text.ToUpper();
                }
                else if (rbrepair.Checked)
                {
                    updatedStatus = rbrepair.Text.ToUpper();
                }
                else
                {
                    updatedStatus = rbretired.Text.ToUpper();
                }
                try
                {
                    updateEquipment.executeSQL("UPDATE tbleEquipments SET serialNumber = '" + txtserialNumber.Text + "', type = '" + cmbtype.Text +
                        "', manufacturer = '" + txtmanufacturer.Text + "', yearModel = '" + txtyearmodel.Text + "', description = '" + txtdescription.Text + 
                        "', branch = '" + cmbbranch.Text + "', department = '" + cmbdepartments + "', status = '" + updatedStatus + "', lastUpdatedBy = '" + lastUpdatedBy + 
                        "', lastUpdatedDate = '" + DateTime.Now.ToString("dd-MM-yyyy") + "' WHERE assetNumber = '" + txtassetNumber.Text + "'");
                    if (updateEquipment.rowAffected > 0)
                    {
                        MessageBox.Show("Equipment Updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        frmEquipment.dgvRefreshEquipment.btnrefresh_Click(sender, e);
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Error on update button", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtserialNumber.Focus();
            txtserialNumber.Clear();
            txtmanufacturer.Clear();
            txtyearmodel.Clear();
            txtdescription.Clear();
        }
    }
}
