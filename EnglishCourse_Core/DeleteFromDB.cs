using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishCourse_Core
{
    public class DeleteFromDB
    {
        public static void DeleteCourse(int id)
        {
            Course obj = (Course)bd_connection.connection.Course.FirstOrDefault(p => p.id_Course == id);
            obj.isDeleted = true;
            bd_connection.connection.SaveChanges();
        }

        public static void DeleteLesson(int id)
        {
            Lesson obj = (Lesson)bd_connection.connection.Lesson.FirstOrDefault(p => p.id_Course == id);
            obj.isDelete = true;
            bd_connection.connection.SaveChanges();
        }

        public static void DeleteUserCourse(int id)
        {
            UserCourse obj = (UserCourse)bd_connection.connection.UserCourse.FirstOrDefault(p => p.id_Course == id);
            obj.isDeleted = true;
            bd_connection.connection.SaveChanges();
        }
    }
}
