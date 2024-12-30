using Builder;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
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

            Liasse liasse = directeur.Construit(client, informationsVehicule);
            liasse.Imprime();
        }
    }
}