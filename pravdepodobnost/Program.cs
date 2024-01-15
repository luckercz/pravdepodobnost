namespace pravdepodobnost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int correct = 0;
            int series = 1000;

            for (int serieNumber = 0; serieNumber < series; serieNumber++)
            {
                int inRow = 0;
                int lastFlip = 0;
                for (int flipNumber = 0; flipNumber < 100; flipNumber++)
                {
                    int flip = rnd.Next(2);
                    if (flip == lastFlip) inRow++;
                    else
                    {
                        inRow = 0;
                        lastFlip = 1 - lastFlip;
                    }

                    if (inRow == 7)
                    {
                        correct++;
                        break;
                    }
                }
            }
            double propability = ((double)correct / series)*100;
            Console.WriteLine(propability);
        }
    }
}