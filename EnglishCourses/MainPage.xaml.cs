using EnglishCourse_Core;
using EnglishCourses.Pages;
using EnglishCourses.Windows;
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

namespace EnglishCourses
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public static User user;
        public MainPage()
        {
            InitializeComponent();
        }
        private void СourseBtn_Click(object sender, RoutedEventArgs e)
        {
            AuthWindow authWindow = new AuthWindow();
            authWindow.ShowDialog();
        }

        private void Learning_btn_Click(object sender, RoutedEventArgs e)
        {
            if(user != null)
            {
                CurseMainPage page = new CurseMainPage();
                NavigationService.Navigate(page);
                return;
            }
            AuthWindow authWindow = new AuthWindow();
            authWindow.ShowDialog();
        }
    }
}
