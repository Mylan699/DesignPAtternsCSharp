namespace BankDocuments
{
    /// <summary>
    /// Représente un relevé bancaire simplifié pour les clients individuels.
    /// </summary>
    public class SimplifiedBankStatement : IBankStatement
    {
        public void Generate()
        {
            Console.WriteLine("Génération un relevé bancaire simplifié avec le logo de la banque...");
        }
    }
}