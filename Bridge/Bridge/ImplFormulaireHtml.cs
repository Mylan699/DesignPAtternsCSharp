namespace Bridge;

public class ImplFormulaireHtml : ImplFormulaireImmatriculation
{
    public void DessinerTexte(string texte)
    {
        Console.WriteLine($"[HTML] Texte : {texte}");
    }

    public void DessinerChamp(string champ)
    {
        Console.WriteLine($"[HTML] Champ : {champ}");
    }
}
