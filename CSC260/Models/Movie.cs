using CSC260.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace CSC260.Models
{
    [NinetysMovieRatingAttributt]
    public class Movie
    {
        public static int nextId = 0;

        private int id = nextId++;

        public int? ID { get { return id; } }
        //[Required(ErrorMessage ="Hey Dummy the Title is Required")]
        public string Title { get; set; }
        //[Range (1980, 2023, ErrorMessage = "Year must be in between 1980 and 2023")]
        public int Year { get; set; } 
        //[Range(0, 5, ErrorMessage = "That is not a rating it must be between 0 and 5")]
        public float Rating { get; set; }

        public DateTime ReleaseDate;

        public Movie()
        {

        }
        public Movie(string title, int year, float rating)
        {
            this.Title = title;
            this.Year = year;
            this.Rating = rating;
        }

        public override string ToString()
        {
            return $"{Title} - {Year} - {Rating} stars";
        }

    }
}
