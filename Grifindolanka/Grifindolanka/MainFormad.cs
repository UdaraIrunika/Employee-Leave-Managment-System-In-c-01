using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grifindolanka
{
    public partial class MainFormad : Form
    {
        public MainFormad()
        {
            InitializeComponent();
        }

        private void btnManageem_Click(object sender, EventArgs e)
        {
            manangeemp1.Visible = true;
            manageLeatyp1.Visible = false;
            epmanalea1.Visible = false;
            viweleavehistory1.Visible = false; 
        }

        private void btnManaginglea_Click(object sender, EventArgs e)
        {
            manangeemp1.Visible = false;
            manageLeatyp1.Visible = false;
            epmanalea1.Visible = true;
            viweleavehistory1.Visible = false;
        }

        private void btnManagingLeaTyp_Click(object sender, EventArgs e)
        {
            manangeemp1.Visible = false;
            manageLeatyp1.Visible = true;
            epmanalea1.Visible = false;
            viweleavehistory1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Optionally, confirm with the user before logging out
            var result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Clear any user session data here (if applicable)
                // For example: UserSession.CurrentUser = null; 

                // Optionally, close the current form
                this.Hide(); // Hides the current form

                // Show the login form (assuming you have a LoginForm)
                login loginForm = new login();
                loginForm.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            manangeemp1.Visible = false;
            manageLeatyp1.Visible = false;
            epmanalea1.Visible = false;
            viweleavehistory1.Visible = true;
        }
    }
}
