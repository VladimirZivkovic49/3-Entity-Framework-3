using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCatSQL1
{
   public class MovieContext :DbContext

    {
        private Movie selektedMovie;

        public MovieContext()
        {
        }

        public MovieContext(Movie selektedMovie)
        {
            this.selektedMovie = selektedMovie;
        }

        public DbSet<Movie> Movies { get; set; }

    }
}
