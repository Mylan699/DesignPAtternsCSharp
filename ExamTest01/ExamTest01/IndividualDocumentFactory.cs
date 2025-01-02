namespace BankDocuments
{
    /// <summary>
    /// Usine de création de documents pour les clients individuels.
    /// </summary>
    public class IndividualDocumentFactory : IBankDocumentFactory
    {
        public IBankStatement CreateBankStatement()
        {
            return new SimplifiedBankStatement();
        }

        public IAccountCertificate CreateAccountCertificate()
        {
            return new StandardAccountCertificate();
        }
    }
}