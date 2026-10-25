using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace G_NET69_EF_Assignment_1.Models
{
    internal class Book
    {
        [Key]
        public int ISBN { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int PagesNumber { get; set; }
        public int PublishYear { get; set; }
        public bool InStock { get; set; }
    }
}
