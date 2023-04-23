using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignments
{
    namespace Entities
    {
        public class Movie
        {


            public string MovieTite { get; set; }
            public int ReleaseYear { get; set; }
            public string HeroName { get; set; }
            public string genre { get; set; }

        }
    }

    namespace DataLayer
    {
        using Entities;
        class MovieManager
        {
            const int StorageValue = 100;

            private Movie[] movies = new Movie[StorageValue];



            public void AddNewMovie(Movie movie)
            {
                for (int i = 0; i < StorageValue; i++)
                {
                    if (movies[i] == null)
                    {
                        movies[i] = new Movie
                        {
                            MovieTite = movie.MovieTite,
                            ReleaseYear = movie.ReleaseYear,
                            HeroName = movie.HeroName,
                            genre = movie.genre
                        };
                        return;
                    }
                }
            }




            public Movie[] GetAllMovie(string finder)
            {
                int count = 0;
                foreach (Movie item in movies)
                {
                    if (item != null && item.MovieTite.Contains(finder))
                    {
                        count++;
                    }
                }

                if (count != 0)
                {
                    int tempIndex = 0;//For storing local index
                    Movie[] foundMovie = new Movie[count];
                    foreach (Movie item in movies)
                    {
                        if (item != null && item.MovieTite.Contains(finder))
                        {
                            foundMovie[tempIndex] = item;
                            tempIndex++;
                        }
                    }
                    return foundMovie;
                }
                else
                    return null;
            }

            public void updateMovie(Movie movie)
            {
                for (int i = 0; i < StorageValue; i++)
                {
                    if (movies[i] != null && movies[i].MovieTite == movie.MovieTite)
                    {
                        movies[i].MovieTite = movie.MovieTite;
                        movies[i].ReleaseYear = movie.ReleaseYear;
                        movies[i].HeroName = movie.HeroName;
                        movies[i].genre = movie.genre;
                        return;
                    }
                }
            }

            internal void DeleteTheExpense(string movieTite)
            {
                for (int i = 0; i < StorageValue; i++)
                {
                    if (movies[i].MovieTite == movieTite)
                    {
                        movies[i] = null;
                    }
                    return;
                }
            }
        }

        namespace UILayer
        {
            using DataLayer;
            using Entities;
            using SampleConApp;

            class assgn5
            {

                #region Data
                const string filePath = @"C:\Users\sahanar\OneDrive - First American Corporation\Documents\FAI-April2023\Assignments\SampleAssgn\Assignments\MovieMenu.txt";
                static MovieManager manager = new MovieManager();
                #endregion
                static void clearScreen()
                {
                    Console.WriteLine("Press any key to clear");
                    Console.ReadKey();
                    Console.Clear();
                }
                static string getMenu()
                {
                    return File.ReadAllText(filePath);
                }
                static void Main(string[] args)
                {
                    string menu = getMenu();
                    bool processing = true;
                    do
                    {
                        string choice = UIConsole.GetString(menu);
                        processing = processMenu(choice);
                        clearScreen();
                    } while (processing);
                }

                private static bool processMenu(string choice)
                {
                    switch (choice)
                    {
                        case "N":
                            addMovieHelper();
                            return true;
                        case "U":
                            updateMovieHelper();
                            return true;
                        case "F":
                            findMovieHelper();
                            return true;
                        case "D":
                            deleteMovieHelper();
                            return true;
                        default:
                            return false;
                    }
                }

                private static void deleteMovieHelper()
                {
                    Movie exobj = new Movie();
                    exobj.MovieTite = UIConsole.GetString("Enter the Movir name to be deleted");
                    manager.DeleteTheExpense(exobj.MovieTite);
                    UIConsole.PrintMessage("Deletion Successful");
                }

                private static void findMovieHelper()
                {
                    string finder = UIConsole.GetString("Enter the Movie name to find");
                    Movie[] movies = manager.GetAllMovie(finder);
                    if (movies != null)
                    {
                        foreach (Movie movie in movies)
                        {
                            Console.WriteLine($"{movie.HeroName} is the hero of {movie.MovieTite} movie which was released on {movie.ReleaseYear}. The genre of movie was{movie.genre}!! ");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No movies found matching the criteria");
                    }

                }

                private static void updateMovieHelper()
                {
                    Movie movieObj = new Movie();

                    movieObj.MovieTite = UIConsole.GetString("Enter the Movie Name to be updated ");
                    movieObj.ReleaseYear = UIConsole.GetNumber("Enter the Release Year to be updated");
                    movieObj.HeroName = UIConsole.GetString("Enter the Hero Nameto be updated");
                    movieObj.genre = UIConsole.GetString("Enter the genre to be updated");

                    manager.updateMovie(movieObj);
                    UIConsole.PrintMessage("Movie Updated Successfully");
                }

                private static void addMovieHelper()
                {
                    Movie movieObj = new Movie();

                    movieObj.MovieTite = UIConsole.GetString("Enter the Movie Name");
                    movieObj.ReleaseYear = UIConsole.GetNumber("Enter the Release Year");
                    movieObj.HeroName = UIConsole.GetString("Enter the Hero Name");
                    movieObj.genre = UIConsole.GetString("Enter the genre");

                    manager.AddNewMovie(movieObj);
                    UIConsole.PrintMessage("Movie Added Successfully");
                }
            }
        }

    }
}
