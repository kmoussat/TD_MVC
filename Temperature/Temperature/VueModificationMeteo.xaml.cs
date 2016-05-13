using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Temperature
{
    public partial class VueModificationMeteo : MainWindow
    {
        private ControleurMeteo controleur;

        public VueModificationMeteo(ControleurMeteo controleur)
        {

            //InitializeComponent();
            this.controleur = controleur;
        }

        public object tpt { get; private set; }

        private void MettreAJourCelsius_Click(object sender, RoutedEventArgs e)
        {
            double temperature = Convert.ToDouble(this.tpt.Text);
            controleur.ModifierTptEnCelsius(temperature);
        }
    }
}
