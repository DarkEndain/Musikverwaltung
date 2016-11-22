using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prototyp.Models
{
    public class Songs
    {
        public int ID { get; set; }
        public String Title { get; set; }
        public int Dauer { get; set; }
        public int Titlenummer { get; set; }
        public ICollection<Alben> Albens { get; set; }
    }
}
