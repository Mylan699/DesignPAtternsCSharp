namespace Builder
{
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