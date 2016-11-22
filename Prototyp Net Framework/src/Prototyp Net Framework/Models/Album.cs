using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prototyp_Net_Framework.Models
{
    public class Album
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime Datum { get; set; }
        public string Beschreibung { get; set; }
    }
}
