using EmployeeClock.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeClock
{
    public partial class ClockForm : Form
    {
        private int? _employeeID;
        private bool _flag = false;
        private DBContext _dbContext;
        public ClockForm(DBContext dbContext, string? id, int? employeeID)
        {
            InitializeComponent();
            _dbContext = dbContext;
            label_ClockEmployeeID.Text = id;
            _employeeID = employeeID;
            ShowEntry(id);
            ShowExit(id);
            EnterEnabled();
        }

        private void ShowEntry(string id)
        {
            DataTable res = Queries.ShowLastEntry(id);
            if (res.Rows.Count <= 0)
                return;
            label_ClockLastEntry.Text = res.Rows[0][2].ToString();
            //_employeeID = Convert.ToInt32(res.Rows[0]["EmployeeCode"].ToString());
            
            return;
        }

        private void ShowExit(string id)
        {
            DataTable res = Queries.ShowLastExit(id);
            if (res.Rows.Count <= 0)
                return;
            if(!string.IsNullOrEmpty(res.Rows[0][3].ToString()))
                label_ClockLastRelease.Text = res.Rows[0][3].ToString();
            return;
        }

        private void EmployeeEnter(int? id)
        {
            int res;
            DateTime date = DateTime.Now;
            res = Queries.InsertEntryTime(id, date);
            MessageBox.Show(res.ToString());
            EnterEnabled();
        }

        private void EmployeeLeave(int? id)
        {
            int res;
            DateTime date = DateTime.Now;
            res = Queries.UpdateExitTime(id, date);
            MessageBox.Show(res.ToString());
            EnterEnabled();
        }

        private void EnterEnabled()
        {
            DataTable res = Queries.EnteredWithoutExiting(_employeeID);
            if(res.Rows.Count == 0)
                return;
            if (string.IsNullOrEmpty(res.Rows[0][3].ToString()))
            {
                button_ClockEnter.Enabled = false;
                button_ClockRelease.Enabled = true;
            }
            else
            {
                button_ClockEnter.Enabled = true;
                button_ClockRelease.Enabled = false;
            }
        }

        private void ClockForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!_flag)
                Application.Exit();
        }

        private void button_ClockRelease_Click(object sender, EventArgs e)
        {
            EmployeeLeave(_employeeID);
        }

        private void linkLabel_ClockCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _flag = true;
            Navigator.ShowForm("LoginForm");
        }

        private void button_ClockEnter_Click(object sender, EventArgs e)
        {
            EmployeeEnter(_employeeID);
        }
    }
}
