using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;





namespace MVC_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            Exo1();
            Exo2();
            Console.ReadKey();
        }

        static void Exo1()
        {
            BandeDessinee bd1 = new BandeDessinee("978-2203001169", "On a marché sur la Lune", "Hergé", 62);
            BandeDessinee bd2 = new BandeDessinee("978-2203001039", "Les Cigares du pharaon", "Hergé");

            BDtheque bdtheque = new BDtheque();
            bdtheque.Ajouter(bd1);
            bdtheque.Ajouter(bd2);
            bdtheque.Ajouter(new BandeDessinee("978-2012101371", "Le tour de Gaule d'Astérix", "Goscinny", 48));
            bdtheque.Ajouter(new BandeDessinee("978-2354260330", "Faites gaffe à Lagaffe", "Franquin", 48));

            Console.WriteLine(bdtheque);  //où bdtheque.ToString() fait appel à ToString() de chaque BD

            XmlDocument doc = new XmlDocument();
            XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(docNode);

            XmlNode biblio = doc.CreateElement("bibliotheque");
            doc.AppendChild(biblio);

            int num = bdtheque.NombreBandesDessinees();
            
            for (int i = 0; i < num; i++)
            {
               

                XmlNode livre = doc.CreateElement("livre");
                XmlAttribute LivreAttribute = doc.CreateAttribute("isbn");
                LivreAttribute.Value = bdtheque.Recuperer(i).ISBN;
                livre.Attributes.Append(LivreAttribute);
                biblio.AppendChild(livre);

                XmlNode titre = doc.CreateElement("titre");
                titre.AppendChild(doc.CreateTextNode(bdtheque.Recuperer(i).Titre));
                livre.AppendChild(titre);

                XmlNode auteur = doc.CreateElement("auteur");
                auteur.AppendChild(doc.CreateTextNode(bdtheque.Recuperer(i).Auteur));
                livre.AppendChild(auteur);

                if (bdtheque.Recuperer(i).NombrePages >= 0)
            {
                string NB = bdtheque.Recuperer(i).NombrePages.ToString();
                XmlNode nombre_pages = doc.CreateElement("nombre_pages");
                nombre_pages.AppendChild(doc.CreateTextNode(NB));
                livre.AppendChild(nombre_pages);
            }
           
               

            }

            doc.Save("ex2.xml");


        }

        static void Exo2()
        {
           
            



            
            
        }

      



    }
}
