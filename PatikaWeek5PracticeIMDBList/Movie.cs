using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaWeek5PracticeIMDBList
{
    public class Movie // Creating a new class
    {   
        // Defining fields
        private double _imdbRate; 

        private string _movieName;

        // Defining properties
        public double ImdbRate {  get; set; }

        public string MovieName { get; set; }

        public Movie(double imdbRate, string movieName) // Building an constructor that gets parameters
        {
            ImdbRate = imdbRate;
            MovieName = movieName;
        }

        public void DisplayAllMovies() // Method that display all movies
        {
            Console.WriteLine($"Film adı: {MovieName}, IMDB Puanı: {ImdbRate}");
        }

        public void DisplayOnly4Between9() // Method that display movies only imdb rate is between 4 and 9

        {
            if (ImdbRate <= 9 && ImdbRate >= 4) // Condition
            {
                Console.WriteLine($"Film adı: {MovieName}, IMDB Puanı: {ImdbRate}");
            }
        }

        public void DisplayStartingLetterA() // Method that display movies only starting with letter "A"
        {
            
            if (MovieName.ToLower().StartsWith("a")) // Condition
            {
                Console.WriteLine($"Film adı: {MovieName}, IMDB Puanı: {ImdbRate}");
            }
        }

    }
}
