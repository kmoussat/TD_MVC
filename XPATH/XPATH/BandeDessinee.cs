using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Serialization;
using System.IO;

public class BandeDessinee
	{
		private string isbn;
		private string titre;
        private string auteur;
		private int nombrePages; // valeur -1 par défaut (cf. constructeurs où information non renseignée)
		
		public BandeDessinee(string isbn, string titre, string auteur, int nombrePages) 
		{
			this.isbn = isbn;
			this.titre = titre;
            this.auteur = auteur;
			this.nombrePages = nombrePages;
		}
		
		public BandeDessinee(string isbn, string titre, string auteur)
			: this(isbn, titre, auteur, -1)
		{
		}

    public BandeDessinee(string isbn, string titre, int nombresPages)
            : this(isbn, titre, "", -1)
    {
    }


    #region Constructeur "vide" + Propriétés accessibles publiquement en get et en set pour une (dé)sérialisation via XmlSerializer

    // Attention : pour qu'un objet puisse être (dé)sérialisable via XmlSerializer, 
    //             la classe DOIT avoir un constructeur public "vide" (i.e sans paramètre).
    // ... même si cela n'est pas terrible ici d'un point de vue purement POO :-(
    public BandeDessinee() 
			: this("N/C","N/C","N/C")  // N/C : Non Communiqué
		{
		}
		
		// Lors de la (dé)sérialisation de l'objet
		// seuls les champs totalement publics (ici les propriétés publiques en get ET AUSSI en set !) 
		// vont être utilisés pour la sérialisation / désérialisation       
		public string ISBN 
		{
			get{ return isbn;} 
			set{ isbn = value;}  // Attention : accès en écriture nécessaire (via XmlSerializer), même si seulement pour sérialisation :-(
		}
		public string Titre 
		{
			get{ return titre;} 
			set{ titre = value;} 
		}
        public int NombrePages 
		{
			get{ return nombrePages;}
			set{ nombrePages = value;}
		}

    public string Auteur
    {
        get
        {
            return auteur;
        }

        set
        {
            auteur = value;
        }
    }

    #endregion


    override public string ToString()
		{
			string nbPages = "";
			if( nombrePages > 0 )
			{
				nbPages = ", " + Convert.ToString(nombrePages) + " pages";
			}
			
			return titre + " [" + isbn + "] " + auteur + nbPages;
		}
	
	}

