using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;

namespace AppResto.Models
{
    class Restaurant
    {
        public int Id { get; set; }
        public String Nom { get; set; }
        public String Adresse { get; set; }
        public String Photo {get; set;}
        public Geopoint position_loc { get; set; }
        public int prix_mini { get; set; }
        public int prix_maxi { get; set; }
        public int phone { get; set; }
    }
}
