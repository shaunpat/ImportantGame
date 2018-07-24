using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Newtonsoft.Json;
using ApiFun;

namespace ApiFun
{
    class Program
    {
        static string InputPath = ConfigurationManager.AppSettings["InputFolder"];
        static string ExecutablePath = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
        static List<Character> characters = new List<Character>();

        static void Main(string[] args)
        {
            PrintGreetings();            

            string file1 = System.IO.File.ReadAllText(InputPath + "products.json");
            string file2 = System.IO.File.ReadAllText(InputPath + "characters.json");
            Print("We found some text in our input! ");
            Print(file1);

            Product productFromInput = JsonConvert.DeserializeObject<Product>(file1);
            characters = JsonConvert.DeserializeObject<IEnumerable<Character>>(file2) as List<Character>;

            int characterCount = FunLoop();
            Print(characterCount.ToString());
        }

        public static void Print(string message)
        {
            Console.WriteLine(message);
        }

        public static void PrintGreetings()
        {
            Print("Hello and such :)  Welcome to version 1.1");
            Print("The program executing right now is: " + ExecutablePath + "\\ApiFun.exe");
            Print("We are getting input from: " + InputPath);
        }

        public static int FunLoop()
        {
            int count = 0;
            Print("How many characters did we find in the file?");

            for (int i = 0; i < characters.Count; i++)
            {
                count = count + 1;
            }

            return count;
        }
    }
}