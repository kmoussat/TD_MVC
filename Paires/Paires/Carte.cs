using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paires
{
    class Carte
    {
        private string valeur;
        private bool estCachee;
       

    public Carte(string valeur)
        {
            this.valeur = valeur;
            this.estCachee = true;
        }

   

        public string Valeur()
        {
            string resultat = "?";
            if(! estCachee)
            {
                resultat = valeur;
            }
            return resultat;
         }

        public void Retourner()
        {
            estCachee = !estCachee;
        }
    }

}
