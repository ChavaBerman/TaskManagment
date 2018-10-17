using _01_DAL;
using _02_BOL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_BLL
{

    public static class UserLogic
    {

        public static List<User> GetAllUsers()
        {
            string query = $"USE taskmanagment; SELECT * FROM user";

            Func<MySqlDataReader, List<User>> func = (reader) => {
                List<User> users = new List<User>();
                while (reader.Read())
                {
                    users.Add(new User
                    {
                        IdUser = reader.GetInt32(0),
                        UserName = reader.GetString(1),
                        Password = reader.GetString(2),
                        Email = reader.GetString(3),
                        IdStatus= reader.GetInt32(4)
                    });
                }
                return users;
            };

            return DBAccess.RunReader(query, func);
        }

        //public static string GetUserName(int id)
        //{
        //    string query = $"SELECT Name FROM [dbo].[Users] WHERE Id={id}";
        //    return DBAccess.RunScalar(query).ToString();
        //}

        //public static bool RemoveUser(int id)
        //{
        //    string query = $"DELETE FROM [dbo].[Users] WHERE Id={id}";
        //    return DBAccess.RunNonQuery(query) == 1;
        //}

        //public static bool UpdateUser(User user)
        //{
        //    string query = $"UPDATE [dbo].[Users] SET Name='{user.UserName}', Age={user.Age}  WHERE Id={user.Id}";
        //    return DBAccess.RunNonQuery(query) == 1;
        //}

        //public static bool AddUser(User user)
        //{
        //    string query = $"INSERT INTO [dbo].[Users] VALUES ('{user.UserName}',{user.Age},{Convert.ToByte(user.IsMale)})";
        //    return DBAccess.RunNonQuery(query) == 1;
        //}
    }
}
