using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using EnglishCourse_Core;
namespace EnglishCourses
{
    /// <summary>
    /// Логика взаимодействия для CourseMainPage.xaml
    /// </summary>
    public partial class CourseMainPage : Page
    {
        List<Course> courseList = GetDataFromDB.GetCourse();
        
        public CourseMainPage()
        {
            InitializeComponent();
            this.DataContext = this;
            lv_course.ItemsSource = courseList;

            foreach(Course course in courseList)
            {
                string ff = course.Teacher.Name;
                
            }
        }

        private void lv_course_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
