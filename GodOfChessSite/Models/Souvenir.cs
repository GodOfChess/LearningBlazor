using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GodOfChessSite.Models
{
    public class Souvenir
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Maker { get; set; }
        public string Country { get; set; }
        public int Price { get; set; }
        public int Year { get; set; }
    }
}
