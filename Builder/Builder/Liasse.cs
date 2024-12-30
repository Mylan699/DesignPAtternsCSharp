using System;
using System.Collections.Generic;

namespace Builder
{
    public abstract class Liasse
    {
        protected List<string> documents = new List<string>();

        public void AjouteDocument(string document)
        {
            documents.Add(document);
        }

        public abstract void Imprime();
    }

    public class LiasseHtml : Liasse
    {
        public override void Imprime()
        {
            Console.WriteLine("Liasse HTML :");
            foreach (var document in documents)
            {
                Console.WriteLine(document);
            }
        }
    }

    public class LiassePdf : Liasse
    {
        public override void Imprime()
        {
            Console.WriteLine("Liasse PDF :");
            foreach (var document in documents)
            {
                Console.WriteLine(document);
            }
        }
    }
}