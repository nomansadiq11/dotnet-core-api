using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cheapawesome
{
    public class Hotel
    {
        public int HotelId { get; set; }
        public int DestinationId { get; set; }
        public int PropertyId { get; set; }
        public string name { get; set; }
        public int geoId { get; set; }
        public int rating { get; set; }

    }

    public class Rate
    {
        public int HotelId { get; set; }
        public string rateType { get; set; }
        public string boardType { get; set; }
        public double value { get; set; }
    }

    public class hotel
    {
        public List<Hotel> hotels { get; set; }
        public List<Rate> rates { get; set; }
    }
}
