// ScheduleFrm.cs
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
    public partial class ScheduleFrm : Form
    {
        public ScheduleFrm()
        {
            InitializeComponent();
        }

        private void uxBackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
