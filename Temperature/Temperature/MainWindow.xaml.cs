using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Temperature
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            //InitializeComponent();
          

            // Logique métier (Business Logic)
            ModeleMeteo meteo = new ModeleMeteo(20);

            // Logique de l'application
          ControleurMeteo controleur = new ControleurMeteo(meteo);

            //Vue #1
            VueSimpleMeteo vue1 = new VueSimpleMeteo();
            meteo.AddObserver(vue1);
            //...
            meteo.Temperature = 26;

            // Vue #2
            VueModificationMeteo vue2 = new VueModificationMeteo(controleur);
            ///...
            ///

            // Vue 3
            VueModerationMeteo vue3 = new VueModerationMeteo(controleur);
            meteo.AddObserver(vue3);

            ///

            //Lancer des fenêtres
            vue1.Show();
            vue2.Show();
            vue3.Show();

            //Démarrer l'application

            System.Windows.Application Temperature = new System.Windows.Application();
            Temperature.Run();

            Console.WriteLine("___FIN___");
            Console.ReadKey();
        }
    }
}
