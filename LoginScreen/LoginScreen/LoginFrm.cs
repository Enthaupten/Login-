// LoginFrm.cs
// MIS 677
// 
// Authors: Matthew Walberg, Alex Anderson, Karl Burg, Rob Kaufman, Mike Hewko
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginScreen
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();

        }

        // Global variables
        int failedAttempts = 0;          // Counter to keep track of failed login attempts
        DateTime lockTime;               // DateTime variable to hold time when login is available again.
      

        private void uxSubmitBtn_Click(object sender, EventArgs e)
        {
            Boolean UserValid;
            string connString = "Data Source=bb-enterprise.users.campus;Initial Catalog=GROUP5;Persist Security Info=True;User ID=Group5;Password=Grp5s2117";

            //try catch to check username and password
            try
            {
                using(SqlConnection myConnection = new SqlConnection(connString))
                {
                    string query = "SELECT * FROM Neighbor_Login WHERE UserID = '" + txtUsername.Text + "' AND Password = '" + txtPassword.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, myConnection);
                    myConnection.Open();
                    SqlDataReader readerReturnValue = cmd.ExecuteReader();
                    if(readerReturnValue.HasRows == true)
                    {
                        UserValid = true;
                        failedAttempts = 0;
                        MainFrm frmMain = new MainFrm();
                        frmMain.Show();
                        this.Close();
                    }
                    else
                    {
                        UserValid = false;
                        if(failedAttempts == 3)
                        {

                            MessageBox.Show("Invalid login attempt. Account has been locked for an additional 10 seconds.");
                            // Record time 30 seconds into the future for later calculations
                            lockTime = DateTime.Now.AddSeconds(10);
                        }
                        else if(failedAttempts == 2)
                        {
                            failedAttempts++;
                            MessageBox.Show("Maximum attempts reached. Account has been locked for 10 seconds.");
                        }
                        else
                        {
                            failedAttempts++;
                            MessageBox.Show("Invalid login attempt. Please try again.");
                        }
                    }
                    myConnection.Close();
                }
                

             
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void uxExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void uxUsernameTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
