/*
 * Jasmyn Stansfield
 * Mr. Hardman
 * Assignment 2, Program 1
 * October 14, 2016
 */

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
    public partial class frmHelloUser : Form
    {
        public frmHelloUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Getting user inputted information
            int myAge = 15;
            int userAge = Convert.ToInt32(txtUserAge.Text);

            //Using arithmetic operations
            int difference = userAge - myAge;

            
            string userName;
            userName = txtUserName.Text;

            //Display to the user
            lblDisplay.Text = "Hello " + userName + ",";
            lblDisplay.Text += "\nWe are " + difference + " years apart!";
        }
    }
}
