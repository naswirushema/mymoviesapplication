
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace MoviesApp.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int CategoryId { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public string Poster { get; set; }
        
       // public Category Category { get; set; }
        
        [BindProperty]
        public Category Category { get; set; }

    }
}