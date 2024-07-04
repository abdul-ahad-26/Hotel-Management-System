using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace WindowsFormsApp3.All_User_Control
{
    public partial class UC_Employee : UserControl
    {
        function fn = new function();
        String query;
        public UC_Employee()
        {
            InitializeComponent();
        }

        private void UC_Employee_Load(object sender, EventArgs e)
        {
            getMaxId();
        }
       
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtMobile.Text != "" && txtGender.Text != "" && txtEmail.Text != "" && txtUsername.Text != "" && txtPassword.Text != "")
            {

                String name = txtName.Text;
                Int64 mobile = Int64.Parse(txtMobile.Text);
                String gender = txtGender.Text;
                String email = txtEmail.Text;
                String username = txtUsername.Text;
                String password = txtPassword.Text;

                query = "insert into  employee (ename,mobile,gender,emailid,username,pass) values('" + name + "'," + mobile + ",'" + gender + "','" + email + "','" + username + "','" + password + "')";
                fn.setData(query, "Employee Registered.");
                clearAll();
                getMaxId();

            }
            else
            {
                MessageBox.Show("Fil all Fields.", "Warning...!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                if (MessageBox.Show("Are You sure", "Confirmation ....!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==  DialogResult.Yes) 
                { query = "delete from employee where eid = " + txtID.Text + "";
                    fn.setData(query, "Record Deleted.");
                    tabEmployee_SelectedIndexChanged(this, null);
                }
            }
        }
        private void UC_Employee_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void tabEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabEmployee.SelectedIndex == 1)
            {
                setEmployee(guna2DataGridView1);
            }
            else if (tabEmployee.SelectedIndex == 2)
            {
                setEmployee(guna2DataGridView2);
            }
        }

        /// ///////////////////////////////////  required method //////////////////
        private void getMaxId()
        {
            query = "select max(eid) from employee";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                labelToSET.Text = (num + 1).ToString();
            }
        }

        public void clearAll()
        {
            txtName.Clear();
            txtMobile.Clear();
            txtGender.SelectedIndex = -1;
            txtEmail.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
        }
        public void setEmployee(DataGridView dgv)
        {
            query = "Select * from Employee";
            DataSet ds = fn.getData(query);
            dgv.DataSource = ds.Tables[0];

        }


    }
}
