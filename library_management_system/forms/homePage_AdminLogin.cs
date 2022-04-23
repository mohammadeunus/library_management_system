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
using System.Data.SqlClient;

namespace library_management_system.forms
{
    public partial class homePage_AdminLogin : Form
    {
        string userId, password, querry;

        public homePage hmp;
        public homePage_AdminLogin(homePage homePage)
        {
            this.hmp = homePage;
            InitializeComponent();
        }
      
        private void logincheck()
        {
            try
            {

                Connection CN = new Connection();
                querry = "SELECT * FROM ADMINLOGINinfo WHERE id='" + idBoxAdmin.Text + "' AND password='" + passBoxAdmin.Text + "'";
                
                SqlDataAdapter sda =new SqlDataAdapter(querry, CN.thisConnection);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count>0)
                {
                    adminPage oform = new adminPage(hmp);
                    oform.Show();
                    passBoxAdmin.Clear();
                    hmp.Hide();

                }
                else
                {
                    adminLoginInfo.Text = "Admin: username or password incorrect";
                    passBoxAdmin.Clear();
                }
                //this.Close();
                CN.thisConnection.Close();

            }
            catch (Exception ex)
            {
                adminLoginInfo.Text = "Admin: Exception error: " + ex.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            logincheck();
        }

        private void errorAdminLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
