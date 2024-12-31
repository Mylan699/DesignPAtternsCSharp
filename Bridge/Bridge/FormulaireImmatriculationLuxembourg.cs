namespace Bridge;

public class FormulaireImmatriculationLuxembourg : FormulaireImmatriculation
{
    public FormulaireImmatriculationLuxembourg(ImplFormulaireImmatriculation impl)
        : base(impl)
    {
    }

    public override void Afficher()
    {
        impl.DessinerTexte("Formulaire d'immatriculation - Luxembourg");
        impl.DessinerChamp("Numéro de plaque");
    }
}
