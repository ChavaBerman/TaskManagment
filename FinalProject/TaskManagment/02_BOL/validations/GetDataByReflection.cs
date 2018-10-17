using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _02_BOL.validations
{
   static class GetDataByReflection
    {
        public static List<User> GetUsers()
        {

            //1. Load 'BLL' project
            Assembly assembly = Assembly.LoadFrom(@"~\03_BLL\bin\Debug\03_BLL.dll");

            //2. Get 'UserService' type
            Type userLogicType = assembly.GetTypes().First(t => t.Name.Equals("UserLogic"));

            //3. Get 'GetAllUsers' method
            MethodInfo getAllUsersMethod = userLogicType.GetMethods().First(m => m.Name.Equals("GetAllUsers"));

            //4. Invoke this method
            return getAllUsersMethod.Invoke(Activator.CreateInstance(userLogicType), new object[] { }) as List<User>;

        }
    }
}
