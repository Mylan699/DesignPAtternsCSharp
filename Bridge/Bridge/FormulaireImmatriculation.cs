namespace Bridge;

public abstract class FormulaireImmatriculation
{
    protected ImplFormulaireImmatriculation impl;

    public FormulaireImmatriculation(ImplFormulaireImmatriculation impl)
    {
        this.impl = impl;
    }

    public abstract void Afficher();
}
