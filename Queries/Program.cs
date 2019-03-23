using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var movies = new List<Movie>
            {
                new Movie { Title = "The Dark Knight", Rating = 8.9f, Year = 2008},
                new Movie { Title = "The King's Speech", Rating = 8.0f, Year = 2010},
                new Movie { Title = "Casablanca", Rating = 8.5f, Year = 1942},
                new Movie { Title = "Star Wars V", Rating = 8.7f, Year = 1980}
            };

            var query = Enumerable.Empty<Movie>();

            try
            {
                query = movies.Where(m => m.Year > 2000).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //using extension method syntax && implementing deferred execution...i.e. query does no real work until we force it to produce a result
            //defining the query...
            //var query = movies.Filter(m => m.Year > 2000).ToList();
            //demonstating how deferred execution can be bad...looping through once to get the count and then through the same list again to get the titles
            //adding ToList to the query creates a concrete list that reduces redundency
            //Console.WriteLine(query.Count());

            //USING ENUMERATOR WHILE LOOP INSTEAD OF A FOREACH
            var enumerator = query.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current.Title);
            }

            //executing the query via foreach loop
            //foreach (var movie in query)
            //{
            //    Console.WriteLine(movie.Title);
            //}

            Console.ReadLine();
            
        }
    }
}
