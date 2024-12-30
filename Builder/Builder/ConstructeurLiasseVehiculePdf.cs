namespace Builder
{
    public class ConstructeurLiasseVehiculePdf : IConstructeurLiasseVehicule
    {
        private LiassePdf liasse = new LiassePdf();

        public void ConstruitPart1(string client)
        {
            liasse.AjouteDocument($"Bon de commande PDF pour {client}");
        }

        public void ConstruitPart2(string informationsVehicule)
        {
            liasse.AjouteDocument($"Demande d'immatriculation PDF pour {informationsVehicule}");
        }

        public Liasse GetProduit()
        {
            return liasse;
        }
    }
}