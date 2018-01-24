using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportantGame
{
    class Program
    {
        static void Main(string[] args)
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
