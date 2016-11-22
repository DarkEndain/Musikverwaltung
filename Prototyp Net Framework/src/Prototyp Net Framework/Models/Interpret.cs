using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prototyp_Net_Framework.Models
{
    public class Interpret
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Vorname { get; set; }
        public DateTime Geburtsdatum { get; set; }
        public ICollection<Album> Alben { get; set; }
    }
}
