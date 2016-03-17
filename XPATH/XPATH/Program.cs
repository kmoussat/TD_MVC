using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Serialization;
using System.IO;

namespace XPATH
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exo1();
            //Exo2();
           Exo2_2();
            Exo2_3();
            Console.ReadKey();
        }

        public static void Exo1()
        {



            string fileName = "filmotheque.xml";
            XPathDocument doc = new XPathDocument(fileName);
            XPathNavigator nav = doc.CreateNavigator();

            XPathExpression expr;
            expr = nav.Compile("/filmotheque/film");

            XPathNodeIterator nodes = nav.Select(expr);
            while (nodes.MoveNext() != false)
            {
                string nom;
                int annee;
                int mois;
                List<string> acteurs = new List<string>();

                //si il n'y a pas de firstchild on movetonext()

                nodes.Current.MoveToFirstChild();
                nom = nodes.Current.Value;


                Console.WriteLine("Film: " + nom);

                //deplacement dans le noeud suivant
                nodes.Current.MoveToNext();
                annee = Convert.ToInt32(nodes.Current.Value);
                Console.WriteLine("Annee: " + annee);

                if (nodes.Current.MoveToFirstAttribute() != false)
                {
                    mois = Convert.ToInt32(nodes.Current.Value);
                    nodes.Current.MoveToParent();
                    Console.WriteLine("Mois: " + mois);
                }
                else
                {
                    nodes.Current.MoveToNext();
                }


                while (nodes.Current.MoveToNext() == true)
                {
                    for (int i = acteurs.Count; i <= 0; i++)
                    {
                        nodes.Current.MoveToNext();
                        acteurs.Add(nodes.Current.Value);
                    }

                }

                Console.WriteLine("Acteurs :");

                foreach (string i in acteurs)
                {


                    Console.WriteLine(i.ToString());
                }





            }
            Console.ReadKey();
        }

        public static void Exo2()
        {
            BandeDessinee bd1 = new BandeDessinee("978-2203001169", "On a marché sur la Lune", 62);
            Console.WriteLine(bd1);

            XmlSerializer xs = new XmlSerializer(typeof(BandeDessinee));
            StreamWriter wr = new StreamWriter("bd1.xml");
            xs.Serialize(wr, bd1);

            wr.Close();
        }


        public static void Exo2_2()
        {
            Artiste auteurr = new Artiste("Remi", "Georges", "Herge");
            Console.WriteLine(auteurr);

            BandeDessinee bd2 = new BandeDessinee("978-2203001169", "On a marché sur la Lune", Convert.ToString(auteurr), 62);
            Console.WriteLine(bd2);

            XmlSerializer xs = new XmlSerializer(typeof(BandeDessinee));
            StreamWriter wr = new StreamWriter("bd2.xml");
            xs.Serialize(wr, bd2);
         

            wr.Close();
        }


        public static void Exo2_3()
        {
            {
                BDtheque bdtheque = new BDtheque();

                Artiste herge = new Artiste("Remi", " Georges ", "Herge ");
                bdtheque.Ajouter(new BandeDessinee("978−2203001169", "On a marché sur la Lune", Convert.ToString(herge), 62));
                bdtheque.Ajouter(new BandeDessinee("978−2203001039", "Les Cigares du pharaon", Convert.ToString(herge)));
                bdtheque.Ajouter(new BandeDessinee("978−2012101371", "Le tour de Gaule d Astérix", Convert.ToString(new Artiste("Remi", "Georges", "Herge"))));
                Console.WriteLine(bdtheque);



                XmlSerializer xs = new XmlSerializer(typeof(BDtheque));
                StreamWriter wr = new StreamWriter("bdtheque.xml");
                xs.Serialize(wr, bdtheque);

                wr.Close();
            }




        }
    }
}