namespace BankDocuments
{
    /// <summary>
    /// Usine de création de documents pour les clients professionnels.
    /// </summary>
    public class ProfessionalDocumentFactory : IBankDocumentFactory
    {
        public IBankStatement CreateBankStatement()
        {
            return new DetailedBankStatement();
        }

        public IAccountCertificate CreateAccountCertificate()
        {
            return new LegalAccountCertificate();
        }
    }
}