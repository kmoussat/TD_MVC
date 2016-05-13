using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
    class ModeleMeteo : IObservable
    {
        private double temperature;
        private List<IObserver> listeObserveurs;

        public ModeleMeteo(double temperature)
        {
            this.Temperature = temperature;
            this.listeObserveurs = listeObserveurs;
        }

        public double Temperature
        {
            get
            {
                return temperature;
            }

            set
            {
                temperature = value;
                NotifyObservers();
            }
        }

        #region Définition des méthodes de IObservable

        public void NotifyObservers()
        {
            foreach (IObserver obs in listeObserveurs)
            {
                obs.Update(Temperature);
            }
        }

        public void AddObserver(IObserver obs)
        {
            this.listeObserveurs.Add(obs);

            obs.Update(temperature);
        }

        public void RemoveObserver(IObserver obs)
        {
            this.listeObserveurs.Remove(obs);
        }

        #endregion


    }
}
