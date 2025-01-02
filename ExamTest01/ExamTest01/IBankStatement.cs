namespace BankDocuments
{
    /// <summary>
    /// Représente un document d'extrait de compte.
    /// </summary>
    public interface IBankStatement
    {
        /// <summary>
        /// Génère l'extrait de compte.
        /// </summary>
        void Generate();
    }
}