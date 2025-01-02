using System;

namespace BankDocuments
{
    /// <summary>
    /// Représente un relevé bancaire détaillé pour les clients professionnels.
    /// </summary>
    public class DetailedBankStatement : IBankStatement
    {
        public void Generate()
        {
            Console.WriteLine("Génération d'un relevé bancaire détaillé avec SIRET et logo de la banque...");
        }
    }
}