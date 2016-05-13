using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{ 

    // Le vue implémente l'interface IObserver
    public partial class VueSimpleMeteo : MainWindow, IObserver, IVueSimpleMeteo
    {
        public VueSimpleMeteo()
        {
            InitializeComponent();

            
            
        }

        #region Définition des méthodes de IObserver

        public void Update(double nouvelleTemperature)
        {
            this.tpt.Content = Convert.ToString(nouvelleTemperature);
        }
    }
    #endregion
}
