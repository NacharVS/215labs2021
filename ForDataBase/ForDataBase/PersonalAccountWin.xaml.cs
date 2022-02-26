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

namespace ForDataBase
{
    /// <summary>
    /// Логика взаимодействия для PersonalAccountWin.xaml
    /// </summary>
    public partial class PersonalAccountWin : Window
    {
        public PersonalAccountWin()
        {
            InitializeComponent();
            
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Users");
            IMongoCollection<User> collection = database.GetCollection<User>("Persons");
            User loguser;
            loguser = collection.Find(x => x.Password == User.logpass && x.Email == User.logemail).FirstOrDefault();
            hellotextblock.Text = "Привет, " + loguser.Name + "!";
            if (loguser != null)
            {
                fornametxt.Text = loguser.Name;
                forsurnametxt.Text = loguser.Surname;
                fornumbertxt.Text = loguser.Phonenumber;
            }
        }


        private void logoutbtn_Click(object sender, RoutedEventArgs e)
        {
            User.logemail = null;
            User.logpass = null;
            AuthWindow authWindow = new AuthWindow();
            authWindow.Show();
            Hide();
        }

        private void btnchangeinfo_Click(object sender, RoutedEventArgs e)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Users");
            IMongoCollection<User> collection = database.GetCollection<User>("Persons");
            bool checkright = true;

            fornametxt.ToolTip = default;
            fornumbertxt.ToolTip = default;
            forpasstxt.ToolTip = default;
            forsurnametxt.ToolTip = default;

            fornametxt.Background = Brushes.Transparent;
            forsurnametxt.Background = Brushes.Transparent;
            fornumbertxt.Background = Brushes.Transparent;
            forpasstxt.Background = Brushes.Transparent;
            
            
           


            if (forpasstxt.Password != User.logpass)
            {
                forpasstxt.ToolTip = "Пароль не совпадает с указанным при регистрации. Проверьте его!";
                forpasstxt.Background = Brushes.Red;
                checkright = false;
            }


            if (fornametxt.Text.Length <= 1)
            {
                fornametxt.ToolTip = "Поле введено некорректно. Проверьте данные!";
                fornametxt.Background = Brushes.Red;
                checkright = false;

            }
            if (forsurnametxt.Text.Length <= 1)
            {
                forsurnametxt.ToolTip = "Поле введено некорректно. Проверьте данные!";
                forsurnametxt.Background = Brushes.Red;
                checkright = false;

            }

            if (fornumbertxt.Text.Length > 12 || fornumbertxt.Text.Length < 11)
            {
                fornumbertxt.ToolTip = "Поле введено некорректно. Проверьте данные!";
                fornumbertxt.Background = Brushes.Red;
                checkright = false;

            }

            if (checkright == true)
            {
                collection.ReplaceOne(x => x.Email == User.logemail, new User(fornametxt.Text.Trim(), forsurnametxt.Text.Trim(), fornumbertxt.Text.Trim(), User.logemail, User.logpass));
                hellotextblock.Text = "Привет, " + fornametxt.Text + "!";
                forpasstxt.Password = default;
                MessageBox.Show("Данные успешно изменены!");
                

            }
        }
           
    }
}
