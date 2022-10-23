using System;

namespace Football_Kit
{
    class Program
    {
        static void Main(string[] args)
        {
            double tshortPrice = double.Parse(Console.ReadLine());
            double goalPrice = double.Parse(Console.ReadLine());

            double pants = tshortPrice * 0.75;
            double socks = pants * 0.20;
            double shoes = (tshortPrice + pants) * 2;
            double totalPrice = tshortPrice + pants + socks + shoes;
            totalPrice *= 0.85;
            if (totalPrice>=goalPrice)
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {totalPrice:f2} lv.");
            }
            else
            {
                double need = goalPrice - totalPrice;
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {need:f2} lv. more.");
            }
        }
    }
}
