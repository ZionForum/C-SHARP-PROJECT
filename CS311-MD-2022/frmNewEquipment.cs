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
    public partial class frmNewEquipment : Form
    {
        private string createdBy;
        public frmNewEquipment(string createdBy)
        {
            InitializeComponent();
            this.createdBy = createdBy;
        }
        Class1 newEquipment = new Class1("CHUA-ZYYY", "CS311-2022", "user-z", "1234");
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
        private void validateAssetNumber()
        {
            DataTable dt = newEquipment.GetData("SELECT * FROM tbleEquipments WHERE assetNumber = '" + txtassetNumber.Text + "'");
            if (txtassetNumber.Text == "")
            {
                errorProvider1.SetError(txtassetNumber, "Asset Number is empty!");
            }
            else if (dt.Rows.Count > 0)
            {
                errorProvider1.SetError(txtassetNumber, "Asset Number should be unique");
            }
            else
            {
                errorProvider1.SetError(txtassetNumber, "");
            }
        }
        private void validateSerialNumber()
        {
            DataTable dt = newEquipment.GetData("SELECT * FROM tbleEquipments WHERE serialNumber = '" + txtserialNumber.Text + "'");
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
            else if(txtyearmodel.TextLength < 4 || txtyearmodel.TextLength > 5)
            {
                errorProvider1.SetError(txtyearmodel, "Should contain 4 characters only");
            }
            else if(int.Parse(txtyearmodel.Text) < 1990 || int.Parse(txtyearmodel.Text) > 3000)
            {
                errorProvider1.SetError(txtyearmodel, "Year Model should only between 1990 to 3000");
            }
            else
            {
                errorProvider1.SetError(txtyearmodel, "");
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
                errorProvider1.SetError(cmbbranch, "");
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
        private void btnclear_Click(object sender, EventArgs e)
        {
            txtassetNumber.Focus();
            txtassetNumber.Clear();
            txtserialNumber.Clear();
            txtmanufacturer.Clear();
            txtyearmodel.Clear();
            txtdescription.Clear();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            validateAssetNumber();
            validateSerialNumber();
            validateType();
            validateManufacturer();
            validateYearModel();
            validateBranch();
            validateDepartment();
            countErrors();
            if (errorCount == 0)
            {
                try
                {
                    DialogResult ans = MessageBox.Show("Are you sure you want to save the equipment data?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ans == DialogResult.Yes)
                    {
                        newEquipment.executeSQL("INSERT INTO tbleEquipments (assetNumber, serialNumber, type, manufacturer, yearModel, description, branch, department, status," +
                            "createdBy, dateCreated) VALUES ('" + txtassetNumber.Text + "', '" + txtserialNumber.Text + "', '" + cmbtype.Text + "', '" +
                            txtmanufacturer.Text + "', '" + txtyearmodel.Text + "', '" + txtdescription.Text + "', '" + cmbbranch.Text + "', '" +
                            cmbdepartments.Text + "', 'WORKING', '" + createdBy + "', '" + DateTime.Now.ToString("dd-MM-yyyy") + "')");
                        if (newEquipment.rowAffected > 0)
                        {
                            MessageBox.Show("New Equipment Added!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            frmEquipment.dgvRefreshEquipment.btnrefresh_Click(sender, e);
                        }
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Error on save button", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtyearmodel_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
             {
                e.Handled = true;
             }
        }
    }
}
