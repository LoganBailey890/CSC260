using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoGameLibary.Models
{
    public class VideoGame
    {
        public static int nextId = 0;

        private int id = nextId++;

        public int? ID { get { return id; } }
        public string Title { get; set; } = "[No title]";

        public string PlatForm { get; set; } = "[No platform]";

        public string Genre { get; set; } = "[No genre]";

        public string AgeRateing { get; set; } = "[Not rated]";

        public int yearReleased { get; set; } = 2000;

        public DateTime? LoanedData { get; set; }

        public string Image { get; set; }


        public VideoGame()
        {

        }

        public VideoGame(string title, string platform,string genre,string age, int year, string image )
        {
            this.Title = title;
            this.PlatForm = platform;
            this.Genre = genre;
            this.AgeRateing = age;
            this.yearReleased = year;
            this.Image = image;
        }

        public void Loan()
        {
            LoanedData = DateTime.Now;
        }

        public void Return()
        {
            LoanedData = null;
        }
    }
}
