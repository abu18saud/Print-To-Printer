using System;

namespace Print_To_Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int intNum = Convert.ToInt32(Console.ReadLine());
            double doubNum = Convert.ToDouble(Console.ReadLine());


            Printer.Print(text);
            Printer.Print(intNum);
            Printer.Print(doubNum);
        }

        class Printer
        {
            //your code goes here
            static public void Print<T>(T text)
            {
                Console.WriteLine("Showing " + text);
            }
        }
    }
}
