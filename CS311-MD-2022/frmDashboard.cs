using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS311_MD_2022
{
    public partial class frmDashboard : Form
    {
        Class1 dashboard = new Class1("CHUA-ZYYY", "CS311-2022", "user-z", "1234");
        private string username, usertype, acct;
        public frmDashboard(string username, string usertype)
        {
            InitializeComponent();
            this.username = username;
            this.usertype = usertype;
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            visionlabel.Text = ("To be a model institution of learning \nwhere relevant knowledge is acquired and \nskills are developed in response to the \nneeds of the global community.");
            missionlabel.Text = ("To provide equitable access to learning \nthrough relevant, innovative, industry-sensitive \nand environment-conscious \nacademic programs and services.");
            chiefslabel.Text = ("C - Competence \n H - Humility \n I - Integrity \n E - Equity \n F - Fortitude \n S - Stewardships");
            hymnlabel.Text = ("Arellano pamantasan namin\nMahal naming Alma Mater.\nAlay sa iyo mga puso namin\nLagi ka naming pakamamahalin\nIkaw ang aming tanging bukal\n" +
                "Ng malayang karunungan\nO pamantasan naming mahal\nArellano University.\n\nArellano aming pamantasan\nLingkod na tapat ng bayan\nAng dunong na sa amin ay bigay\n" +
                "Sa buhay ay gagamiting tanglaw\nSa Diyos ang samo nami't hiling\nNgalan mo'y laging magniningning\nO pamantasan naming mahal\nArellano University.");
            if (usertype == "USER")
            {
                
            }
            else if (usertype == "TECHNICAL")
            {

            }
            else
            {
                DataTable dt = dashboard.GetData("SELECT count(*) FROM tbleaccts WHERE createdBy LIKE '%" + username + "%' GROUP BY userName ORDER BY userName");
                acct = Convert.ToString(dt);
                createdacctlabel.Text = "" + acct;
            }
        }
    }
}
