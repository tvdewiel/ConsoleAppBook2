using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ConsoleAppBook2
{
    public class Book
    {
        [Key]
        public string ISBN { get; set; }
        [MaxLength(200)]
        public string Title { get; set; }
        public int? NumberOfPages { get; set; }
        public int? PublisherId { get; set; }
        public Publisher Publisher { get; set; }
        public List<Review> Reviews { get; set; }=new List<Review>();
        public ICollection<Author> Authors { get; set; }
        public PriceOffer PriceOffer { get; set; }
    }
}
