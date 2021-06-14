using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FileDataModel
{
    [XmlRootAttribute("Orders", Namespace = "http://www.Assignement.com",
      IsNullable = false)]
    public class Order
    {       
        public decimal TotalWeight { get; set; }        
        public decimal TotalValue { get; set; }       
        public string OrderId { get; set; }

        [XmlArrayAttribute("Order")]
        public Consignment[] Consignments;
       //public List<Consignment> Consignments { get; set; }
      
    }


}
