using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjectChat
{
    public partial class Form1 : Form
    {
        private ChatMediator chatMediator;
        private Dictionary<string, Participant> participants;
        public static Form1 Instance { get; private set; }

        public Form1()
        {
            InitializeComponent();
            Instance = this;

            chatMediator = new ChatMediator();
            participants = new Dictionary<string, Participant>();

            participants["Заказчик"] = new Customer("Иван", chatMediator);
            participants["Программист"] = new Developer("Алексей", chatMediator);
            participants["Тестировщик"] = new Tester("Мария", chatMediator);

            cmbRole.Items.AddRange(new string[] { "Заказчик", "Программист", "Тестировщик" });
            cmbRole.SelectedIndex = 0;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string role = cmbRole.SelectedItem.ToString();
            string message = txtMessage.Text.Trim();

            if (string.IsNullOrWhiteSpace(message))
            {
                MessageBox.Show("Введите сообщение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (participants.ContainsKey(role))
            {
                participants[role].SendMessage(message);
                UpdateChat($"[Вы] {role}: {message}");
            }

            txtMessage.Clear();
        }

        public void UpdateChat(string message)
        {
            txtChat.AppendText(message + Environment.NewLine);
        }
    }
}
