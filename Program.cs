using System;

namespace Computer_Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //total
            double numRatings = 0;
            int currentRating = 0;
            double poss = 0;
            double salesMade = 0;
            //total
            double totalSales = 0;
            for (int i = 1; i <= n; i++)
            {
                int rating = int.Parse(Console.ReadLine());
                currentRating = rating % 10;
                numRatings += currentRating;
                if (currentRating == 2)
                {
                    poss = 0;
                }
                else if (currentRating == 3)
                {
                    poss = 0.50;
                }
                else if (currentRating == 4)
                {
                    poss = 0.70;
                }
                else if (currentRating == 5)
                {
                    poss = 0.85;
                }
                else if (currentRating == 6)
                {
                    poss = 1;
                }
                double calculator = rating / 10;
                double firstTwo = Math.Round(calculator);
                salesMade = firstTwo * poss;
                totalSales += salesMade;
            }
            double finish = numRatings / n;
            Console.WriteLine($"{totalSales:f2}");
            Console.WriteLine($"{finish:f2}");
        }
    }
}
