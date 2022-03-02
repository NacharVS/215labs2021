using System;
using MongoDB.Driver;
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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
public void ClearAll()
        {
            tbpass.Password = "";
            tbpass2.Password = "";
            tblogin.Text = "";
            tbmail.Text = "";

        }
        


        private void btregnew_Click(object sender, RoutedEventArgs e)
        {
            
            bool checkright = true;
            string pass = tbpass.Password.Trim();
            string pass2 = tbpass2.Password.Trim();
            string login = tblogin.Text.Trim();
            string email = tbmail.Text.Trim();

            tbpass.Background = Brushes.Transparent;
            tbpass2.Background = Brushes.Transparent;
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("users");
            IMongoCollection<User> collection = database.GetCollection<User>("Persons");
            
            if (pass!= pass2)
            {
                tbpass.ToolTip = "Пароли не совпадают. Проверьте их правильность!";
                tbpass.Background = Brushes.IndianRed;
                tbpass2.ToolTip = "Пароли не совпадают. Проверьте их правильность!";
                tbpass2.Background = Brushes.IndianRed;
                checkright = false;

            }
            if (login.Length < 8)
            {
                tblogin.ToolTip = "Логин должен иметь длину не меньше 8 символов!";
                tblogin.Background = Brushes.IndianRed;
  
                checkright = false;

            }
            if (email.Length < 6 || !email.Contains('@') || !email.Contains('.'))
            {
                tbmail.ToolTip = "Поле введено некорректно. Проверьте данные!";
                tbmail.Background = Brushes.IndianRed;
                checkright = false;

            }
            if (checkright == true)
            {
                tblogin.ToolTip = "";
                tbpass.ToolTip = "";
                tbmail.ToolTip = "";
                tbpass2.ToolTip = "";

                tblogin.Background = Brushes.Transparent;
                tbpass.Background = Brushes.Transparent;
                tbmail.Background = Brushes.Transparent;
                tbpass2.Background = Brushes.Transparent;
                collection.InsertOne(new User(tblogin.Text, tbpass.Password, tbpass2.Password, tbmail.Text));
                MessageBox.Show("Вы успешно зарегистрировались!");
                ClearAll();
                
            }

        }

        private void btAu_Click(object sender, RoutedEventArgs e)
        {
            Window1 autwin = new Window1();
            autwin.Show();
            Hide();
        }
    }
}