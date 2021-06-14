using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FileDataModel;
using FileProcessorRepo;
using System.Xml.Serialization;
using System.Xml.Linq;

namespace FileService
{
    public class ConvertCSVToXMLFile : IFileProcessor
    {
        public void ConvertFileCSVToXML(string fileName, string destFileName)
        {
            List<PurchageOrder> orderList = new List<PurchageOrder>();                     

            XmlSerializer serializer =
           new XmlSerializer(typeof(PurchageOrder));

            string[] OrderList = File.ReadAllLines(fileName);

            for (int i = 1; i < OrderList.Length; i++)
            {
                PurchageOrder orders = new PurchageOrder(OrderList[i]);
                orderList.Add(orders);
            }

            TextWriter writer = new StreamWriter(destFileName);            
            serializer.Serialize(writer, orderList);
            writer.Close();                     

        }
    }

}
    

