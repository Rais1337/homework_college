using System;
using System.IO;

namespace DataMinerApp
{
    public abstract class DataMiner
    {
        public void ParseFile(string filePath)
        {
            string data = ReadFile(filePath);
            ProcessData(data);
            DisplayData();
        }

        protected string ReadFile(string filePath)
        {
            return File.ReadAllText(filePath);
        }

        protected abstract void ProcessData(string data);
        protected abstract void DisplayData();
    }
}
