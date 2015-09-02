using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coachseek.Tools.CSVImporter.Model;

namespace Coachseek.Tools.CSVImporter
{
    class Program
    {
        static void Main(string[] args)
        {
            //add a temperary pathd
            var tempFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var tempPath = string.Format(@"{0}{1}scott@slicetennis.com.csv", tempFolder, Path.DirectorySeparatorChar);

            var csvReader = new CsvReader(tempPath,false,',');
            var result = csvReader.ReadCsvRows();
            foreach (var items in result)
            {
                foreach (var item in items.Data)
                {                   
                    Console.WriteLine(item);
                }
            }
            Console.ReadLine();
        }
    }
}
