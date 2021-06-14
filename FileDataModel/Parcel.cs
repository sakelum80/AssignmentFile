using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FileDataModel
{
    public class Parcel
    {
        public string ParcelCode { get; set; }

       [XmlArrayAttribute("Items")]
       public Item[] OrderedItems;
       // public List<Item> OrderedItems { get; set; }
    }
}
