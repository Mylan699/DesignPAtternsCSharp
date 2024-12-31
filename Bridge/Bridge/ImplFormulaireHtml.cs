namespace Bridge;

public class ImplFormulaireHtml : ImplFormulaireImmatriculation
{
    public void DessinerTexte(string texte)
    {
        Console.WriteLine($"Texte : {texte}");
    }

    public void DessinerChamp(string champ)
    {
        Console.WriteLine($"Champ : {champ}");
    }
}
