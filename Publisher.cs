using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBook2
{
    [Table("PublisherInfo")]
    public class Publisher
    {
        public int Id { get; set; }
        [Column("PublisherName")]
        public string Name { get; set; }
    }
}
