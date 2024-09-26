using LoggerFactoryLibrary.LoggerFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoggerFactoryLibrary
{
    public class TextBoxLogger : ILogger
    {
        private TextBox _textBox;

        public TextBoxLogger(TextBox textBox)
        {
            _textBox = textBox;
        }

        public void Log(string message)
        {
            _textBox.AppendText($"{message}\n");
        }
    }
}

