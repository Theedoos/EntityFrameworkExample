using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityFrameworkExample
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Movie
    {
        public int MovieId { get; set; } //this will be the primary key.
        public string Name { get; set; }
        public int Year { get; set; }
    }

    public class Rating
    {
        public int RatingId { get; set; } //this will be the primary key.
        public string Rater { get; set; }
        public int RatingValue { get; set; }
        public DateTime dateTime { get; set; }
        public Movie MovieId { get; set; } //this will be a forgein key.
    }
}
