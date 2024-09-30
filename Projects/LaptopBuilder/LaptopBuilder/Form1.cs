namespace LaptopBuilder
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ILaptopBuilder builder;

            if (comboBoxLaptopType.SelectedItem.ToString() == "Gaming")
            {
                builder = new GamingLaptopBuilder();
            }
            else
            {
                builder = new BusinessLaptopBuilder();
            }

            Director director = new Director(builder);

            director.BuildLaptop();

            Laptop laptop = builder.GetLaptop();

            txtLaptopConfig.Text = laptop.ToString();
        }

        private void txtLaptopConfig_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
