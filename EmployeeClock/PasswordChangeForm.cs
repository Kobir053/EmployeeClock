using EmployeeClock.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeClock
{
    public partial class PasswordChangeForm : Form
    {
        private bool _flag = false;
        private DBContext _dbContext;
        public PasswordChangeForm(DBContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
        }

        private void PasswordChangeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!_flag)
                Application.Exit();
        }

        private void button_Change_ChangeMyPassword_Click(object sender, EventArgs e)
        {
            string id = textBox_Change_ID.Text;
            string oldPass = textBox_Change_Password.Text;
            string newPass = textBox_Change_NewPassword.Text;
            string verifyPass = textBox_Change_VerifyNewPassword.Text;
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(oldPass) || string.IsNullOrEmpty(newPass) || string.IsNullOrEmpty(verifyPass))
            {
                MessageBox.Show("you have to fill all the fields");
                return;
            }
            else if (newPass != verifyPass)
            { 
                MessageBox.Show("please verify your password");
                return;
            }
            DataTable res = Queries.CheckIDAndPassword(id);
            if (res.Rows.Count <= 0)
            {
                MessageBox.Show("not found");
                return;
            }
            //MessageBox.Show(res.Rows[0]["EmployeePassword"].ToString());
            else if (res.Rows[0]["EmployeePassword"].ToString() != oldPass)
            {
                MessageBox.Show("incorrect password");
            }
            else
            {
                int employeeID = Convert.ToInt32(res.Rows[0]["ID"]);
                int answer = Queries.ChangePassword(employeeID, newPass);
                if (answer > 0)
                {
                    MessageBox.Show("password changed successfuly");
                    _flag = true;
                    Navigator.ShowForm("LoginForm");
                }
            }
        }

        private void linkLabel__LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _flag = true;
            Navigator.ShowForm("LoginForm");
        }
    }
}
