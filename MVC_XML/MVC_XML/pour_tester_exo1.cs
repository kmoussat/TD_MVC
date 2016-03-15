		static void Exo1()
		{
			BandeDessinee bd1 = new BandeDessinee("978-2203001169", "On a marché sur la Lune", "Hergé", 62);
			BandeDessinee bd2 = new BandeDessinee("978-2203001039", "Les Cigares du pharaon", "Hergé");
			
			BDtheque bdtheque = new BDtheque();
			bdtheque.Ajouter(bd1);
			bdtheque.Ajouter(bd2);
			bdtheque.Ajouter( new BandeDessinee("978-2012101371", "Le tour de Gaule d'Astérix", "Goscinny", 48) );
			bdtheque.Ajouter( new BandeDessinee("978-2354260330", "Faites gaffe à Lagaffe", "Franquin", 48) );

			Console.WriteLine(bdtheque);  //où bdtheque.ToString() fait appel à ToString() de chaque BD
		}