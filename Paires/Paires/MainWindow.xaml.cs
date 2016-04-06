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

namespace Paires
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Principal.Children.Add(CreateGrid());        }

            private Grid CreateGrid()
        {
            Grid grid = new Grid();
            string[] temp = { "A", "B", "a", "b", "b", "a", "b", "a" };
            int nbLignes = 2;
            int nb_colonnes = 4;
            for (int l = 0; l < nbLignes; l++)
            {
                RowDefinition ligne = new RowDefinition();
                grid.RowDefinitions.Add(ligne);
            }

            for (int c = 0; c < nb_colonnes; c++)
            {
                ColumnDefinition colonne = new ColumnDefinition();
                grid.ColumnDefinitions.Add(colonne);
            }
            int i = 0;
            for (int ligne = 0; ligne < nbLignes; ligne++)
            {
                for (int colonne = 0; colonne < nb_colonnes; colonne++)
                {
                    CarteGUI b = new CarteGUI(temp[i]);
                    b.Content = "?";
                    i++;
                    Grid.SetRow(b, ligne);
                    Grid.SetColumn(b, colonne);
                    grid.Children.Add(b);
                }

            }
            return grid;
        }
          
        }

      

        static class RandomLetter
        {
            static Random _random = new Random();
            public static char GetLetter()
            {
                int num = _random.Next(0, 5);
                char let = (char)('a' + num);
                return let;
            }
            
        }
    }

