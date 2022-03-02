using MongoDB.Driver;
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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        public void ClearAll()
        {
            tbpass.Password = "";
           
            tblogin.Text = "";
          

        }


        private void btregnew_Click(object sender, RoutedEventArgs e)
        {
            bool checkright = true;
            string login = tblogin.Text.Trim();
            string pass = tbpass.Password.Trim();

            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("users");
            IMongoCollection<User> collection = database.GetCollection<User>("Persons");
            if (login.Length<6)
            {
                tblogin.ToolTip = "Поле введено некорректно. Проверьте данные!";
                tblogin.Background = Brushes.IndianRed;
                checkright = false;


            }
            List<User> list = collection.Find(x => pass ==x.Password && login == x.Name).ToList();
            if (list.Count <= 0)
            {
                MessageBox.Show("Логин с паролем не совпадают! Проверьте правильность введённых данных.");
                tblogin.Background = Brushes.Red;
                tblogin.ToolTip = "Логин не совпадает с паролем";
                tbpass.ToolTip = "Пароль не совпадает с логином";
                tbpass.Background = Brushes.Red;
                checkright = false;
            }

            if (checkright == true)
            {
                tblogin.ToolTip = "";
                tbpass.ToolTip = "";
                

                tblogin.Background = Brushes.Transparent;
                tbpass.Background = Brushes.Transparent;
               
              
                MessageBox.Show("Вы Вошли!");
                ClearAll();

            }

        }

        private void btreg_Click(object sender, RoutedEventArgs e)
        {
            MainWindow regwin = new MainWindow();
            regwin.Show();
            Hide();
        }
    }
}
