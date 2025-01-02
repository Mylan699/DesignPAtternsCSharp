using System;

namespace BankDocuments
{
    /// <summary>
    /// Main program to demonstrate document creation using Abstract Factory pattern.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Individual Client Documents ===");
            IBankDocumentFactory individualFactory = new IndividualDocumentFactory();
            var individualStatement = individualFactory.CreateBankStatement();
            var individualCertificate = individualFactory.CreateAccountCertificate();
            individualStatement.Generate();
            individualCertificate.Generate();

            Console.WriteLine();

            Console.WriteLine("=== Professional Client Documents ===");
            IBankDocumentFactory professionalFactory = new ProfessionalDocumentFactory();
            var professionalStatement = professionalFactory.CreateBankStatement();
            var professionalCertificate = professionalFactory.CreateAccountCertificate();
            professionalStatement.Generate();
            professionalCertificate.Generate();

            Console.WriteLine("\nProcess completed successfully.");
        }
    }
}