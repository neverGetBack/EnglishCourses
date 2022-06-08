using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishCourse_Core
{
    public class MainFunc
    {
        public static User Authorization(string login, string password)
        {
            int auth = bd_connection.connection.Authorization.FirstOrDefault(p => p.Login == login && p.Password == password).id_Auth;
            if(auth != 0)
            {
                return bd_connection.connection.User.FirstOrDefault(p => p.id_Auth == auth);
            }
            else
            {
                return null;
            }
            
        }

        public static User Registration(string FIO, string login, string password)
        {
            Authorization authorization = new Authorization();
            authorization.Login = login;
            authorization.Password = password;
            authorization.id_Role = 2;
            AddToDB.addAuthorization(authorization);

            User user = new User();
            string[] fioSplit = FIO.Split(' ');
            user.Name = fioSplit[1];
            user.Surname = fioSplit[0];
            user.Patronymic = fioSplit[2];
            user.id_Auth = GetDataFromDB.GetAuthorization().FirstOrDefault(p => p.Login == login).id_Auth;
            AddToDB.addUser(user);
            return user;
        }

        public static bool UniqueLogin(string login)
        {
            List<Authorization> authorization = GetDataFromDB.GetAuthorization();
            bool login_unic = true;
            foreach (var i in authorization)
            {
                if (i.Login == login)
                {
                    login_unic = false;
                }
            }
            return login_unic;
        }
    }
}
