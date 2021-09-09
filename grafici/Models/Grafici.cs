using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Smeni.Models
{
    public class Grafici
    {
        [Key]
        public int Id { get; set; }
        public string Nomer { get; set; }
        public DateTime Ot { get; set; }
        public DateTime Do { get; set; }
        public List<Grafici> Grafikk { get; set; }
    }
}
