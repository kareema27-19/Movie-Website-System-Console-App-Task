
    
using System;
using System.Collections.Generic;

namespace MovieWebsiteSystem
{
    // Movie Class
    class Movie
    {
        // Properties
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }

        private int rating;

        public int Rating
        {
            get { return rating; }

            set
            {
                if (value >= 1 && value <= 10)
                {
                    rating = value;
                }
                else
                {
                    rating = 5; // Default Rating
                }
            }
        }

        // Constructor
        public Movie(string title, string genre, int year, int rating = 5)
        {
            Title = title;
            Genre = genre;
            Year = year;
            Rating = rating;
        }
    }

    // User Class
    class User
    {
        // Properties
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor
        public User(string name, int age)
        {
            Name = name;
            Age = age;

            Console.WriteLine($"Welcome {Name}!");
        }
    }

    // Review Class
    class Review
    {
        // Properties
        public string UserName { get; set; }
        public string MovieTitle { get; set; }
        public string Comment { get; set; }

        private int rate;

        public int Rate
        {
            get { return rate; }

            set
            {
                if (value >= 1 && value <= 10)
                {
                    rate = value;
                }
                else
                {
                    rate = 5;
                }
            }
        }

        // Constructor
        public Review(string userName, string movieTitle, string comment, int rate)
        {
            UserName = userName;
            MovieTitle = movieTitle;
            Comment = comment;
            Rate = rate;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create Movies
            Movie m1 = new Movie("Trasnformers", "Sci-Fi", 2019, 9);
            Movie m2 = new Movie("A Star is Born", "Romance", 2018, 8);
            Movie m3 = new Movie("Commando", "Action", 1985, 10);

            // Store Movies in List
            List<Movie> movies = new List<Movie>()
{
m1, m2, m3
};

            // Create User
            User u1 = new User("Salim", 30);

            // Display Movies
            Console.WriteLine("\nMovies:");
            foreach (Movie movie in movies)
            {
                Console.WriteLine($"{movie.Title} - {movie.Rating}");
            }

            // Create Review
            Review r1 = new Review("Salim", "Commando", "Great movie!", 10);

            // Store Reviews
            List<Review> reviews = new List<Review>()
{
r1
};

            // Display Reviews
            Console.WriteLine("\nReviews:");
            foreach (Review review in reviews)
            {
                Console.WriteLine($"{review.UserName} rated {review.MovieTitle}: {review.Rate} - {review.Comment}");
            }

            Console.ReadKey();
        }
    }
}