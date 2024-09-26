using LoggerFactoryLibrary.LoggerFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerFactoryLibrary
{
    public abstract class LoggerFactory
    {
        public abstract ILogger CreateLogger();
    }
}

