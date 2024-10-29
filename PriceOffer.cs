using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBook2
{
    public class PriceOffer
    {
        public int Id { get; set; }
        public double NewPrice { get; set; }
        public string PromoText { get; set; }
        public string BookISBN { get; set; }
        public Book Book { get; set; }
    }
}
