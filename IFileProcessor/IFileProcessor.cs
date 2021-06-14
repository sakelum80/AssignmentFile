using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProcessorRepo
{
    public interface IFileProcessor
    {
        void ConvertFileCSVToXML(string fileName, string destFileName);
    }
}
