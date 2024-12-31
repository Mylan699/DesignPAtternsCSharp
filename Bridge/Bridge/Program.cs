namespace Bridge;

class Program
{
    static void Main(string[] args)
    {
        // Utiliser le formulaire France avec implémentation HTML
        ImplFormulaireImmatriculation htmlImpl = new ImplFormulaireHtml();
        FormulaireImmatriculation formulaireFrance = new FormulaireImmatriculationFrance(htmlImpl);
        formulaireFrance.Afficher();

        Console.WriteLine();

        // Utiliser le formulaire Luxembourg avec implémentation Applet
        ImplFormulaireImmatriculation appletImpl = new ImplFormulaireApplet();
        FormulaireImmatriculation formulaireLux = new FormulaireImmatriculationLuxembourg(appletImpl);
        formulaireLux.Afficher();
    }
}