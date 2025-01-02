using System;

namespace BankDocuments
{
    /// <summary>
    ///  Représente un certificat de compte standard pour les clients individuels.
    /// </summary>
    public class StandardAccountCertificate : IAccountCertificate
    {
        public void Generate()
        {
            Console.WriteLine("Génération d'un certificat de compte standard avec le logo de la banque...");
        }
    }
}