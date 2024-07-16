using EmployeeClock.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClock
{
    internal static class Queries
    {
        static DBContext _dbContext = new DBContext();
        public static DataTable CheckIDAndPassword(string id)
        {
            string query = @$"SELECT Passwords.EmployeePassword, Employees.ID AS ID
                            FROM Passwords INNER JOIN Employees
                            ON Employees.ID = Passwords.EmployeeID
                            WHERE Employees.EmployeeNat = @id";
            List<SqlParameter> sqlParameters = new List<SqlParameter>()
            {
                new SqlParameter("@id", SqlDbType.VarChar) {Value = id},
            };
            DataTable dt = _dbContext.MakeQuery(query, sqlParameters.ToArray());
            //string json = JsonConvert.SerializeObject(dt, Formatting.Indented);
            return dt;
        }


        public static DataTable ShowLastEntry(string id)
        {
            string query = @$"SELECT TOP(1) * FROM EmployeeAttendance
                            INNER JOIN Employees ON Employees.ID = EmployeeAttendance.EmployeeCode
                            WHERE Employees.EmployeeNat = @id ORDER BY EmployeeAttendance.EntryTime DESC;";
            List<SqlParameter> sqlParameters = new List<SqlParameter>()
            {
                new SqlParameter("@id", SqlDbType.VarChar) {Value = id},
            };
            DataTable dt = _dbContext.MakeQuery(query, sqlParameters.ToArray());
            return dt;
        }


        public static DataTable ShowLastExit(string id)
        {
            string query = @$"SELECT TOP(1) * FROM EmployeeAttendance
                            INNER JOIN Employees ON Employees.ID = EmployeeAttendance.EmployeeCode
                            WHERE Employees.EmployeeNat = @id ORDER BY EmployeeAttendance.ExitTime DESC;";
            List<SqlParameter> sqlParameters = new List<SqlParameter>()
            {
                new SqlParameter("@id", SqlDbType.VarChar) {Value = id},
            };
            DataTable dt = _dbContext.MakeQuery(query, sqlParameters.ToArray());
            return dt;
        }


        public static int InsertEntryTime(int? id, DateTime date)
        {
            int rowsAffected;
            string query = @$"INSERT INTO EmployeeAttendance (EmployeeCode, EntryTime)
                            VALUES (@id, @date);";
            List<SqlParameter> sqlParameters = new List<SqlParameter>()
            {
                new SqlParameter("@id", SqlDbType.Int) {Value = id},
                new SqlParameter("@date", SqlDbType.DateTime) {Value = date},
            };
            rowsAffected = _dbContext.ExecuteNonQuery(query, sqlParameters.ToArray());
            
            return rowsAffected;
        }


        public static int UpdateExitTime(int? id,DateTime date)
        {
            int rowsAffected;
            string query = @$"UPDATE EmployeeAttendance SET ExitTime = @exitTime
                            WHERE EmployeeAttendance.EmployeeCode = @id;";
            List<SqlParameter> sqlParameters = new List<SqlParameter>()
            {
                new SqlParameter("@id", SqlDbType.Int) {Value = id},
                new SqlParameter("@exitTime", SqlDbType.DateTime) {Value = date},
            };
            rowsAffected = _dbContext.ExecuteNonQuery(query, sqlParameters.ToArray());
            return rowsAffected;
        }


        public static DataTable EnteredWithoutExiting(int? id)
        {
            string query = @$"SELECT TOP(1) * FROM EmployeeAttendance WHERE EmployeeAttendance.EmployeeCode = @id
                            ORDER BY EmployeeAttendance.EntryTime DESC;";
            List<SqlParameter> sqlParameters = new List<SqlParameter>()
            {
                new SqlParameter("@id", SqlDbType.Int) {Value = id},
            };
            DataTable dt = _dbContext.MakeQuery(query, sqlParameters.ToArray());
            return dt;
        }
        

        public static int ChangePassword(int id, string password)
        {
            string query = $@"UPDATE Passwords SET EmployeePassword = @password 
                            WHERE Passwords.EmployeeID = @id;";
            List<SqlParameter> sqlParameters = new List<SqlParameter>()
            {
                new SqlParameter("@id", SqlDbType.VarChar) {Value = id},
                new SqlParameter("@password", SqlDbType.VarChar) { Value = password},
            };
            int rowsAffected = _dbContext.ExecuteNonQuery(query, sqlParameters.ToArray());
            return rowsAffected;
        }
    }
}
