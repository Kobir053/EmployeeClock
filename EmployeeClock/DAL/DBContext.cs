using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClock.DAL
{
    public class DBContext
    {
        private string _connectionString;

        // Data Source=LAPTOP-P5J1UI1F;User ID=sa;Password=1234;Connect Timeout=30;
        // Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False

        public DBContext()
        {
            _connectionString = GetConnectionString();
        }

        private string GetConnectionString()
        {
            // SET SECRETS.JSON TO COPY ALWAYS AFTER ADDING!!
            IConfiguration builder = new ConfigurationBuilder()
                .AddJsonFile("secret.json", optional: true) // Add secrets.json
                .Build();
            // Read a value from the configuration
            string connString = builder["ConnectionString"];
            if (string.IsNullOrEmpty(connString))
                throw new Exception("cannot read connection string from json");
            return connString;
        }

        public DataTable MakeQuery(string queryStr,params SqlParameter[] param)
        {
            DataTable output = new DataTable();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(queryStr, connection))
            {
                try
                {
                    connection.Open();
                    command.Parameters.AddRange(param);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(output);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("an error occurred: " + ex.Message);
                }
            }
            return output;

        }


        public int ExecuteNonQuery(string queryStr, params SqlParameter[] param)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(queryStr, connection))
            {
                try
                {
                    connection.Open();
                    command.Parameters.AddRange(param);
                    rowsAffected = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
            return rowsAffected;
        }
    }
}
