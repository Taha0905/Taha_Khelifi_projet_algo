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
        //variable exo 1
        double N1 = 0;
        double N2 = 0;
        double Resultat = 0;

        //exo 1
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

        //exo 2
        private void BTN_2_Click(object sender, RoutedEventArgs e)
        {
            // Récupérer la taille et le poids à partir des TextBox
            if (double.TryParse(TB_3.Text, out double taille) && double.TryParse(TB_4.Text, out double poids))
            {
                // Calculer l'indice de masse corporelle (IMC)
                double IMC = poids / (taille * taille);

                // Afficher le résultat dans TB_Resultat2
                TB_Resultat2.IsEnabled = true;

                if (IMC < 18)
                {
                    TB_Resultat2.Text = "Mince";
                }
                else if (IMC >= 18 && IMC < 25)
                {
                    TB_Resultat2.Text = "En bonne santé";
                }
                else if (IMC >= 25 && IMC < 30)
                {
                    TB_Resultat2.Text = "Avoir des kilos en trop";
                }
                else
                {
                    TB_Resultat2.Text = "Obèse";
                }
            }
            else
            {
                // Gérer les cas où la saisie n'est pas un nombre valide
                TB_Resultat2.IsEnabled = true;
                TB_Resultat2.Text = "Veuillez entrer des valeurs valides pour la taille et le poids.";
            }
        }

        //exo 3
        private void BTN_3_Click(object sender, RoutedEventArgs e)
        {
            TB_Resultat3.Text = ""; // Efface le contenu précédent

            // Utilisation d'une boucle for pour itérer de 0 à 15
            for (int i = 0; i <= 15; i++)
            {
                if (i % 2 == 0)
                {
                    // Si le nombre est pair (le reste de la division par 2 est 0), affiche "est pair"
                    TB_Resultat3.Text += $"{i} est pair\n";
                }
                else
                {
                    // Sinon, le nombre est impair, affiche "est impair"
                    TB_Resultat3.Text += $"{i} est impair\n";
                }
            }
        }

        //exo 4

        // Fonction pour trouver le chiffre le plus bas et le chiffre le plus élevé dans un tableau
        private void TrouverMinMax(int[] tableau)
        {
            if (tableau.Length == 0)
            {
                // Si le tableau est vide, affiche un message approprié dans le TextBox TB_Resultat4
                TB_Resultat4.Text = "Le tableau est vide.";
            }
            else
            {
                // Utilise LINQ pour trouver le chiffre le plus bas (min) et le chiffre le plus élevé (max)
                int min = tableau.Min();
                int max = tableau.Max();

                // Affiche le résultat dans le TextBox TB_Resultat4
                TB_Resultat4.Text = $"Le chiffre le plus bas est {min}, et le chiffre le plus élevé est {max}.";
            }
        }
        private void BTN_4_Click(object sender, RoutedEventArgs e)
        {
            {
                // Tableau de nombres de l'exemple
                int[] tableauNombres = new int[] { 1, 2, 3, 4, 5 };

                // Appelle la fonction TrouverMinMax avec le tableau de nombres
                TrouverMinMax(tableauNombres);
            }
        }

        //exo 5

        // Fonction pour inverser une chaîne de caractères
        private string InverserChaine(string chaine)
        {
            // Convertir la chaîne en un tableau de caractères
            char[] caractères = chaine.ToCharArray();

            // Inverser le tableau de caractères
            Array.Reverse(caractères);

            // Reconvertir le tableau en une nouvelle chaîne
            return new string(caractères);
        }
        private void BTN_5_Click(object sender, RoutedEventArgs e)
        {

            // Définir la valeur à inverser
            string valeurAInverser = "12345";

            // Inverser la valeur en utilisant la fonction InverserChaine
            string valeurInverse = InverserChaine(valeurAInverser);

            // Afficher la valeur inversée dans TB_Resultat5
            TB_Resultat5.Text = valeurInverse;
        }
    }
}