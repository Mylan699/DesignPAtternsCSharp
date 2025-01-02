using System;

namespace BankDocuments
{
    /// <summary>
    /// Représente un certificat de compte avec mentions légales pour les clients professionnels.
    /// </summary>
    public class LegalAccountCertificate : IAccountCertificate
    {
        public void Generate()
        {
            Console.WriteLine("Génération d'un certificat de compte avec mentions légales et logo de la banque...");
        }
    }
}