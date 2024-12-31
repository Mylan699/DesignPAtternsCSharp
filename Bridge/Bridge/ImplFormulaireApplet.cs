namespace Bridge;

public class ImplFormulaireApplet : ImplFormulaireImmatriculation
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