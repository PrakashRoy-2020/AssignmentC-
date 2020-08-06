using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace PartialDemo
{
    public static class MyLinq
    {
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> source,Func<T,bool> predicate)
        {
            var result = new List<T>();
            foreach (var i in source)
            {
                if (predicate(i))
                {
                    result.Add(i);
                }
            }
            return result;
        }
    }
    class Movie
    {
        public string Title { get; set; }
        public float Rating { get; set; }
        public int Year { get; set; }

    }
    class ComplesLinq
    {
        static void main()
        {
            var movies = new List<Movie>
            {
                new Movie{Title="super deluxe",Rating=4.2f,Year=2019},
                new Movie{Title="special 26",Rating=4.8f,Year=2014},
                new Movie{Title="horror",Rating=4.4f,Year=2000}
            };
            //var query = movies.Where(m => m.Year > 2010);
            //foreach ( var q in query)
            //{
            //    Console.WriteLine($"{q.Title}and{q.Rating}and{q.Year}");
            //}


            //custom filter method
            var query1 = movies.Filter(m => m.Title.StartsWith("s"));
            foreach (var q in query1)
            {
                Console.WriteLine($"{q.Title}and{q.Rating}and{q.Year}");
            }
        }
    }
}
