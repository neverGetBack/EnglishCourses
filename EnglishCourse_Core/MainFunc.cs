using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishCourse_Core
{
    public class MainFunc
    {
        public static Authorization Authorization(string login, string password)
        {
            return bd_connection.connection.Authorization.FirstOrDefault(p => p.Login == login && p.Password == password);
        }
    }
}
