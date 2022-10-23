using System;

namespace Excursion_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double price = 0;
            double totalPrice = 0;
            switch (season)
            {
                case "spring":
                    //Пролет(spring)
                    //50.00 лв.на човек
                    // 48.00 лв.на човек
                    if (people <= 5)
                    {
                        price = 50;
                        totalPrice = people * price;
                        Console.WriteLine($"{totalPrice:f2} leva.");
                    }
                    else
                    {
                        price = 48;
                        totalPrice = people * price;
                        Console.WriteLine($"{totalPrice:f2} leva.");
                    }
                    break;
                case "summer":
                    if (people <= 5)
                    {
                        price = 48.50;
                        totalPrice = people * price;
                        totalPrice *= 0.85;
                        Console.WriteLine($"{totalPrice:f2} leva.");
                    }
                    else
                    {
                        price = 45;
                        totalPrice = people * price;
                        totalPrice *= 0.85;
                        Console.WriteLine($"{totalPrice:f2} leva.");
                    }
                    break;
                case "autumn":
                    if (people <= 5)
                    {
                        price = 60;
                        totalPrice = people * price;
                        Console.WriteLine($"{totalPrice:f2} leva.");
                    }
                    else
                    {
                        price = 49.50;
                        totalPrice = people * price;
                        Console.WriteLine($"{totalPrice:f2} leva.");
                    }
                    break;
                case "winter":
                    if (people <= 5)
                    {
                        price = 86;
                        totalPrice = people * price;
                        totalPrice *= 1.08;
                        Console.WriteLine($"{totalPrice:f2} leva.");
                    }
                    else
                    {
                        price = 85;
                        totalPrice = people * price;
                        totalPrice *= 1.08;
                        Console.WriteLine($"{totalPrice:f2} leva.");
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
