using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FileService;

namespace FileConventorApp
{
    public class FileProcessor
    {
        ConvertCSVToXMLFile _fileService = new ConvertCSVToXMLFile();

        public FileProcessor()
        {

        }

        static void Main(string[] args)
        {
            FileProcessor _fileProcessor = new FileProcessor();
            _fileProcessor.ProcessFile();
        }

        public void ProcessFile()
        {                        
            string sourceDirectory = @"C:\Assignment\Data\IN\";
            string destDirectory = @"C:\Assignment\Data\OUT\";

            
            if (!Directory.Exists(destDirectory))
                Directory.CreateDirectory(destDirectory);

            DirectoryInfo sourceDirInfo = new DirectoryInfo(sourceDirectory);
           
            foreach (FileInfo sourceFileInfo in sourceDirInfo.GetFiles())
            {
                string fileName = sourceFileInfo.Name;
                string csvFilePath = Path.Combine(sourceDirectory, fileName);
                string destFile = Path.Combine(destDirectory, fileName);
                string xmlFileName = Path.ChangeExtension(destFile, ".xml");

                //Process File
                _fileService.ConvertFileCSVToXML(csvFilePath, xmlFileName);

                if (File.Exists(destFile))
                    File.Delete(destFile);

                //Finally move the file    
                File.Move(sourceFileInfo.FullName, destFile);
            }

        }

       

    }
}
