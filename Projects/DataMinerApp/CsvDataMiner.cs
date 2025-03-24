using System;
using System.Linq;
using System.Windows.Forms;

namespace DataMinerApp
{
    public class CsvDataMiner : DataMiner
    {
        private string[] parsedData;

        protected override void ProcessData(string data)
        {
            parsedData = data.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries)
                             .Select(line => line.Replace(",", " | "))
                             .ToArray();
        }

        protected override void DisplayData()
        {
            MessageBox.Show(string.Join("\n", parsedData), "CSV Parser");
        }
    }
}
