using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choisissez le format de liasse (html/pdf) :");
            string choix = Console.ReadLine()?.ToLower();

            IConstructeurLiasseVehicule constructeur;

            if (choix == "html")
            {
                constructeur = new ConstructeurLiasseVehiculeHtml();
            }
            else
            {
                constructeur = new ConstructeurLiasseVehiculePdf();
            }

            Directeur directeur = new Directeur(constructeur);
            Vendeur vendeur = new Vendeur(directeur);

            vendeur.GereVente("Client Test", "Informations Véhicule Test");
        }
    }
}