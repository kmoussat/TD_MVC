using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
    class ControleurMeteo
    {
        private ModeleMeteo modele;
        private const int nombreDecimales = 1;
        private const double precision = 0.1;

        public ControleurMeteo(ModeleMeteo modele)
        {
            this.modele = modele;
        }

       

        public void ModifierTptEnCelsius(double tptCelsius)
        {
            modele.Temperature = Math.Round(tptCelsius, nombreDecimales);

        }

        public void AjusterTemperatureEnCelsisus(bool enAugmentant)
        {
            if (enAugmentant)
                ModifierTptEnCelsius(modele.Temperature + precision);
            else
                ModifierTptEnCelsius(modele.Temperature - precision);
}
        public void ModifierTptEnFahrenheit(double tptFahrenheit)
        {
            double tptCelsius = (tptFahrenheit - 32) / 1.8;
            ModifierTptEnCelsius(tptCelsius);
        }

        public void AjusterTptEnFahrenheit(bool enAugmentant)
        {
            if (enAugmentant)
                ModifierTptEnFahrenheit(GetTptEnFahrenheit() + 5 * precision);
            else
                ModifierTptEnFahrenheit(GetTptEnFahrenheit() - 5 * precision);
                    }

        public double GetTptEnFahrenheit()
        {
            double tptFahrenheit = modele.Temperature * 1.8 + 32;
            tptFahrenheit = Math.Round(tptFahrenheit, nombreDecimales);
            return tptFahrenheit;
        }



    }

   
}
