using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prototyp.Models
{
    public class Interpreten
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Vorname { get; set; }
        public DateTime Geburtsdatum { get; set; }
        public ICollection<Alben> Alben { get; set; }
    }
}
