using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookManagement.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime PublishedAt { get; set; }
        public double Price { get; set; }
        public bool IsAvailable { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
    }
}
