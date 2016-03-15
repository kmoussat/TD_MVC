using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BandeDessinee
		{
			private string isbn;
			private string titre;
			private string auteur;
			private int nbPages;

			public BandeDessinee(string isbn, string titre, string auteur, int nbPages)
			{
				this.isbn = isbn;
				this.titre = titre;
				this.auteur = auteur;
				this.nbPages = nbPages;
			}

			public BandeDessinee(string isbn, string titre, string auteur) 
				: this(isbn, titre, auteur, -1)
			{
			}


			public string ISBN 
			{
				get{ return isbn; }
			}

			public string Titre 
			{
				get{ return titre; }
			}

			public string  Auteur
			{
				get{ return auteur; }
			}

			public int NombrePages
			{
				get{ return nbPages; }
			}


			override public string ToString()
			{
				string resultat = titre;

				resultat += ", de " + auteur;
				if(nbPages > 0)
				{
					resultat += ", " + nbPages + " pages";
				}
				resultat += " (ISBN "+isbn+")";
				
				return resultat;
			}
		}


