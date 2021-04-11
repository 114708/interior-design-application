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

namespace Interior_Design_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Console.WriteLine(rb1.IsChecked);
            //Console.WriteLine(rb2.IsChecked);
            //Console.WriteLine(rb3.IsChecked);
            //Console.WriteLine(cb1.IsChecked);

            int rbutton1 = int 1.75;
            int rbutton2 = 1;
            int rbutton3 = int 0.45;
            int CheckedBox = int 0.50;
            int cost = 0;

            string usersInput = Console.ReadLine();

            int finalLength = int Length1 + int Length2 + int Length3 + int Length4;


            if Console.WriteLine(rb1.IsChecked)
            {
                int cost = finalLength * rbutton1;
            }
            if Console.WriteLine(rb2.IsChecked)
            {
                int cost = finalLength * rbutton2;
            }
            if Console.WriteLine(rb3.IsChecked)
            {
                int cost = finalLength * rbutton3;
            }
            if Console.WriteLine(cb1.IsChecked);
            {
                int cost = int cost + CheckedBox;
            }
            else
            {
                Console.WriteLine("Error Retry");
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
                
        }
    }
}
