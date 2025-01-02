namespace BankDocuments
{
    /// <summary>
    /// Définit des méthodes pour créer des documents bancaires pour différents types de clients.
    /// </summary>
    public interface IBankDocumentFactory
    {
        IBankStatement CreateBankStatement();
        IAccountCertificate CreateAccountCertificate();
    }
}