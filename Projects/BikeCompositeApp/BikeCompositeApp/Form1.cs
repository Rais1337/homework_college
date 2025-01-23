namespace BikeCompositeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var bike = new CompositeBikePart("Велосипед");

            var frame = new BikePart("Рама");
            var wheelFront = new BikePart("Переднее колесо");
            var wheelBack = new BikePart("Заднее колесо");
            var seat = new BikePart("Сиденье");
            var handlebar = new BikePart("Руль");

            bike.Add(frame);
            bike.Add(wheelFront);
            bike.Add(wheelBack);
            bike.Add(seat);
            bike.Add(handlebar);

            var transmission = new CompositeBikePart("Трансмиссия");
            var chain = new BikePart("Цепь");
            var gear = new BikePart("Шестерни");

            transmission.Add(chain);
            transmission.Add(gear);

            bike.Add(transmission);

            txtBikeDetails.Text = bike.GetStructure(0);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
