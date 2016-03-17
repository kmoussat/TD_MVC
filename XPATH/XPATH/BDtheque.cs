using System.Xml;
using System.Xml.XPath;


public class BDtheque
	{
		
		private List<BandeDessinee> bds; 

		public BDtheque()
		{
			bds = new List<BandeDessinee>();
		}

		public void Ajouter(BandeDessinee bd)
		{
			bds.Add(bd);
		}

		public int NombreBandesDessinees()
		{
			return bds.Count;
		}

		

		override public string ToString()
		{
			string resultat = "BDthèque : \n";
			foreach(BandeDessinee bd in bds)
			{
				resultat += "\t" + bd.ToString();
				resultat += "\n";
			}
			return resultat;
		}
	}
