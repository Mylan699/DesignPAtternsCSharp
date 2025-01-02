namespace BankDocuments
{
    /// <summary>
    /// Représente un document de certificat de compte.
    /// </summary>
    public interface IAccountCertificate
    {
        /// <summary>
        /// Génère le certificat de compte.
        /// </summary>
        void Generate();
    }
}