using Builder;
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez le nom du vendeur :");
            string vendeurNom = Console.ReadLine();

            Console.WriteLine("Choisissez le format de liasse (html/pdf) :");
            string choix = Console.ReadLine()?.ToLower();

            ConstructeurLiasseVehicule constructeur;

            if (choix == "html")
            {
                constructeur = new ConstructeurLiasseVehiculeHtml();
            }
            else
            {
                constructeur = new ConstructeurLiasseVehiculePdf();
            }

            Directeur directeur = new Directeur(constructeur);

            Console.WriteLine("Entrez le nom du client :");
            string client = Console.ReadLine();

            Console.WriteLine("Entrez les informations du véhicule :");
            string informationsVehicule = Console.ReadLine();

            // Générer une immatriculation française fictive
            string immatriculation = GenererImmatriculation();

            Liasse liasse = directeur.Construit(client, informationsVehicule);
            liasse.AjouteDocument($"Vendeur : {vendeurNom}");
            liasse.AjouteDocument($"Immatriculation générée : {immatriculation}");
            liasse.Imprime();

            Console.WriteLine("Liasse générée avec succès !");
        }

        static string GenererImmatriculation()
        {
            Random random = new Random();
            string lettres1 = $"{(char)random.Next('A', 'Z' + 1)}{(char)random.Next('A', 'Z' + 1)}";
            string chiffres = random.Next(100, 999).ToString();
            string lettres2 = $"{(char)random.Next('A', 'Z' + 1)}{(char)random.Next('A', 'Z' + 1)}";
            return $"{lettres1}-{chiffres}-{lettres2}";
        }
    }
}