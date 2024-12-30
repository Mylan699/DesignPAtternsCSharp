namespace Builder
{
    public class Vendeur
    {
        private readonly Directeur directeur;

        public Vendeur(Directeur directeur)
        {
            this.directeur = directeur;
        }

        public void GereVente(string client, string informationsVehicule)
        {
            var liasse = directeur.Construit(client, informationsVehicule);
            liasse.Imprime();
        }
    }
}