using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bibabook.Implementation.Models
{
    public class GeoCoordinate
    {
        public double Altitude { get; set; }
        public double Course { get; set; }
        public double HorizontalAccuracy { get; set; }
        public bool IsUnknown { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Speed { get; set; }
        public double VerticalAccuracy { get; set; }

        public GeoCoordinate() { }

        public GeoCoordinate(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

    }
}