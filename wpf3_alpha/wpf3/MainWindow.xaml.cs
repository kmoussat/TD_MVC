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

namespace wpf3
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
                Random r = new Random();
                double numb = r.NextDouble();
                numb = numb * (canvas1.ActualHeight - Rect.Height);// - Rect.ActualHeight / 2;

            /*if (numb<0)
            {
                numb = 0;
            }
            */
                Thread.Sleep(5);
                double longueur;
                Random r1 = new Random();
                longueur = r1.NextDouble();
                longueur = longueur * (canvas1.ActualWidth - Rect.Width);// - Rect.ActualHeight / 2;

            /*

            if (longueur<0)
            {
                longueur = 0;
            }
            */
                Rect.Margin = new Thickness(longueur, numb, 0, 0);
            


        }

       
    }
}
