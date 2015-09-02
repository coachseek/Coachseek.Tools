using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Coachseek.Tools.CSVImporter.Abstract;
using Coachseek.Tools.CSVImporter.Model;

namespace Coachseek.Tools.CSVImporter
{
    public class CsvReader : ICsvReader
    {
        public CsvReader(string filePath, bool skipTheFirstColumn, char seperator)
        {
            SkipTheFirstColumn = skipTheFirstColumn;
            Seperator = seperator;
            FilePath = filePath;
        }

        public List<Model.CsvRow> ReadCsvRows()
        {
            return SkipTheFirstColumn ? GetRowsIterator().Skip(1).ToList() : GetRowsIterator().ToList();
        }

        public IEnumerable<Model.CsvRow> GetRowsIterator()
        {
            using (var readFile = new StreamReader(FilePath))
            {
                string line;
                while ((line = readFile.ReadLine()) != null)
                {
                    var row = line.Split(Seperator);
                    var list = CovertRowToList(row);
                    yield return list;
                }
            }
        }

        public CsvRow CovertRowToList(string[] row)
        {       
            return new CsvRow(row); ;
        }

        public char Seperator { get; private set; }

        public bool SkipTheFirstColumn { get; private set; }

        public string FilePath { get; private set; }
    }
}
    