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
using System.Windows.Shapes;
using EnglishCourse_Core;
namespace EnglishCourses.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        User currentUser;
        public AuthWindow()
        {
            InitializeComponent();
        }

        private void FIO_tb_TextChanged(object sender, TextChangedEventArgs e)
        {
            string[] fioSplit = FIO_tb.Text.Split(' ');
            if(fioSplit.Length < 3 || fioSplit[2] == "" )
            {
                FIO_tb.BorderBrush = Brushes.Red;
            }
            else
            {
                FIO_tb.BorderBrush = new SolidColorBrush(Color.FromRgb(103, 58, 183));
            }
        }

        private void registrationBtn_Click(object sender, RoutedEventArgs e)
        {
            if(FIO_tb.Text != "" && login_tb.Text != "" && pass_tb.Password != "0")
            {
                if (MainFunc.UniqueLogin(login_tb.Text))
                {
                   currentUser = MainFunc.Registration(FIO_tb.Text, login_tb.Text, pass_tb.Password);
                    MessageBox.Show("Пользователь успешно создан!");
                    MainPage.user = currentUser;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Пользователь с такой почтой уже существует");
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }

        private void AuthBtn_Click(object sender, RoutedEventArgs e)
        {
            if(loginAuth_tb.Text != "" && passAuth_pb.Password != "")
            {
                currentUser = MainFunc.Authorization(loginAuth_tb.Text, passAuth_pb.Password);
                if(currentUser == null)
                {
                    MessageBox.Show("Неверная почта или пароль");
                }
                else
                {
                    MessageBox.Show($"Добро пожаловать, {currentUser.Name}!");
                    MainPage.user = currentUser;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }
    }
}
