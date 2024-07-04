using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCustomerRegistration_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnCustomerRegistration.Left + 18;

            uC_CustomerRegistration1.Visible = true;
            uC_CustomerRegistration1.BringToFront();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnAddRoom.Left + 18;
            uC_AddRoom1.Visible = true;
            uC_AddRoom1.BringToFront();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            uC_CustomerCheckOut1.Visible = true;
            uC_CustomerCheckOut1.BringToFront();
            MovingPanel.Left = btnCheckOut.Left + 18;
        }

        private void btnCustomerDetails_Click(object sender, EventArgs e)
        {
            uC_CustomerDetails1.Visible = true;
            uC_CustomerDetails1.BringToFront();

            MovingPanel.Left = btnCustomerDetails.Left + 18;
        }



        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_Employee2.Visible=false;
            uC_CustomerRegistration1.Visible = false;
            btnAddRoom.PerformClick();
        }
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            uC_Employee2.Visible = true;
            uC_Employee2.BringToFront();
            MovingPanel.Left = btnEmployee.Left + 18;
        }
    }
}
