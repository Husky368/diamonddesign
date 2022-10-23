using System;

namespace Hair_Salon
{
    class Program
    {
        static void Main(string[] args)
        {
            int goal = int.Parse(Console.ReadLine());
            string action = Console.ReadLine();
            int budget = 0;
            int reached = 0;
            while (action!="closed")
            {
                switch (action)
                {
                    case "haircut":
                        string type = Console.ReadLine();
                        if (type=="mens")
                        {
                            budget += 15;
                        }
                        else if (type == "ladies")
                        {
                            budget += 20;
                        }
                        else
                        {
                            budget += 10;
                        }
                        break;
                    case "color":
                        string typee = Console.ReadLine();
                        if (typee == "touch up")
                        {
                            budget += 20;
                        }
                        else
                        {
                            budget += 30;
                        }
                        break;
                    default:
                        break;
                }
                if (budget>=goal)
                {
                    Console.WriteLine("You have reached your target for the day!");
                    Console.WriteLine($"Earned money: {budget}lv.");
                    reached++;
                    break;
                }
                action = Console.ReadLine();
            }
            if (reached==0)
            {
                int need = goal - budget;
                Console.WriteLine($"Target not reached! You need {need}lv. more.");
                Console.WriteLine($"Earned money: {budget}lv.");
            }
        }
    }
}
