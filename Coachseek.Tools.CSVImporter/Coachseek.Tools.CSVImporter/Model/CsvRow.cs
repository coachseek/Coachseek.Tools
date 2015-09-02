using System.Collections.Generic;
using System.Security.AccessControl;

namespace Coachseek.Tools.CSVImporter.Model
{
    public class CsvRow
    {
        public CsvRow(string[] row)
        {
            Data = new List<string>(row);
        }

        public CsvRow()
        {
            Data = new List<string>();
        }

        public List<string> Data { get; private set; }
    }
}