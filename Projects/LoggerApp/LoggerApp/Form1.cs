using System;
using System.Windows.Forms;
using LoggerApp.Factories;

namespace LoggerApp
{
    public partial class Form1 : Form
    {
        private LoggerFactory loggerFactory;
        private ILogger logger;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void buttonLogToTextBox_Click(object sender, EventArgs e)
        {
            loggerFactory = new TextBoxLoggerFactory(textBoxLog);
            logger = loggerFactory.CreateLogger();
            logger.Log("Логирование в TextBox выполнено.");
        }

        private void buttonLogToConsole_Click(object sender, EventArgs e)
        {
            loggerFactory = new ConsoleLoggerFactory();
            logger = loggerFactory.CreateLogger();
            logger.Log("Логирование в консоль выполнено.");
        }

        private void buttonLogToFile_Click(object sender, EventArgs e)
        {
            loggerFactory = new FileLoggerFactory("log.txt"); 
            logger = loggerFactory.CreateLogger();
            logger.Log("Логирование в файл выполнено.");
        }
    }
}
