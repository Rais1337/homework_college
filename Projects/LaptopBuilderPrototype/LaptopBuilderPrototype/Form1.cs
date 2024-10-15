namespace LaptopBuilderPrototype
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Laptop currentLaptop;

        private void btnBuildLaptop_Click(object sender, EventArgs e)
        {
            ILaptopBuilder builder;

            if (comboBoxLaptopType.SelectedItem?.ToString() == "Gaming")
            {
                builder = new GamingLaptopBuilder();
            }
            else
            {
                builder = new BusinessLaptopBuilder();
            }

            Director director = new Director(builder);
            director.BuildLaptop();

            currentLaptop = builder.GetLaptop();
            txtLaptopConfig.Text = currentLaptop.ToString();
        }

        private void btnCloneLaptop_Click(object sender, EventArgs e)
        {
            if (currentLaptop != null)
            {
                Laptop clonedLaptop = (Laptop)currentLaptop.Clone();
                txtLaptopConfig.Text = $"Cloned: {clonedLaptop.ToString()}";
            }
            else
            {
                MessageBox.Show("No laptop to clone. Build a laptop first.");
            }
        }

    }
}
