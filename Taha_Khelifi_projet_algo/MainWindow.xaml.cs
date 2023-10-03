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

namespace Taha_Khelifi_projet_algo
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        double N1 = 0;
        double N2 = 0;
        double Resultat = 0;

        private void BTN_Compare_Click(object sender, RoutedEventArgs e)
        {
            // Convertir le texte des TextBox en nombres
            if (double.TryParse(TB_1.Text, out N1) && double.TryParse(TB_2.Text, out N2))
            {
                // Comparer les nombres
                if (N1 > N2)
                {
                    Resultat = N1;
                }
                else if (N1 < N2)
                {
                    Resultat = N2;
                }
                else
                {
                    // Si les nombres sont égaux
                    TB_Resultat.Text = "Les nombres sont égaux";
                    return; // Sortir de la méthode car nous avons déjà défini le texte dans TB_Resultat
                }

                // Afficher le résultat dans TB_Resultat
                TB_Resultat.Text = Resultat.ToString();
            }
            else
            {
                // Gérer le cas où la conversion échoue
                TB_Resultat.Text = "Erreur de saisie";
            }
        }
    }  
}
