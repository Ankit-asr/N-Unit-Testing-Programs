using System;

namespace N_Unit_Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to N Unit Testing Programs");
            Console.WriteLine("Press Any Key for Program Menu");
            Console.ReadKey();
            Console.WriteLine("Press 1 for Vending Machine Program");
            Console.WriteLine("Press 2 for Day Of Week Program");
            Console.WriteLine("Press 3 for Temparature Conversion Program");
            Console.WriteLine("Press 4 for Monthly Payment Program");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("You selected Vending Machine Program");
                    VendingMachine obj1 = new VendingMachine();
                    obj1.Withdrawal();
                    break;
                case 2:
                    Console.WriteLine("You selected Day Of Week Program");
                    Date obj2 = new Date();
                    Date.DayOfWeek();
                    break;
                case 3:
                    Console.WriteLine("You selected Temparature Conversion Program");
                    TemperatureConversion.Conversion();
                    break;
                case 4:
                    Console.WriteLine("You selected Monthly Payment Program");
                    Payment.MonthlyPayment();
                    break;
                default:
                    Console.WriteLine("You Entered Wrong Choice");
                    break;
            }
        }
    }
}