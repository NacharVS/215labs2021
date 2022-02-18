using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            string test = Convert.ToString(lbl1.Content);
            try
            {
                if (test[0] == '0' && test[1] != ',')
                {
                    lbl1.Content = "";
                }
            }
            catch { }
            lbl1.Content += "1";
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            string test = Convert.ToString(lbl1.Content);
            try
            {
                if (test[0] == '0' && test[1] != ',')
                {
                    lbl1.Content = "";
                }
            }
            catch { }
            lbl1.Content += "2";
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            string test = Convert.ToString(lbl1.Content);
            try
            {
                if (test[0] == '0' && test[1] != ',')
                {
                    lbl1.Content = "";
                }
            }
            catch { }
            lbl1.Content += "3";
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            string test = Convert.ToString(lbl1.Content);
            try
            {
                if (test[0] == '0' && test[1] != ',')
                {
                    lbl1.Content = "";
                }
            }
            catch { }
            lbl1.Content += "4";
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            string test = Convert.ToString(lbl1.Content);
            try
            {
                if (test[0] == '0' && test[1] != ',')
                {
                    lbl1.Content = "";
                }
            }
            catch { }
            lbl1.Content += "5";
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            string test = Convert.ToString(lbl1.Content);
            try
            {
                if (test[0] == '0' && test[1] != ',')
                {
                    lbl1.Content = "";
                }
            }
            catch { }
            lbl1.Content += "6";
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            string test = Convert.ToString(lbl1.Content);
            try
            {
                if (test[0] == '0' && test[1] != ',')
                {
                    lbl1.Content = "";
                }
            }
            catch { }
            lbl1.Content += "7";
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            string test = Convert.ToString(lbl1.Content);
            try
            {
                if (test[0] == '0' && test[1] != ',')
                { 
                    lbl1.Content = "";
                }
            }
            catch { }
            lbl1.Content += "8";
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            string test = Convert.ToString(lbl1.Content);
            try
            {
                if (test[0] == '0' && test[1] != ',')
                {
                    lbl1.Content = "";
                }
            }
            catch { }
                lbl1.Content += "9";

        }
     
        public double calculate(double numberone, string znak)
        {
            
            return numberone;

        }
        private void plus_Click(object sender, RoutedEventArgs e)
        {
            string test = Convert.ToString(lbl1.Content);
            if (test[test.Length - 1] != ',' && test[test.Length - 1] != '+' && test[test.Length - 1] != '-' && test[test.Length - 1] != '*' && test[test.Length - 1] != '/')
            {
                double numberone = Convert.ToDouble(lbl1.Content);
                lbl1.Content += "+";
                lbl1.Content = "";
                calculate(numberone, "+");


            }
            
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            string test = Convert.ToString(lbl1.Content);
            if (test[test.Length-1] != ',' && test[test.Length-1] != '+' && test[test.Length-1] != '-' && test[test.Length-1] != '*' && test[test.Length-1] != '/')
                lbl1.Content += "-";
        }

        private void mult_Click(object sender, RoutedEventArgs e)
        {
            string test = Convert.ToString(lbl1.Content);
            if (test[test.Length-1] != ',' && test[test.Length-1] != '+' && test[test.Length-1] != '-' && test[test.Length-1] != '*' && test[test.Length-1] != '/')
                lbl1.Content += "*";
        }

        private void divide_Click(object sender, RoutedEventArgs e)
        {
            string test = Convert.ToString(lbl1.Content);
            if (test[test.Length-1] != ',' && test[test.Length-1] != '+' && test[test.Length-1] != '-' && test[test.Length-1] != '*' && test[test.Length-1] != '/')
                lbl1.Content += "/";
        }

        private void dellsymbol_Click(object sender, RoutedEventArgs e)
        {
            string test = Convert.ToString(lbl1.Content);
            if (test != "")
            {
                lbl1.Content = test.Remove(test.Length - 1, 1);
            }
        }

        private void dellall_Click(object sender, RoutedEventArgs e)
        {
            lbl1.Content = "";
        }

        private void btn_point_Click(object sender, RoutedEventArgs e)
        {
            string test = Convert.ToString(lbl1.Content);
            if (test.Contains(',') == false) 
            {
                if (test[test.Length - 1] != ',' && test[test.Length - 1] != '+' && test[test.Length - 1] != '-' && test[test.Length - 1] != '*' && test[test.Length - 1] != '/')
                lbl1.Content += ",";
            }
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            string test = Convert.ToString(lbl1.Content);
            try
            {
                for (int i = 0; i <= 0; i++)
                {
                    if (test.Contains(','))
                    {
                        lbl1.Content += "0";
                        break;
                    }
                    if (test[test.Length - 1] != '0')
                    {
                        lbl1.Content += "0";
                    }
                }
            }
            catch { lbl1.Content += "0"; }
            

        }

      
    }
}
