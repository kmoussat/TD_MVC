using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace JeuCartes
{
    public class CarteGUI : Button
    {
        private Carte carte;
        private JeuCartesGUI jeuCartes;

        public CarteGUI(string valeur, JeuCartesGUI jeuCartes) : base()
        {
            this.carte = new Carte(valeur);

            this.jeuCartes = jeuCartes;

            this.Content = carte.Valeur();

            this.Click += CarteGUI_Click;
                //new System.Windows.RoutedEventHandler(CarteGUI_CLick);
        }

        public string Valeur
        {
            get { return carte.Valeur(); }
        }

        public void Desactiver()
        {
            this.IsEnabled = false;
        }

        public void Retourner()
        {
            this.carte.Retourner();
            this.Content = carte.Valeur();
        }

        private void CarteGUI_Click(object sender, RoutedEventArgs e)
        {
            /* carte.Retourner();
             this.Content = carte.Valeur();*/
            this.Retourner();

            jeuCartes.MiseAJour( this );
            
        }

        

    }
}
