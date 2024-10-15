namespace FlyweightGarland
{
    public partial class Form1 : Form
    {
        // ���� ��� ������ � ������� ��������
        private GarlandDisplay garlandDisplay;
        private LightFactory lightFactory;

        public Form1()
        {
            InitializeComponent();
            lightFactory = new LightFactory(); // ������������� �������
            InitializeGarlandDisplay();        // ������������� ������
            InitializeButtons();               // ������������� ������
        }

        // ����� ��� ������������� ������
        private void InitializeGarlandDisplay()
        {
            garlandDisplay = new GarlandDisplay
            {
                Dock = DockStyle.Fill
            };
            Controls.Add(garlandDisplay);
        }

        // ����� ��� ���������� ������ �� �����
        private void InitializeButtons()
        {
            var buttonPanel = new Panel { Dock = DockStyle.Bottom, Height = 50 };
            Controls.Add(buttonPanel);

            // ������ ��� ���������� ������� ��������
            var btnRed = new Button { Text = "�������� �������", Width = 150 };
            btnRed.Click += AddRedLight_Click;
            buttonPanel.Controls.Add(btnRed);

            // ������ ��� ���������� ������� ��������
            var btnGreen = new Button { Text = "�������� �������", Width = 150, Left = 160 };
            btnGreen.Click += AddGreenLight_Click;
            buttonPanel.Controls.Add(btnGreen);

            // ������ ��� ���������� ����� ��������
            var btnBlue = new Button { Text = "�������� �����", Width = 150, Left = 320 };
            btnBlue.Click += AddBlueLight_Click;
            buttonPanel.Controls.Add(btnBlue);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddRedLight_Click(object sender, EventArgs e)
        {
            var light = lightFactory.GetLight(Color.Red);
            garlandDisplay.AddLight(light, GetRandomX(), GetRandomY());
        }

        private void AddGreenLight_Click(object sender, EventArgs e)
        {
            var light = lightFactory.GetLight(Color.Green);
            garlandDisplay.AddLight(light, GetRandomX(), GetRandomY());
        }

        private void AddBlueLight_Click(object sender, EventArgs e)
        {
            var light = lightFactory.GetLight(Color.Blue);
            garlandDisplay.AddLight(light, GetRandomX(), GetRandomY());
        }

        // ��������� ��������� ��������� ��� ��������
        private int GetRandomX() => new Random().Next(Width - 20);
        private int GetRandomY() => new Random().Next(Height - 20);
    }
}
