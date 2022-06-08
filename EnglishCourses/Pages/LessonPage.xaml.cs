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
    /// Логика взаимодействия для LessonPage.xaml
    /// </summary>
    public partial class LessonPage : Page
    {
        public List<Lesson> lessons;
        public LessonPage(int idCourse)
        {
            InitializeComponent();
            lessons = GetDataFromDB.GetLesson().Where(p => p.id_Course == idCourse).ToList();
            lessonsView.ItemsSource = lessons;
            this.DataContext = this;
        }

        private void lessonsView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var isSelected = lessonsView.SelectedItem as Lesson;
            if (isSelected != null)
            {
                navlessonFrame.NavigationService.Navigate(new LessonInfo(isSelected));
            }
        }
    }
}
