namespace Builder
{
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
}