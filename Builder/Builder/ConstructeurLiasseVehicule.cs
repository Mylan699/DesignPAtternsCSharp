namespace Builder
{
    public abstract class ConstructeurLiasseVehicule
    {
        protected Liasse liasse;

        public abstract void ConstruitPart1(string client);

        public abstract void ConstruitPart2(string informationsVehicule);

        public Liasse GetProduit()
        {
            return liasse;
        }
    }

    public class ConstructeurLiasseVehiculeHtml : ConstructeurLiasseVehicule
    {
        public ConstructeurLiasseVehiculeHtml()
        {
            liasse = new LiasseHtml();
        }

        public override void ConstruitPart1(string client)
        {
            liasse.AjouteDocument($"Bon de commande HTML pour {client}");
        }

        public override void ConstruitPart2(string informationsVehicule)
        {
            liasse.AjouteDocument($"Demande d'immatriculation HTML pour {informationsVehicule}");
        }
    }

    public class ConstructeurLiasseVehiculePdf : ConstructeurLiasseVehicule
    {
        public ConstructeurLiasseVehiculePdf()
        {
            liasse = new LiassePdf();
        }

        public override void ConstruitPart1(string client)
        {
            liasse.AjouteDocument($"Bon de commande PDF pour {client}");
        }

        public override void ConstruitPart2(string informationsVehicule)
        {
            liasse.AjouteDocument($"Demande d'immatriculation PDF pour {informationsVehicule}");
        }
    }
}