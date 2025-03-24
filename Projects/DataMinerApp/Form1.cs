using System;
using System.Windows.Forms;

namespace DataMinerApp
{
    public partial class Form1 : Form
    {
        private DataMiner dataMiner;

        public Form1()
        {
            InitializeComponent();
            cbFormat.Items.AddRange(new string[] { "CSV", "JSON", "XML" });
            cbFormat.SelectedIndex = 0;
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Files|*.*|CSV Files|*.csv|JSON Files|*.json|XML Files|*.xml";
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string selectedFormat = cbFormat.SelectedItem.ToString();

                switch (selectedFormat)
                {
                    case "CSV":
                        dataMiner = new CsvDataMiner();
                        break;
                    case "JSON":
                        dataMiner = new JsonDataMiner();
                        break;
                    case "XML":
                        dataMiner = new XmlDataMiner();
                        break;
                }

                dataMiner.ParseFile(filePath);
            }
        }
    }
}
