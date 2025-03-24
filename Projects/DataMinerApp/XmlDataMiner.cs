using System;
using System.Xml.Linq;
using System.Windows.Forms;

namespace DataMinerApp
{
    public class XmlDataMiner : DataMiner
    {
        private XDocument parsedData;

        protected override void ProcessData(string data)
        {
            parsedData = XDocument.Parse(data);
        }

        protected override void DisplayData()
        {
            MessageBox.Show(parsedData.ToString(), "XML Parser");
        }
    }
}
