using System;
using System.Collections.Generic;
using System.Linq;

namespace MyFamily
{
    class Program
    {
        static void Main(string[] args)
        {
          var myFamily = new Dictionary<string, Dictionary<string, string>>();
            myFamily.Add("sister", new Dictionary<string, string>() { { "name", "Krista" }, { "age", "42" } });
            myFamily.Add("husband", new Dictionary<string, string>() { { "name", "Ray" }, { "age", "46" } });
            myFamily.Add("son", new Dictionary<string, string>() { { "name", "Ray Jr" }, { "age", "10" } });
            myFamily.Add("daughter", new Dictionary<string, string>() { { "name", "Chasity" }, { "age", "27" } });
            myFamily.Add("Mother", new Dictionary<string, string>() { { "name", "Marian" }, { "age", "65" } });
            myFamily.Add("brother", new Dictionary<string, string>() { { "name", "Dedrick" }, { "age", "35" } });
            myFamily.Add("grandchild", new Dictionary<string, string>() { { "name", "Chase" }, { "age", "8" } });
            foreach (var person in myFamily)
            {
                Console.WriteLine($"I love my {person.Key} {person.Value["name"]} and they are {person.Value["age"]} years old.");
            }

        }
    }
}
