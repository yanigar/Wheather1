using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WheatherStation.Models
{
    public class Wheather
    {
        public long Id { get; set; }
        public string City { get; set; }
        public int Temp { get; set; }
        public string Summary { get; set; }
    }
}
