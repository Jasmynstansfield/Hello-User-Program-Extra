using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_User_Program_Extra
{
    public partial class frmGreetings : Form
    {
        public frmGreetings()
        {
            InitializeComponent();
        }

        private void btnSnareDrum_Click(object sender, EventArgs e)
        {
            lblJoke.Text = "*Ba-dum ching*";
        }

        private void btnAmnesia_Click(object sender, EventArgs e)
        {
            lblJoke.Text = "I forgot how it goes.";
        }
    }
}
