using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_management_system.forms
{
    public partial class homePage_AdminLogin : Form
    {
        public homePage hmp;
        public homePage_AdminLogin(homePage homePage)
        {
            this.hmp = homePage;
            InitializeComponent();
        }
        /*
        private void logincheck()
        {
            try
            {

                Connection CN = new Connection();
                CN.thisConnection.Open();
                OracleCommand thisCommand = new OracleCommand();
                thisCommand.Connection = CN.thisConnection;
                thisCommand.CommandText = "SELECT * FROM ADMINLOGIN WHERE id='" + idBoxAdmin.Text + "' AND password='" + passBoxAdmin.Text + "'";
                OracleDataReader thisReader = thisCommand.ExecuteReader();
                if (thisReader.Read())
                {
                    DbFeatures oform = new DbFeatures();
                    oform.Show();
                    this.Hide();
                }
                else
                {
                    errorAdminLogin.Text = "username or password incorrect";
                    passBoxAdmin.Clear();
                }
                //this.Close();
                CN.thisConnection.Close();

            }
            catch (Exception ex)
            {
                errorAdminLogin.Text = "Exception error: "+ ex.ToString();
            }
        }*/

        private void button3_Click(object sender, EventArgs e)
        {
            adminPage oform = new adminPage(hmp);
            oform.Show();
            hmp.Hide();
        }

        private void errorAdminLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
