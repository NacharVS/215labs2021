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
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }


        private void ButtonAuthorization_Click(object sender, RoutedEventArgs e)
        {
            bool checkright = true;
            string email = txtemaillog.Text.Trim();
            string pass = txtpasslog.Password.Trim();


            txtemaillog.Background = Brushes.Transparent;
            txtpasslog.Background = Brushes.Transparent;



            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Users");
            IMongoCollection<User> collection = database.GetCollection<User>("Persons");



            if (txtemaillog.Text.Length < 6 || !txtemaillog.Text.Contains('@') || !txtemaillog.Text.Contains('.'))
            {
                txtemaillog.ToolTip = "Поле введено некорректно. Проверьте данные!";
                txtemaillog.Background = Brushes.Red;
                checkright = false;

            }
            if (txtpasslog.Password.Length < 8)
            {
                txtpasslog.ToolTip = "Поле введено некорректно. Проверьте данные!";
                txtpasslog.Background = Brushes.Red;
                checkright = false;

            }





            List<User> list = collection.Find(x => pass == x.Password && x.Email == email).ToList(); 
            if (list.Count <= 0)
            {
                MessageBox.Show("Логин с паролем не совпадают! Проверьте правильность введённых данных.");
                txtemaillog.Background = Brushes.Red;
                txtemaillog.ToolTip = "Логин не совпадает с паролем";
                txtpasslog.ToolTip = "Пароль не совпадает с логином";
                txtpasslog.Background = Brushes.Red;
                checkright = false;
            }





            if (checkright == true)
            {
                User.logemail = email;
                User.logpass = pass;
                
                txtemaillog.ToolTip = "";
                txtpasslog.ToolTip = "";
                txtemaillog.Background = Brushes.Transparent;
                txtpasslog.Background = Brushes.Transparent;

                
                MessageBox.Show("Поздравляем. Вы успешно авторизовались в личном кабинете ScamShop!");
                ClearAll();
                PersonalAccountWin PAWindow = new PersonalAccountWin();
                PAWindow.Show();
                Hide();
            }
            

        }
        public void ClearAll()
        {
            txtemaillog.Text = "";
            txtpasslog.Password = "";

        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Hide();
        }
    }
}
