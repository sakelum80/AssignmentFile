using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using FileDataModel;

namespace FileService
{
    public class PurchageOrder
    {
        Item item = new Item();
      // List<Item> itemList = new List<Item>();

        Parcel parcel = new Parcel();
        //List<Parcel> parcelList = new List<Parcel>();

        Consignment consignment = new Consignment();
        //List<Consignment> consignmentList = new List<Consignment>();

        Order order = new Order();

        private int quantity;
        private decimal value;
        private decimal weight;
        private string currency;
        private decimal totalWegit;
        private decimal totalValue;

        public PurchageOrder()
        {

        }
               
        
        public PurchageOrder(string rowData)
        {
            
            string[] data = rowData.Split(',');

            quantity = Convert.ToInt32(data[9]);
            item.Quantity = quantity;

            value = Convert.ToDecimal(data[10]);
            item.Value = value;

            totalValue += value;

            weight = Convert.ToDecimal(data[11]);
            item.Weight = weight;

            totalWegit += weight;

           item.Description = data[12];

            if (string.IsNullOrEmpty(data[13]))
            {
                currency = "GBP";
            }
            else
            {
                currency = data[13];
            }

            item.Currency = currency;

            //itemList.Add(item);

            Item[] arrItem = { item };

            
            parcel.ParcelCode = data[2];


            parcel.OrderedItems = arrItem;

            Parcel[] arrParcel = { parcel };

            consignment.Number = data[1];
            consignment.Name = data[3];

            consignment.Parcels = arrParcel;

            Consignment[] arrConsignment = { consignment };

            order.OrderId = data[1];
            order.TotalValue = totalValue;
            order.TotalWeight = totalWegit;

            order.Consignments = arrConsignment;

        }
    }
}
