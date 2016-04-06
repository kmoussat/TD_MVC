using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Paires
{
    class CarteGUI : Button
    {
        private Carte carte;

        public CarteGUI(string valeur) : base()
        {
            this.carte = new Carte(valeur);
            this.Content = carte.Valeur();

            this.Click += CarteGUI_Click;
                //new System.Windows.RoutedEventHandler(CarteGUI_CLick);
        }

        private void CarteGUI_Click(object sender, RoutedEventArgs e)
        {
            carte.Retourner();
            this.Content = carte.Valeur();
        }

        

    }
}
