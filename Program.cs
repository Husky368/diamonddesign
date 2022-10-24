using System;

namespace Substitute
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            for (int K = k; K <= 8; K++)
            {
                string wordK = Convert.ToString(K);
                for (int i = 9; i >= l; i--)
                {
                    string wordi = Convert.ToString(i);
                    string wordFirst = wordK + wordi;
                    int firstNum = int.Parse(wordFirst);
                    for (int M = m; M <= 8; M++)
                    {
                        string wordM = Convert.ToString(M);
                        for (int N = 9; N >= n; N--)
                        {
                            string wordN = Convert.ToString(N);
                            string wordSecond = wordM + wordN;
                            int secondNum = int.Parse(wordSecond);
                            if (firstNum == secondNum)
                            {
                                Console.WriteLine("Cannot change the same player.");
                            }
                            if (K % 2 == 0 && M % 2 == 0 && i%2==1&&N%2==1)
                            {
                                Console.WriteLine($"{firstNum} - {secondNum}");
                            }
                        }
                    }
                }
            }
        }
    }
}
