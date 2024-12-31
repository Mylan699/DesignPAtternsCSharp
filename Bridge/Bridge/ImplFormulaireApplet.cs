namespace Bridge;

public class ImplFormulaireApplet : ImplFormulaireImmatriculation
{
    public void DessinerTexte(string texte)
    {
        Console.WriteLine($"[Applet] Texte : {texte}");
    }

    public void DessinerChamp(string champ)
    {
        Console.WriteLine($"[Applet] Champ : {champ}");
    }
}
