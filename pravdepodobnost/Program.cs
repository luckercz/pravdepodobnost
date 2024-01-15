namespace pravdepodobnost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.WriteLine("Napis pocet serii:");
            int series = 10000;
            Console.WriteLine("Napis kolikrat za sebou ma padnout:");
            int correct = 0;

            for (int serieNumber = 0; serieNumber < series; serieNumber++)
            {
                int inRow = 0;
                int lastFlip = -1;
                for (int flipNumber = 0; flipNumber < 100; flipNumber++)
                {
                    int flip = rnd.Next(2);
                    if (flip == lastFlip) inRow++;
                    else
                    {
                        inRow = 1;
                        lastFlip = flip;
                    }

                    if (inRow == 7)
                    {
                        correct++;
                        break;
                    }
                }
            }
            double propability = ((double)correct / series)*100;
            Console.WriteLine(propability + "%");
        }
    }
}