using AnimalFactoryLibrary;

namespace AnimalFactory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void factoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void createAnimalsButton_Click(object sender, EventArgs e)
        {
            if (factoryComboBox.SelectedItem == null)
            {
                MessageBox.Show("������� ����������!");
                return;
            }

            string selectedFactory = factoryComboBox.SelectedItem.ToString();
            IAnimalFactory factory = null;

            switch (selectedFactory)
            {
                case "������":
                    factory = new SavannaAnimalFactory();
                    break;
                case "������":
                    factory = new JungleAnimalFactory();
                    break;
                case "�������":
                    factory = new DesertAnimalFactory();
                    break;
                default:
                    MessageBox.Show("������� ������� ����������!");
                    return;
            }

            mammalLabel.Text = factory.CreateMammal().Speak();
            birdLabel.Text = factory.CreateBird().Speak();
            reptileLabel.Text = factory.CreateReptile().Speak();
        }

    }
}
