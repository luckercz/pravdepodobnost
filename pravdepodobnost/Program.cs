namespace pravdepodobnost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int correct = 0;
            int series = 1000;

            Console.WriteLine("Napis pocet serii:");
            int series = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Napis kolikrat za sebou ma padnout:");
            int row = Convert.ToInt32(Console.ReadLine());
            int correct = 0;
            Console.Clear();
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

                    if (inRow == row)
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