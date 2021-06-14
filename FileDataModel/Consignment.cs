using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FileDataModel
{
    public class Consignment
    {
        public string Number { get; set; }
        public string Name { get; set; }

        [XmlArrayAttribute("Parcels")]
        public Parcel[] Parcels;
       // public List<Parcel> Parcels { get; set;}
    }
}
