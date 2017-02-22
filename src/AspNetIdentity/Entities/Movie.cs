using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetIdentity.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Country { get; set; }
        public string Language { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
