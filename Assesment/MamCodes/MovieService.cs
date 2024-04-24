using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.MamCodes
{
    public class MovieService
    {
        private Movie[] movies;
        private int count;


        public MovieService(int capacity) 
        {
            movies = new Movie[capacity];
            count = 0;
        }
        public void InsertMovie(Movie movie)
        {
            if (count < movies.Length)
            {
                movies[count++] = movie;
                Console.WriteLine("Movie added successfully.");
            }
            else
            {
                Console.WriteLine("Movie database is full. Cannot add more movies.");
            }


        }

        public void UpdateMovie(int id, string newName, double newPrice, string newProducer)
        {
            for (int i = 0; i < count; i++)
            {
                if (movies[i].Id == id)
                {
                    movies[i].Name = newName;
                    movies[i].Price= newPrice;
                    movies[i].Producer = newProducer;
                    Console.WriteLine("Movie updated successfully.");
                    return;
                }
            }
            Console.WriteLine("Movie not found.");
        }


        public void DeleteMovie(int id)
        {
            bool found = false;
            for (int i = 0; i < count; i++)
            {
                if (movies[i].Id == id)
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        movies[j] = movies[j + 1];
                    }
                    count--;
                    found = true;
                    Console.WriteLine("Movie deleted successfully.");
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Movie not found.");
            }
        }

        public Movie DisplayMovieById(int id)
        {
            foreach (var movie in movies)
            {
                if (movie != null && movie.Id == id)
                {
                    return movie;
                }
            }
            return null;
        }

        public Movie[] ListOfAllMovies()
        {
            Movie[] allMovies = new Movie[count];
            Array.Copy(movies, allMovies, count);
            return allMovies;
        }

        public Movie SearchMovieByMovieName(string name)
        { 
         foreach (var movie in movies)
            {
                if (movie != null && movie.Name == name)
                {
                    return movie;
                }
            }
            return null;
        }
    }
}
