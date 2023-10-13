using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.TagHelpers;
namespace BSIT3L_Movies.Models
{
    
	public class MovieViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Rating { get; set; }
        public int ReleaseYear { get; set; }
        public string Genre { get; set; }
        public string? Img { get; set; }

        public string Desc { get; set;}

        public string Direct {get; set;}

        public string Link {get; set;}
    }
}

