using EnglishCourse_Core;
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

namespace EnglishCourses.Pages
{
    /// <summary>
    /// Логика взаимодействия для CurseMainPage.xaml
    /// </summary>
    public partial class CurseMainPage : Page
    {
        List<Course> courseList = GetDataFromDB.GetCourse();

        public CurseMainPage()
        {
            InitializeComponent();
            
            this.DataContext = this;
            lv_course.ItemsSource = courseList;

            foreach (Course course in courseList)
            {
                string ff = course.Teacher.Name;

            }
        }

        private void lv_course_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //var isSelected = lv_course.SelectedItem as Course;
            //if (isSelected != null)
            //{
            //    NavigationService.Navigate(new LessonPage(isSelected.id_Course));
            //}
        }

        private void siqnForLesson_Click(object sender, RoutedEventArgs e)
        {
            var span = sender as Button;
            var idCourse = span.CommandParameter;

            if (idCourse != null)
            {
                NavigationService.Navigate(new LessonPage((int)idCourse));
            }
        }

        private void GoBackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}
