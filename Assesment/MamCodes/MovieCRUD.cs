using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.MamCodes
{
  

    public class MovieCRUD
    {
      
        static void Main(string[] args)
        {
           
            MovieService movieService = new MovieService(10);
            
            while(true)
            { 
            Console.WriteLine("1.Insert Movie");
            Console.WriteLine("2.Update Movie");
            Console.WriteLine("3.Delete Movie");
            Console.WriteLine("4.Display Movie by id");
            Console.WriteLine("5.List of All Movies");
            Console.WriteLine("6.Search Movie by Movie Name");
            Console.WriteLine("7.Exit");

            Console.WriteLine("Enter your choice: ");
            int choice=int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:

                        Console.WriteLine("Enter Movie Id:");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Movie Name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter Movie ticket price:");
                        double price = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter Producer Name:");
                        string producer = Console.ReadLine();

                        movieService.InsertMovie(new Movie(id, name, price, producer));
                        break;

                    case 2:
                        Console.Write("Enter movie ID to update: ");
                        int updateId = int.Parse(Console.ReadLine());
                        Console.Write("Enter new movie name: ");
                        string newName = Console.ReadLine();
                        Console.Write("Enter new ticket Price: ");
                        double newPrice = double.Parse(Console.ReadLine());
                        Console.Write("Enter new producer name: ");
                        string newProducer = Console.ReadLine();

                        movieService.UpdateMovie(updateId, newName, newPrice, newProducer);
                        break;
                    case 3:
                        Console.Write("Enter movie ID to delete: ");
                        int deleteId = int.Parse(Console.ReadLine());
                        movieService.DeleteMovie(deleteId);
                        break;
                    case 4:
                        Console.Write("Enter movie ID to display: ");
                        int displayId = int.Parse(Console.ReadLine());
                        Movie movie=movieService.DisplayMovieById(displayId);
                        if (movie != null)
                        {
                            Console.WriteLine($"ID: {movie.Id}, Name: {movie.Name}, Ticket Cost: {movie.Price:C}, Producer: {movie.Producer}");
                        }
                        else
                        {
                            Console.WriteLine("Movie not found.");
                        }
                        break;
                    case 5:
                        Console.WriteLine("All Movies:");
                       foreach(Movie m in movieService.ListOfAllMovies())
                        {
                            Console.WriteLine($"ID: {m.Id}, Name: {m.Name}, Ticket Cost: {m.Price:C}, Producer: {m.Producer}");
                        }
                        break;
                    case 6:
                        Console.Write("Enter movie Name to display: ");
                        string displayName = Console.ReadLine();
                        Movie movienm = movieService.SearchMovieByMovieName(displayName);
                        if (movienm != null)
                        {
                            Console.WriteLine($"ID: {movienm.Id}, Name: {movienm.Name}, Ticket Cost: {movienm.Price:C}, Producer: {movienm.Producer}");
                        }
                        else
                        {
                            Console.WriteLine("Movie not found.");
                        }
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
