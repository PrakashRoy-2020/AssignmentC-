using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialDemo
{
    class linqQueries
    {
        static void Main()
        {
            //1. query syntax
            string[] cities = { "kolkata", "pune", "delhi","hyderabad","honor" };
            //IEnumerable<Object>  or var
            var filtercty = from city in cities
                                            where city.StartsWith("h") 
                                            && city.EndsWith("d")
                                            && city.Length < 15
                                            orderby city select city;
            //var allCty = from city in cities select city;                               
                                            
            foreach(var f in filtercty)
            {
                Console.WriteLine(f);
            }

            //method syntax
            Console.WriteLine("----method syntax----");
            var methodSyntax = cities.Where(c => c.StartsWith("d") && c.Length < 15).
                                OrderBy(c => c).
                                Select(c => c);
            foreach (var f in methodSyntax)
            {
                Console.WriteLine(f);
            }

        }
    }
}   
