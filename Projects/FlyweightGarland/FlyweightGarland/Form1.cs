namespace FlyweightGarland
{
    public partial class Form1 : Form
    {
        // Поля для панели и фабрики лампочек
        private GarlandDisplay garlandDisplay;
        private LightFactory lightFactory;

        public Form1()
        {
            InitializeComponent();
            lightFactory = new LightFactory(); // Инициализация фабрики
            InitializeGarlandDisplay();        // Инициализация панели
            InitializeButtons();               // Инициализация кнопок
        }

        // Метод для инициализации панели
        private void InitializeGarlandDisplay()
        {
            garlandDisplay = new GarlandDisplay
            {
                Dock = DockStyle.Fill
            };
            Controls.Add(garlandDisplay);
        }

        // Метод для добавления кнопок на форму
        private void InitializeButtons()
        {
            var buttonPanel = new Panel { Dock = DockStyle.Bottom, Height = 50 };
            Controls.Add(buttonPanel);

            // Кнопка для добавления красной лампочки
            var btnRed = new Button { Text = "Добавить красную", Width = 150 };
            btnRed.Click += AddRedLight_Click;
            buttonPanel.Controls.Add(btnRed);

            // Кнопка для добавления зеленой лампочки
            var btnGreen = new Button { Text = "Добавить зеленую", Width = 150, Left = 160 };
            btnGreen.Click += AddGreenLight_Click;
            buttonPanel.Controls.Add(btnGreen);

            // Кнопка для добавления синей лампочки
            var btnBlue = new Button { Text = "Добавить синюю", Width = 150, Left = 320 };
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

        // Генерация случайных координат для лампочек
        private int GetRandomX() => new Random().Next(Width - 20);
        private int GetRandomY() => new Random().Next(Height - 20);
    }
}
