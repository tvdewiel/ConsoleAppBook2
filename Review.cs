using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBook2
{
    public class Review
    {
        public int ReviewId { get; set; }
        [Column(TypeName ="nvarchar(500)")]
        public string Text { get; set; }
        public int Stars {  get; set; }
    }
}
