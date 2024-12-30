namespace Builder
{
    public interface IConstructeurLiasseVehicule
    {
        void ConstruitPart1(string client);
        void ConstruitPart2(string informationsVehicule);
        Liasse GetProduit();
    }
}