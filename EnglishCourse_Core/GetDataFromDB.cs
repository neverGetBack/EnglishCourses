using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishCourse_Core
{
    public class GetDataFromDB
    {
        public static List<User> GetUser()
        {
            return bd_connection.connection.User.ToList();
        }

        public static List<Teacher> GetTeacher()
        {
            return bd_connection.connection.Teacher.ToList();
        }

        public static List<Authorization> GetAuthorization()
        {
            return bd_connection.connection.Authorization.ToList();
        }

        public static List<Role> GetRole()
        {
            return bd_connection.connection.Role.ToList();
        }

        public static List<UserCourse> GetUserCourse()
        {
            return (List<UserCourse>)bd_connection.connection.UserCourse.ToList().Where(p => p.isDeleted == false);
        }

        public static List<Course> GetCourse()
        {
            return (List<Course>)bd_connection.connection.Course.ToList().Where(p => p.isDeleted == false);
        }

        public static List<Lesson> GetLesson()
        {
            return (List<Lesson>)bd_connection.connection.Lesson.ToList().Where(p => p.isDelete == false);
        }

        public static List<Theme> GetTheme()
        {
            return bd_connection.connection.Theme.ToList();
        }
    }
}
