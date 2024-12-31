namespace Bridge;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("===== Gestion des formulaires d'immatriculation =====\n");

        // Initialisation du formulaire pour la France avec une implémentation HTML
        Console.WriteLine("1. Formulaire France (HTML) :");
        ImplFormulaireImmatriculation htmlImpl = new ImplFormulaireHtml();
        FormulaireImmatriculation formulaireFrance = new FormulaireImmatriculationFrance(htmlImpl);
        formulaireFrance.Afficher("Numéro de plaque", "Propriétaire actuel", "Adresse de l'ancien propriétaire");

        Console.WriteLine();

        // Initialisation du formulaire pour le Luxembourg avec une implémentation Applet
        Console.WriteLine("2. Formulaire Luxembourg (Applet) :");
        ImplFormulaireImmatriculation appletImpl = new ImplFormulaireApplet();
        FormulaireImmatriculation formulaireLux = new FormulaireImmatriculationLuxembourg(appletImpl);
        formulaireLux.Afficher("Numéro de plaque", "Nom complet", "Adresse du nouveau propriétaire");

        Console.WriteLine("\n===== Fin de la démonstration =====");
    }
}