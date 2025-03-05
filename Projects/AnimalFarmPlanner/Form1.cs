using System;
using System.Windows.Forms;

namespace AnimalFarmPlanner
{
    public partial class Form1 : Form
    {
        private Farm farm;

        public Form1()
        {
            InitializeComponent();
            farm = new Farm();
            FillComboBox();
        }

        private void FillComboBox()
        {
            cmbAnimals.Items.Add("Кури");
            cmbAnimals.Items.Add("Свині");
            cmbAnimals.Items.Add("Корови");
            cmbAnimals.SelectedIndex = 0;
        }

        private void btnPlan_Click(object sender, EventArgs e)
        {
            string selectedAnimal = cmbAnimals.SelectedItem.ToString();

            switch (selectedAnimal)
            {
                case "Кури":
                    farm.SetStrategy(new ChickenStrategy());
                    break;
                case "Свині":
                    farm.SetStrategy(new PigStrategy());
                    break;
                case "Корови":
                    farm.SetStrategy(new CowStrategy());
                    break;
                default:
                    MessageBox.Show("Помилка вибору!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            txtPlan.Text = farm.GeneratePlan();
        }

        private void cmbAnimals_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPlan_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
