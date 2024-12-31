namespace Bridge;

public abstract class FormulaireImmatriculation
{
    protected ImplFormulaireImmatriculation impl;

    public FormulaireImmatriculation(ImplFormulaireImmatriculation impl)
    {
        this.impl = impl;
    }

    public void Afficher(params string[] champs)
    {
        impl.DessinerTexte($"Formulaire d'immatriculation - {GetType().Name.Replace("FormulaireImmatriculation", "")}");
        foreach (var champ in champs)
        {
            impl.DessinerChamp(champ);
        }
    }
}

