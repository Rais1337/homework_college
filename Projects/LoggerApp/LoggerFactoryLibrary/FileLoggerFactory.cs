using LoggerFactoryLibrary.LoggerFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerFactoryLibrary
{
    public class FileLoggerFactory : LoggerFactory
    {
        private string _filePath;

        public FileLoggerFactory(string filePath)
        {
            _filePath = filePath;
        }

        public override ILogger CreateLogger()
        {
            return new FileLogger(_filePath);
        }
    }
}