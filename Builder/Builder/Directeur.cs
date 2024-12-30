namespace Builder
{
    public class Directeur
    {
        private readonly ConstructeurLiasseVehicule constructeur;

        public Directeur(ConstructeurLiasseVehicule constructeur)
        {
            this.constructeur = constructeur;
        }

        public Liasse Construit(string client, string informationsVehicule)
        {
            constructeur.ConstruitPart1(client);
            constructeur.ConstruitPart2(informationsVehicule);
            return constructeur.GetProduit();
        }
    }
}