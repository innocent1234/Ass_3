using System;
using System.ComponentModel.DataAnnotations;

namespace MovieWebApp.Models
{
    public class Movie
    {
        [Key]
        public string Tittle { get; set; }
        [DataType(DataType.Date)] 
        public DateTime ReleasedDate { get; set; }
        public int Price { get; set; }
        public byte[] Poster { get; set; }
        public string CategoryName { get; set; }
    }
}