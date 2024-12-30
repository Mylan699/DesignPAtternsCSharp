namespace Builder
{
    public class ConstructeurLiasseVehiculeHtml : IConstructeurLiasseVehicule
    {
        private LiasseHtml liasse = new LiasseHtml();

        public void ConstruitPart1(string client)
        {
            liasse.AjouteDocument($"Bon de commande HTML pour {client}");
        }

        public void ConstruitPart2(string informationsVehicule)
        {
            liasse.AjouteDocument($"Demande d'immatriculation HTML pour {informationsVehicule}");
        }

        public Liasse GetProduit()
        {
            return liasse;
        }
    }
}