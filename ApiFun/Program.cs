using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Newtonsoft.Json;

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

            string file1 = System.IO.File.ReadAllText(InputPath + "products.json");
            string file2 = System.IO.File.ReadAllText(InputPath + "characters.json");
            Print("We found some text in our input! ");
            Print(file1);

            Product productFromInput = JsonConvert.DeserializeObject<Product>(file1);
            List<Character> characters = JsonConvert.DeserializeObject<IEnumerable<Character>>(file2) as List<Character>;
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

class CharacterList
{
    public List<Character> characters { get; set; }
}

class Character
{
    [JsonProperty("CharacterName")]
    public string CharacterName { get; set; }
    [JsonProperty("CharacterLevel")]
    public string CharacterLevel { get; set; }
    [JsonProperty("CharacterLocation")]
    public string CharacterLocation{ get; set; }
}