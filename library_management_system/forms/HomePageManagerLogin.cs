using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_management_system.forms
{
    public partial class HomePageManagerLogin : Form
    {
        homePage hmp;
        public HomePageManagerLogin(homePage homePage)
        {
            this.hmp = homePage;
            InitializeComponent();
        }

        private void HomePageManagerLogin_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            managerPage oform = new managerPage(hmp);
            oform.Show();
            hmp.Hide();
        }
    }
}
