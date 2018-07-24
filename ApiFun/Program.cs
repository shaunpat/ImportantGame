using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ApiFun
{
    class Program
    {
        static void Main(string[] args)
        {
            Print("Hello and such :)");
            
            string ExecutablePath = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            Print("The program executing right now is: " + ExecutablePath + "\\ApiFun.exe");

            string InputPath = ConfigurationManager.AppSettings["InputFolder"];
            Print("We are getting input from: " + InputPath);

            string text = System.IO.File.ReadAllText(InputPath + "products.json");
            Print("We found some text in our input! ");
            Print(text);
        }

        public static void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}

class Product
{
    public string ProductId { get; set; }
    public string ProductName { get; set; }
}