using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportantGame
{
    class Program
    {
        private static List<int> numbers = new List<int>();

        static void Main(string[] args)
        {
            DoThingTwo();

            DoThingOne();
        }

        private static void DoThingTwo()
        {
            numbers.Add(0);
            numbers.Add(2);
            numbers.Add(4);
            numbers.Add(6);
            numbers.Add(8);

            foreach (var number in numbers)
            {
                Print(number.ToString());
            }
        }

        private static void DoThingOne()
        {
            for (int i = 0; i < 10; i++)
            {
                Print("Game is executing.." + i);
            }
        }

        static void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
