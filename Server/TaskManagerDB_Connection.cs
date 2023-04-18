using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data.Linq;

namespace Server
{
    internal class TaskManagerDB_Connection : IDisposable
    {
        private SqlConnection dbConnection;
        private const string ConnectionString = "Data Source=DESKTOP-Q6M74QL\\SQLEXPRESS;Initial Catalog = TestManagerDB; Encrypt=false; Integrated Security=true";
        DataContext dbContext;

        public TaskManagerDB_Connection()
        {
            dbConnection = new SqlConnection(ConnectionString);

            try
            {
                dbConnection.Open();
            }
            catch
            {
                return;
            }
        }

        public List<string> GetInfo_Req (string req)
        {
            List<string> Info = new List<string>();

            SqlCommand cmd = new SqlCommand(req, dbConnection);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Info.Add(reader.GetString(0));
                }
            }
            return Info;
        }

        public string RegisterNewAcc(string User , string login , string password)
        {

            var list_logins = from i in dbContext.GetTable<TeacherTable>()
                              select i.Login; 

            foreach (var item in list_logins)
            {
                if (item == login) return "ex: Такий логін вже існує!";
            }

            string command = $"insert into [{User}]([Login],[Password]) values(@login,@password)";

            SqlCommand cmd = new SqlCommand(command, dbConnection);

            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SqlParameter("@login", login));
                cmd.Parameters.Add(new SqlParameter("@password", password));
            }
            finally
            {
                cmd.ExecuteNonQuery();
            }   

            return "successful";
        }

        public string AuthenticationAcc(string User, string login, string password)
        {
            List<string> list_db = GetInfo_Req("select [login],[password] from teacher");

            return "successful";
        }

        public void SetInfo_Req(string req) 
        {
            dbConnection.Open();
        }

        public void Dispose()
        {
            dbConnection?.Close();
        }
    }
}
