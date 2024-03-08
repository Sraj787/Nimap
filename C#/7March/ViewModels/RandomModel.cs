using ProboVideo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProboVideo.ViewModels
{
    public class RandomModel
    {
        public Movie Movie { get; set; }
        public IEnumerable<Genre> Genres{ get; set; }
    }
}
