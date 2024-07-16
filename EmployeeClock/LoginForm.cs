using EmployeeClock.DAL;
using System.Data;
using Newtonsoft.Json;
using Formatting =  Newtonsoft.Json.Formatting;
using System.Data.SqlClient;

namespace EmployeeClock
{
    public partial class LoginForm : Form
    {
        private bool _flag = false;
        private DBContext _dbContext;
        public LoginForm(DBContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
        }

        private void button_LoginEnter_Click(object sender, EventArgs e)
        {
            string usernameID = textBox_LoginID.Text;
            string password = textBox_LoginPassword.Text;
            if (string.IsNullOrEmpty(usernameID) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("you have to fill the fields");
                return;
            }
            else if (usernameID.Length != 9)
            {
                MessageBox.Show("invalid ID");
                return;
            }
            DataTable res = Queries.CheckIDAndPassword(usernameID);
            if(res.Rows.Count <= 0)
            {
                MessageBox.Show("not found");
                return;
            }
            //MessageBox.Show(res.Rows[0]["EmployeePassword"].ToString());
            else if (res.Rows[0]["EmployeePassword"].ToString() != password)
            {
                MessageBox.Show("incorrect password");
            }
            else
            {
                MessageBox.Show("loged in successfuly");
                _flag = true;
                Navigator.ShowForm("ClockForm", usernameID, Convert.ToInt32(res.Rows[0]["ID"].ToString()));
            }
        }

        private void button_LoginChangePassword_Click(object sender, EventArgs e)
        {
            _flag = true;
            Navigator.ShowForm("PasswordChangeForm");
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!_flag)
                Application.Exit();
        }
    }
}
