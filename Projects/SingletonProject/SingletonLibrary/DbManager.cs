using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonLibrary
{
    public class DbManager
    {
        private static DbManager _instance;
        private static readonly object _lock = new object();

        private DbManager() { }

        public static DbManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new DbManager();
                        }
                    }
                }
                return _instance;
            }
        }

        public void ConnectToDatabase()
        {
            Console.WriteLine("Подключено к базе данных.");
        }
    }
}

