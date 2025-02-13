using System;
using System.Windows.Forms;

namespace SupportSystem
{
    public partial class Form1 : Form
    {
        private SupportHandler supportChain;

        public Form1()
        {
            InitializeComponent();

            var basic = new BasicSupport();
            var advanced = new AdvancedSupport();
            var manager = new ManagerSupport();

            basic.SetNextHandler(advanced);
            advanced.SetNextHandler(manager);

            supportChain = basic;
        }

        private void btnAsk_Click(object sender, EventArgs e)
        {
            string userQuestion = txtQuestion.Text;
            if (!string.IsNullOrWhiteSpace(userQuestion))
            {
                supportChain.HandleRequest(userQuestion);
            }
            else
            {
                MessageBox.Show("Введіть ваше запитання.");
            }
        }
    }
}
