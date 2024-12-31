namespace Bridge;

public class FormulaireImmatriculationFrance : FormulaireImmatriculation
{
    public FormulaireImmatriculationFrance(ImplFormulaireImmatriculation impl)
        : base(impl)
    {
    }

    public override void Afficher()
    {
        impl.DessinerTexte("Formulaire d'immatriculation - France");
        impl.DessinerChamp("Numéro de plaque");
    }
}
