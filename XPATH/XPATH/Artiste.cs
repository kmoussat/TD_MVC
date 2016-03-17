using System.Xml;
using System.Xml.XPath;

public class Artiste
	{
		private string nom;
		private string prenom;
		private string surnom;
		
		public Artiste(string nom, string prenom, string surnom)
		{
			this.nom = nom;
			this.prenom = prenom;
			this.surnom = surnom;
		}
		
		public Artiste(string nom, string prenom)
			: this(nom,prenom,null)
		{
		}
		
		
		
		override public string ToString ()
		{
			string resultat = nom + " " + prenom;
			
			if(surnom != null)
			{
				resultat = surnom + " (" + resultat + ")";
			}
			
			return resultat;
		}
	}


