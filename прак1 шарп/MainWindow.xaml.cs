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

namespace прак1_шарп
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public void isenabled(bool isis)
        {
            if (isis == true)
            {
                cube1.IsEnabled = true;
                cube2.IsEnabled = true;
                cube3.IsEnabled = true;
                cube4.IsEnabled = true;
                cube5.IsEnabled = true;
                cube6.IsEnabled = true;
                cube7.IsEnabled = true;
                cube8.IsEnabled = true;
                cube9.IsEnabled = true;
            } else
            {
                cube1.IsEnabled = false;
                cube2.IsEnabled = false;
                cube3.IsEnabled = false;
                cube4.IsEnabled = false;
                cube5.IsEnabled = false;
                cube6.IsEnabled = false;
                cube7.IsEnabled = false;
                cube8.IsEnabled = false;
                cube9.IsEnabled = false;
            }
        }
        public void clearbt()
        {
            tbcube1.Text = "";
            tbcube2.Text = "";
            tbcube3.Text = "";
            tbcube4.Text = "";
            tbcube5.Text = "";
            tbcube6.Text = "";
            tbcube7.Text = "";
            tbcube8.Text = "";
            tbcube9.Text = "";
        }
        public void isfree()
        {

        }
        public void robot(int[] closed)
        {

            Random random = new Random();
            int rndcube = random.Next(1, 9);
            if (rndcube == 1 & closed.Contains(1) != true)
            {
                tbcube1.Text = "O";
                cube1.IsEnabled = false;
                closed.Append(rndcube);
            }
            else if (rndcube == 2 & closed.Contains(2) != true)
            {
                tbcube2.Text= "O";
                cube2.IsEnabled = false;
                closed.Append(rndcube);
            }
            else if (rndcube == 3 & closed.Contains(3) != true)
            {
                tbcube3.Text = "O";
                cube3.IsEnabled = false;
                closed.Append(rndcube);
            }
            else if (rndcube == 4 & closed.Contains(4) != true)
            {
                tbcube4.Text = "O";
                cube4.IsEnabled = false;
                closed.Append(rndcube);
            }
            else if (rndcube == 5 & closed.Contains(5) != true)
            {
                tbcube5.Text = "O";
                cube5.IsEnabled = false;
                closed.Append(rndcube);
            }
            else if (rndcube == 6 & closed.Contains(6) != true)
            {
                tbcube6.Text = "O";
                cube6.IsEnabled = false;
                closed.Append(rndcube);
            }
            else if (rndcube == 7 & closed.Contains(7) != true)
            {
                tbcube7.Text = "O";
                cube7.IsEnabled = false;
                closed.Append(rndcube);
            }
            else if (rndcube == 8 & closed.Contains(8) != true)
            {
                tbcube8.Text = "O";
                cube8.IsEnabled = false;
                closed.Append(rndcube);
            }
            else if (rndcube == 9 & closed.Contains(9) != true)
            {
                tbcube9.Text = "O";
                cube9.IsEnabled = false;
                closed.Append(rndcube);
            }
            else
            {
                robot(closed);
            }
        }
        public void closed(int cubenum)
        {
            int[] close = new int[9];
            close.Append(cubenum);
            robot(close);
        }
        public MainWindow()
        {
            InitializeComponent();
            isenabled(false);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tbcube3.Text = "       X";
            closed(3);
        }
        private void starting()
        {
            isenabled(true);
            clearbt();
            closed(0);
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            starting();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            tbcube1.Text = "       X";
            closed(1);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            tbcube2.Text = "       X";
            closed(2);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            tbcube4.Text = "       X";
            closed(4);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            tbcube5.Text = "       X";
            closed(5);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            tbcube6.Text = "       X";
            closed(6);
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            tbcube7.Text = "       X";
            closed(7);
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            tbcube8.Text = "       X";
            closed(8);
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            tbcube9.Text = "       X";
            closed(9);
        }
    }
}
