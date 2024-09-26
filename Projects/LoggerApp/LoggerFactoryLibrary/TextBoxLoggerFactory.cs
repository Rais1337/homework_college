using LoggerFactoryLibrary.LoggerFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerFactoryLibrary
{
    public class TextBoxLoggerFactory : LoggerFactory
    {
        private TextBox _textBox;

        public TextBoxLoggerFactory(TextBox textBox)
        {
            _textBox = textBox;
        }

        public override ILogger CreateLogger()
        {
            return new TextBoxLogger(_textBox);
        }
    }
}
