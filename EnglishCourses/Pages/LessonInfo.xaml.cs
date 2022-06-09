using EnglishCourse_Core;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для LessonInfo.xaml
    /// </summary>
    public partial class LessonInfo : Page
    {
        private Lesson _lesson;

        public LessonInfo(Lesson lesson)
        {
            InitializeComponent();

            this.DataContext = this;
            if (lesson.Header != null)
            {
                TitleTB.Text = lesson.Header;
            } 
            if(lesson.id_Theme != null)
            {
                ThemeTB.Text = lesson.Theme.Name;
            }
            if(lesson.Description != null)
            {
                DiscrpTB.Text = lesson.Description;
            }
            if(lesson.Image != null)
            {
                LessonImg.Source = ByteToImage(lesson.Image);
            }

        }

        public static ImageSource ByteToImage(byte[] imageData)
        {
            BitmapImage biImg = new BitmapImage();
            MemoryStream ms = new MemoryStream(imageData);
            biImg.BeginInit();
            biImg.StreamSource = ms;
            biImg.EndInit();

            ImageSource imgSrc = biImg as ImageSource;

            return imgSrc;
        }
    }
}
