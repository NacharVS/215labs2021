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
        public bool checkright;
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
            txtpass = null;
            

        }

        private void ButtonRegistration(object sender, RoutedEventArgs e)
        {


            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Users");
            IMongoCollection<User> collection = database.GetCollection<User>("Persons");

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
            if (txtname.Text == "")
            {
                MessageBox.Show("идиот");
            }



            if (checkright == true)
            {
                collection.InsertOne(new User(txtname.Text.Trim(), txtsurname.Text.Trim(), txtnumber.Text.Trim(), txtemail.Text.Trim(), txtpass.Password.Trim()));
                ClearAll();
            }
        }
    }
}
