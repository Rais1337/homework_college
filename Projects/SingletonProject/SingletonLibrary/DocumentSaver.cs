using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonLibrary
{
    public class DocumentSaver
    {
        private static DocumentSaver _instance;
        private static readonly object _lock = new object();

        private DocumentSaver() { }

        public static DocumentSaver Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new DocumentSaver();
                        }
                    }
                }
                return _instance;
            }
        }

        public void SaveDocument(string documentPath)
        {
            Console.WriteLine($"Документ сохранен: {documentPath}");
        }
    }
}

