using System;
using Newtonsoft.Json;

namespace DotNetFrameworkApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new { Name = "John Doe", Age = 30 };
            string json = JsonConvert.SerializeObject(person);
            Console.WriteLine("Serialized JSON: " + json);
        }
    }
}