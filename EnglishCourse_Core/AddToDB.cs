using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishCourse_Core
{
    public class AddToDB
    {
        public static void addUser(User obj)
        {
            bd_connection.connection.User.Add(obj);
            bd_connection.connection.SaveChanges();
        }

        public static void addTeacher(Teacher obj)
        {
            bd_connection.connection.Teacher.Add(obj);
            bd_connection.connection.SaveChanges();
        }
        public static void addAuthorization(Authorization obj)
        {
            bd_connection.connection.Authorization.Add(obj);
            bd_connection.connection.SaveChanges();
        }
        public static void addCourse(Course obj)
        {
            bd_connection.connection.Course.Add(obj);
            bd_connection.connection.SaveChanges();
        }
        public static void addUserCourse(UserCourse obj)
        {
            bd_connection.connection.UserCourse.Add(obj);
            bd_connection.connection.SaveChanges();
        }
        public static void addLesson(Lesson obj)
        {
            bd_connection.connection.Lesson.Add(obj);
            bd_connection.connection.SaveChanges();
        }
    }
}
