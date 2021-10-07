using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPVS_projekt1
{
    class MovieTableEntry
    {
        private string movieName;
        private string movieDays;

        public MovieTableEntry()
        {

        }

        public MovieTableEntry(string movieName, string movieDays)
        {
            this.MovieName = movieName;
            this.MovieDays = movieDays;
        }

        public string MovieName { get => movieName; set => movieName = value; }
        public string MovieDays { get => movieDays; set => movieDays = value; }
    }
}
