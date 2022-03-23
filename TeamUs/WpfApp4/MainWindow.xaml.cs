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

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("user");
            IMongoCollection<User> collection = database.GetCollection<User>("user");
            //List<User> allusers;
            //allusers = collection.Find(x => true).ToList();
            //listfrombd.ItemsSource = GetAllLogin();

            //forteamslist.ItemsSource = GetAllTeams();
        }
        private void btnreg_Click(object sender, RoutedEventArgs e)
        {
            txtlogin.Background = Brushes.Transparent;
            txtemail.Background = Brushes.Transparent;

            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("user");
            IMongoCollection<User> collection = database.GetCollection<User>("user");
            bool checkright = true;
            if (txtemail.Text.Length < 1)
            {
                checkright = false;
                txtemail.Background = Brushes.Red;
                txtemail.ToolTip = "Введите правильный майл";
            }
            if (txtlogin.Text.Length < 1)
            {
                checkright = false;
                txtlogin.Background = Brushes.Red;
                txtlogin.ToolTip = "Введите правильный логин";
            }
            if (checkright == true)
                collection.InsertOne(new User(txtname.Text.Trim(), txtsurname.Text.Trim(), txtemail.Text.Trim(), txtlogin.Text.Trim()));

            List<User> allusers;
            allusers = collection.Find(x => true).ToList();
            listfrombd.ItemsSource = GetAllLogin();





        }
        //public static List<string> GetAllTeams()
        //{
        //    var client = new MongoClient("mongodb://localhost");
        //    var database = client.GetDatabase("user");
        //    IMongoCollection<Team> collection = database.GetCollection<Team>("teams");
        //    List<string> listteams = new List<string>();
        //    foreach (var item in collection.Find(x => true).ToList())
        //    {
        //        listteams.Add(item.Name);

        //    }

        //    return listteams;

        //}
        public static List<string> GetAllLogin()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("user");
            IMongoCollection<User> collection = database.GetCollection<User>("user");
            List<string> listlogins = new List<string>();
            foreach (var item in collection.Find(x => true).ToList())
            {
                listlogins.Add(item.Login);
            }

            return listlogins;
        }
        private void listfrombd_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("user");
            IMongoCollection<User> collection = database.GetCollection<User>("user");
            bool check = true;
            if (forcreatelist.Items.Count < 5)
            {
                if (forcreatelist.Items.Count > 0)
                {
                    for (int i = 0; i < forcreatelist.Items.Count; i++)
                    {
                        if (listfrombd.SelectedItem.ToString() == forcreatelist.Items[i].ToString())
                            check = false;

                    }
                    if (check == true)
                        forcreatelist.Items.Add(listfrombd.SelectedItem);

                }
                else
                    forcreatelist.Items.Add(listfrombd.SelectedItem);
            }



        }
        private void btncustom_Click(object sender, RoutedEventArgs e)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("user");
            IMongoCollection<Team> collection = database.GetCollection<Team>("teams");

            if (forcreatelist.Items.Count == 5 && txtteamname.Text.Length > 1)
            {
                collection.InsertOne(new Team(txtteamname.Text, forcreatelist.Items[0].ToString(), forcreatelist.Items[1].ToString(), forcreatelist.Items[2].ToString(), forcreatelist.Items[3].ToString(), forcreatelist.Items[4].ToString()));

                while (forcreatelist.Items.Count > 0)
                {
                    forcreatelist.Items.Remove(forcreatelist.Items[0]);
                }



            }
            else
            {
                txtteamname.Background = Brushes.Red;
                txtteamname.ToolTip = "Введите норм название ком-анды и посмомотрите сколько кол-во участников";
            }


        }
        private void forcreatelist_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            forcreatelist.Items.Remove(forcreatelist.SelectedItem);
        }
        private void forteamslist_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            while (forcreatelist.Items.Count > 0)
            {
                forcreatelist.Items.Remove(forcreatelist.Items[0]);
            }

            if (forcreatelist.Items.Count < 5)
            {
                var client = new MongoClient("mongodb://localhost");
                var database = client.GetDatabase("user");
                IMongoCollection<Team> collection = database.GetCollection<Team>("teams");
                IMongoCollection<User> collection2 = database.GetCollection<User>("user");
                string test = forteamslist.SelectedItem.ToString();

                Team selectedteam = collection.Find(x => x.Name == test).FirstOrDefault();
                List<User> usersinTeam = new List<User>();

                User first = collection2.Find(x => x.Login == selectedteam.First).First();
                User second = collection2.Find(x => x.Login == selectedteam.Second).First();
                User third = collection2.Find(x => x.Login == selectedteam.Third).First();
                User fourth = collection2.Find(x => x.Login == selectedteam.Fourth).First();
                User fifth = collection2.Find(x => x.Login == selectedteam.Fifth).First();

                usersinTeam.Add(first);
                usersinTeam.Add(second);
                usersinTeam.Add(third);
                usersinTeam.Add(fourth);
                usersinTeam.Add(fifth);

                forcreatelist.Items.Add(first);
                forcreatelist.Items.Add(second);
                forcreatelist.Items.Add(third);
                forcreatelist.Items.Add(fourth);
                forcreatelist.Items.Add(fifth);
            }
            else
                MessageBox.Show("Лист переполнен.");

        }
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            while (forcreatelist.Items.Count > 0)
            {
                forcreatelist.Items.Remove(forcreatelist.Items[0]);
            }



        }
        private void btnrandom_Click(object sender, RoutedEventArgs e)
        {
            while (forcreatelist.Items.Count > 0)
            {
                forcreatelist.Items.Remove(forcreatelist.Items[0]);
            }
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("user");
            IMongoCollection<Team> collection = database.GetCollection<Team>("teams");
            IMongoCollection<User> collection2 = database.GetCollection<User>("user");

            List<User> listwithUsers = new List<User>();
            foreach (var item in collection2.Find(x => true).ToList())
            {
                listwithUsers.Add(item);
            }
            Random z = new Random();

            int[] array = new int[5];
            for (int i = 0; i < 5; i++)
            {
                int a = z.Next(0, listwithUsers.Count);
                if (!array.Contains(a))
                {
                    forcreatelist.Items.Add(listwithUsers[a]);
                    array[i] = a;
                }
                else
                    i--;
            }
        }

    }
}
