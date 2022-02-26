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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ForDataBase
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
            txtname.Text = "";
            txtsurname.Text = "";
            txtnumber.Text = "";
            txtemail.Text = "";
            txtpass.Password = "";
            txtrepass.Password = "";


        }
        private void ButtonRegistration(object sender, RoutedEventArgs e)
        {
            

            txtemail.ToolTip = "";
            txtpass.ToolTip = "";
            txtrepass.ToolTip = "";
            txtnumber.ToolTip = "";
            txtsurname.ToolTip = "";
            txtname.ToolTip = "";

            txtemail.Background = Brushes.Transparent;
            txtpass.Background = Brushes.Transparent;
            txtname.Background = Brushes.Transparent;
            txtsurname.Background = Brushes.Transparent;
            txtrepass.Background = Brushes.Transparent;
            txtnumber.Background = Brushes.Transparent;


            bool checkright = true;
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Users");
            IMongoCollection<User> collection = database.GetCollection<User>("Persons");

            if (txtpass.Password != txtrepass.Password)
            {
                txtpass.ToolTip = "Пароли не совпадают. Проверьте их правильность!";
                txtpass.Background = Brushes.Red;
                txtrepass.ToolTip = "Пароли не совпадают. Проверьте их правильность!";
                txtrepass.Background = Brushes.Red;
                checkright = false;
            }

            if (txtemail.Text.Length < 6 || !txtemail.Text.Contains('@') || !txtemail.Text.Contains('.'))
            {
                txtemail.ToolTip = "Поле введено некорректно. Проверьте данные!";
                txtemail.Background = Brushes.Red;
                checkright = false;

            }
            if (txtpass.Password.Length < 8)
            {
                txtpass.ToolTip = "Поле введено некорректно. Проверьте данные!";
                txtpass.Background = Brushes.Red;
                checkright = false;

            }
            if (txtname.Text.Length <= 1)
            {
                txtname.ToolTip = "Поле введено некорректно. Проверьте данные!";
                txtname.Background = Brushes.Red;
                checkright = false;

            }
            if (txtsurname.Text.Length <= 1)
            {
                txtsurname.ToolTip = "Поле введено некорректно. Проверьте данные!";
                txtsurname.Background = Brushes.Red;
                checkright = false;

            }


            if (txtrepass.Password.Length < 8)
            {
                txtrepass.ToolTip = "Поле введено некорректно. Проверьте данные!";
                txtrepass.Background = Brushes.Red;
                checkright = false;

            }
            if (txtnumber.Text.Length > 12 || txtnumber.Text.Length < 11)
            {
                txtnumber.ToolTip = "Поле введено некорректно. Проверьте данные!";
                txtnumber.Background = Brushes.Red;
                checkright = false;

            }



            List<User> list = collection.Find(x => x.Phonenumber == txtnumber.Text).ToList();
            if (list.Count > 0)
            {
                MessageBox.Show("Пользователь с данным телефоном уже зарегистрирован!");
                checkright = false;
            }
            List<User> list2 = collection.Find(x => x.Email == txtemail.Text).ToList();
            if (list.Count > 0)
            {
                checkright = false;
                MessageBox.Show("Пользователь с данным e-mail уже зарегистрирован!");
            }




            if (checkright == true)
            {
                txtemail.ToolTip = "";
                txtpass.ToolTip = "";
                txtrepass.ToolTip = "";
                txtnumber.ToolTip = "";
                txtsurname.ToolTip = "";
                txtname.ToolTip = "";

                txtname.Background = Brushes.Transparent;
                txtsurname.Background = Brushes.Transparent;
                txtemail.Background = Brushes.Transparent;
                txtpass.Background = Brushes.Transparent;
                txtrepass.Background = Brushes.Transparent;
                txtnumber.Background = Brushes.Transparent;
                collection.InsertOne(new User(txtname.Text.Trim(), txtsurname.Text.Trim(), txtnumber.Text.Trim(), txtemail.Text.Trim(), txtpass.Password.Trim()));
                MessageBox.Show("Поздравляем. Вы успешно зарегистрировались в ScamShop!");
                ClearAll();

                AuthWindow authWindow = new AuthWindow();
                authWindow.Show();
                Hide();
            }
        }

        private void ButtonToLogWindow(object sender, RoutedEventArgs e)
        {
            AuthWindow authWindow = new AuthWindow();
            authWindow.Show();
            Hide();
        }
    }
}
