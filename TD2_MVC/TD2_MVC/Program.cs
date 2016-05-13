using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;



namespace TD2_MVC
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Exercice 0: \n");
            exercice0();
            Console.WriteLine("Exercice 1: \n");
            exercice1();
            Console.WriteLine("Exercice 2: \n");
            exercice2();
            Console.WriteLine("Exercice 3: \n");
            exercice3();
            Console.WriteLine("Exercice 4: \n");
            exercice4();
            Console.WriteLine("Exercice 5: \n");
            exercice5();
        }

       public static void exercice0()
        {
            // using MySql.Data.MySqlClient;


            // Bien vérifier, via Workbench par exemple, que ces paramètres de connexion sont valides !!!
            string connectionString = "SERVER=192.168.249.134;PORT=3306;DATABASE=S6_MVC_BTP;UID=esilvs6;PASSWORD=esilvs6;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = connection.CreateCommand();
           command.CommandText = "SELECT * FROM Client;"; // exemple de requete bien-sur !
         
            Console.ReadLine();

            MySqlDataReader reader;
            reader = command.ExecuteReader();

            /* exemple de manipulation du resultat */
        

            connection.Close();
            Console.ReadKey();
        }

        public static void exercice1()
        {
            // Bien vérifier, via Workbench par exemple, que ces paramètres de connexion sont valides !!!
            string connectionString = "SERVER=192.168.249.134;PORT=3306;DATABASE=S6_MVC_BTP;UID=esilvs6;PASSWORD=esilvs6;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT DISTINCT PRIX FROM Produit WHERE label = 'briques';";

            MySqlDataReader reader;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                int prix = reader.GetInt32(0);
                Console.WriteLine(prix + "\n");
            }

            connection.Close();
            Console.ReadKey();

        }

        public static void exercice2()
        {
            // Bien vérifier, via Workbench par exemple, que ces paramètres de connexion sont valides !!!
            string connectionString = "SERVER=192.168.249.134;PORT=3306;DATABASE=S6_MVC_BTP;UID=esilvs6;PASSWORD=esilvs6;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT CONCAT(UCASE(LEFT(label,1)),LCASE(SUBSTRING(label,2))) AS 'Produit' ,prix  FROM Produit;";

            MySqlDataReader reader;
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                string label = reader.GetString(0);
                int prix = reader.GetInt32(1);
                Console.WriteLine(label + ":" + prix + "\n");
            }

            connection.Close();
            Console.ReadKey();
        }

        public static void exercice3()
        {
            // Bien vérifier, via Workbench par exemple, que ces paramètres de connexion sont valides !!!
            string connectionString = "SERVER=192.168.249.134;PORT=3306;DATABASE=S6_MVC_BTP;UID=esilvs6;PASSWORD=esilvs6;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT DISTINCT AVG(prix) FROM Produit ";

            MySqlDataReader reader;
            reader = command.ExecuteReader();

           if( reader.Read())
            { 
                double moyenne = reader.GetDouble(0);
                Console.WriteLine("Prix Moyenne: " + moyenne);
                //string label = reader.GetString(0);
                //double prix = reader.GetInt32(1);
                //Console.WriteLine("Prix Moyen:" + prix + "\n");
            }
            else
            {
                return;
            }

            connection.Close();
            Console.ReadKey();
        }

        public static void exercice4()
        {
            // Bien vérifier, via Workbench par exemple, que ces paramètres de connexion sont valides !!!
            string connectionString = "SERVER=192.168.249.134;PORT=3306;DATABASE=S6_MVC_BTP;UID=esilvs6;PASSWORD=esilvs6;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT DISTINCT MAX(prix) FROM Produit ";

            MySqlDataReader reader;
            reader = command.ExecuteReader();

            if (reader.Read())
            {
                double moyenne = reader.GetDouble(0);
                Console.WriteLine("Prix Maximum: " + moyenne);
                //string label = reader.GetString(0);
                //double prix = reader.GetInt32(1);
                //Console.WriteLine("Prix Moyen:" + prix + "\n");
            }
            else
            {
                return;
            }

            connection.Close();
            Console.ReadKey();
        }


        public static void exercice5()
        {
            // Bien vérifier, via Workbench par exemple, que ces paramètres de connexion sont valides !!!
            string connectionString = "SERVER=192.168.249.134;PORT=3306;DATABASE=S6_MVC_BTP;UID=esilvs6;PASSWORD=esilvs6;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT DISTINCT prix FROM Produit ORDER BY PRIX;  ";

            MySqlDataReader reader;
            reader = command.ExecuteReader();

            if (reader.Read())
            {
                reader.Read();

                //Boucle for ou while possible surtout si besoin de choisir d'autres valeurs
                int moyenne = reader.GetInt32(0);
                Console.WriteLine("Second Prix Maximum: " + moyenne);
                //string label = reader.GetString(0);
                //double prix = reader.GetInt32(1);
                //Console.WriteLine("Prix Moyen:" + prix + "\n");
            }
            else
            {
                return;
            }

            connection.Close();
            Console.ReadKey();
        }


        public static void exercice6()
        {
            // Bien vérifier, via Workbench par exemple, que ces paramètres de connexion sont valides !!!
            string connectionString = "SERVER=192.168.249.134;PORT=3306;DATABASE=S6_MVC_BTP;UID=esilvs6;PASSWORD=esilvs6;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT DISTINCT COUNT(prix) FROM Produit ORDER BY PRIX;  ";

            MySqlDataReader reader;
            reader = command.ExecuteReader();


            {
                reader.Read();

                //Boucle for ou while possible surtout si besoin de choisir d'autres valeurs
                int moyenne = reader.GetInt32(0);
                Console.WriteLine("Second Prix Maximum: " + moyenne);
                //string label = reader.GetString(0);
                //double prix = reader.GetInt32(1);
                //Console.WriteLine("Prix Moyen:" + prix + "\n");
            }
        
            else
            {
                return;
            }

            connection.Close();
            Console.ReadKey();
        }
    }
}
