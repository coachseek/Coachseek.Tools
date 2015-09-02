using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coachseek.Tools.CSVImporter.Model;

namespace Coachseek.Tools.CSVImporter.Abstract
{
    public interface ICsvReader
    {    
        Char Seperator { get; }
        string FilePath { get; }
        bool SkipTheFirstColumn { get; }
        List<CsvRow> ReadCsvRows();
        IEnumerable<CsvRow> GetRowsIterator();
        CsvRow CovertRowToList(string[] row);
    }
}
