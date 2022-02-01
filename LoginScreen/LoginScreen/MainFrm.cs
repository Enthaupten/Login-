// MainFrm.cs
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

namespace LoginScreen
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        // Settings Button
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SettingsFrm settingsFrm = new SettingsFrm();
            settingsFrm.Show();
        }

        private void uxExitPicbox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void uxAccountPicbox_Click(object sender, EventArgs e)
        {
            AccountFrm accountFrm = new AccountFrm();
            accountFrm.Show();
        }

        private void uxScheduleBtn_Click(object sender, EventArgs e)
        {
            ScheduleFrm scheduleFrm = new ScheduleFrm();
            scheduleFrm.Show();
        }

        private void uxBuyTicketsBtn_Click(object sender, EventArgs e)
        {
            TicketsFrm ticketsFrm = new TicketsFrm();
            ticketsFrm.Show();
        }

        private void uxNewsBtn_Click(object sender, EventArgs e)
        {
            NewsFrm newFrm = new NewsFrm();
            newFrm.Show();
        }
    }
}
