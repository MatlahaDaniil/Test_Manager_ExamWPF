using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows;
using System.Threading;

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
            dbContext = new DataContext(ConnectionString);

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
            Thread.Sleep(500);

            if (User == "Teacher")
            {
                var logins = from i in dbContext.GetTable<TeacherTable>()
                         select i.Login;

                foreach (var item in logins)
                {
                    if (item == login) return "ex: Такий логін вже існує!";
                }

            }
            else
            {
                var logins = from i in dbContext.GetTable<StudentTable>()
                         select i.Login;

                foreach (var item in logins)
                {
                    if (item == login) return "ex: Такий логін вже існує!";
                }

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
            Thread.Sleep(500);

            if (User == "Teacher")
            {
                var list_db = from i in dbContext.GetTable<TeacherTable>()
                              select new { Login = i.Login, Password = i.Password };

                foreach (var item in list_db)
                {
                    if (item.Login == login && item.Password == password)
                        return "successful";
                }
            }
            if(User == "Student")
            {
                var list_db = from i in dbContext.GetTable<StudentTable>()
                              select new { Login = i.Login, Password = i.Password };

                foreach (var item in list_db)
                {
                    if (item.Login == login && item.Password == password)
                        return "successful";
                }
            }
            
            return "ex: Не існує такого логіну або паролю!";
        }

        public string EditAcc(string User, string Fullname , string Email,
                              string PhoneNum , string SchoolNum, string login , byte[] ProfileIcon = null, int ClassNum = 0) 
        {
            string command;
            if (User == "Teacher")
            {
                command = $"update [Teacher] " +
                          $"Set [Fullname] = '{Fullname}', [Email] = '{Email}', [PhoneNum] = '{PhoneNum}', " +
                          $"[SchoolNum] = '{SchoolNum}' " /*, [ProfileIcon] = '{ProfileIcon}' "*/ +
                          $"Where [Login] = '{login}'";

                SqlCommand cmd = new SqlCommand(command, dbConnection);

                cmd.ExecuteNonQuery();

            }
            else
            {
                command = $"insert into [{User}]([Fullname],[Email],[PhoneNum],[SchoolNum],[ProfileIcon],[ClassNum])" +
                          $"values(@login,@password,@fullname,@email,@phoneNum,@schoolNum,@profileIcon , @classnum )";

                SqlCommand cmd = new SqlCommand(command, dbConnection);

                 cmd.ExecuteNonQuery();
             
            }

            return "successful";
        }
        public void EditProfileIcon(string User , string login , byte[] ProfileIcon)
        {
            try
            {
                string command = $"update [{User}] " +
                                 $"Set [ProfileIcon] = @profileIcon " +
                                 $"Where [Login] = '{login}'";

                SqlCommand cmd = new SqlCommand(command, dbConnection);

                cmd.Parameters.Add(new SqlParameter("@profileIcon", System.Data.SqlDbType.VarBinary, ProfileIcon.Length) { Value = ProfileIcon });

                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public string GetStringInfo(string User , string login)
        {
            if (User == "Teacher")
            {
                var list_db = from i in dbContext.GetTable<TeacherTable>()
                              select new { Login = i.Login, Fullname = i.Fullname, Email = i.Email, PhoneNum = i.PhoneNum, SchoolNum = i.SchoolNum };

                foreach (var item in list_db)
                {
                    if (item.Login == login)
                        return $"infoString:|{item.Fullname}|{item.Email}|{item.PhoneNum}|{item.SchoolNum}";
                }


            }
            //if (User == "Student")
            //{
            //    var list_db = from i in dbContext.GetTable<StudentTable>()
            //                  select new { Login = i.Login, Password = i.Password };

            //    foreach (var item in list_db)
            //    {
            //        if (item.Login == login && item.Password == password)
            //            return "successful";
            //    }
            //}
            return "successful";
        }

        public bool CheckProfileIcon(string User , string login)
        {
            if (User == "Teacher")
            {
                var list_db = from i in dbContext.GetTable<TeacherTable>()
                              select new { Login = i.Login, ProfileIcon = i.ProfileIcon };

                foreach (var item in list_db)
                {
                    if (item.Login == login)
                        if(item.ProfileIcon == null) return false;
                }
            }
            else
            {

            }
            return true;
        }

        public string GetImageLength(string User, string login)
        {
            if (User == "Teacher")
            {
                var list_db = from i in dbContext.GetTable<TeacherTable>()
                              select new { Login = i.Login , ProfileIcon = i.ProfileIcon };

                foreach (var item in list_db)
                {
                    if (item.Login == login)
                    {
                        return $"img: {item.ProfileIcon.Length}";
                    }
                }
            }
            //if (User == "Student")
            //{
            //    var list_db = from i in dbContext.GetTable<StudentTable>()
            //                  select new { Login = i.Login, Password = i.Password };

            //    foreach (var item in list_db)
            //    {
            //        if (item.Login == login && item.Password == password)
            //            return "successful";
            //    }
            //}
            return "successful";
        }
        public byte[] GetImage(string User, string login)
        {
            if (User == "Teacher")
            {
                var list_db = from i in dbContext.GetTable<TeacherTable>()
                              select new { Login = i.Login, ProfileIcon = i.ProfileIcon };

                foreach (var item in list_db)
                {
                    if (item.Login == login)
                    {
                        return item.ProfileIcon;
                    }
                }
            }
            //if (User == "Student")
            //{
            //    var list_db = from i in dbContext.GetTable<StudentTable>()
            //                  select new { Login = i.Login, Password = i.Password };

            //    foreach (var item in list_db)
            //    {
            //        if (item.Login == login && item.Password == password)
            //            return "successful";
            //    }
            //}
            return null;
        }

        public void Dispose()
        {
            dbConnection?.Close();
        }
    }
}
