using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProboVideo.Models
{
    public class Movie
    {

        [Required]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public Genre genre { get; set; }

        public byte genreId { get; set; }
        public DateTime AddedDate { get; set;}

        public DateTime ReleaseDate { get; set;}

        public byte NumberInStock {  get; set;}

    }
}