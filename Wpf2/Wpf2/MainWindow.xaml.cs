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

namespace Wpf2
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

    
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //gauche à droite
            if (txt1.Text == "") MessageBox.Show("Il n'y a rien d'écrit");
            string msg = txt1.Text;
            txt2.Text = msg;
            txt1.Clear();

         




        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
         
            //droite à gauche
            if (txt2.Text == "") MessageBox.Show("Il n'y a rien d'écrit");
            string msg = txt2.Text;
            txt1.Text = msg;
            txt2.Clear();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
