using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Serialization;
using System.IO;

public class Artiste
	{
		private string nom;
		private string prenom;
		private string surnom;

    public string Nom
    {
        get
        {
            return nom;
        }

        set
        {
            nom = value;
        }
    }

    public string Prenom
    {
        get
        {
            return prenom;
        }

        set
        {
            prenom = value;
        }
    }

    public string Surnom
    {
        get
        {
            return surnom;
        }

        set
        {
            surnom = value;
        }
    }

    public Artiste(string nom, string prenom, string surnom)
		{
			this.Nom = nom;
			this.Prenom = prenom;
			this.Surnom = surnom;
		}
		
		public Artiste(string nom, string prenom)
			: this(nom,prenom,null)
		{
		}

    public Artiste() 
			: this("N/C","N/C","N/C")  // N/C : Non Communiqué
		{
    }



    override public string ToString ()
		{
        /* tring resultat = nom + " " + prenom;

        if(surnom != null)
        {
            resultat = surnom + " (" + resultat + ")";
        }

        return resultat;

*/

       
     
        return nom + prenom + surnom; 
		}
	}


