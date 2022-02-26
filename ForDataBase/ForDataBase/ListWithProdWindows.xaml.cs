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
    /// Логика взаимодействия для ListWithProdWindows.xaml
    /// </summary>
    public partial class ListWithProdWindows : Window
    {
        public ListWithProdWindows()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Users");
            IMongoCollection<User> collection = database.GetCollection<User>("Persons");

            InitializeComponent();
            List<User> allusers;
            allusers = collection.Find(x => true).ToList();
            listfrombd.ItemsSource = allusers;

           

        }
    }
}
