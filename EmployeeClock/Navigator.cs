using EmployeeClock.DAL;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EmployeeClock
{
    internal static class Navigator
    {
        static DBContext _dbContext = new DBContext();
        public static void CloseAllForms()
        {
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                Application.OpenForms[i]?.Close();
            }
        }

        public static void ShowForm(string formName, string? id = null, int? employeeID = null)
        {
            CloseAllForms();

            Form form = formName switch
            {
                "LoginForm" => new LoginForm(_dbContext),
                "ClockForm" => new ClockForm(_dbContext, id, employeeID),
                "PasswordChangeForm" => new PasswordChangeForm(_dbContext),
                _ => throw new ArgumentException("invalid form name ", nameof(formName))
            };
            form.Show();
        }
    }
}
