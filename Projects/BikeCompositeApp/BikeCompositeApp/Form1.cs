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
            var bike = new CompositeBikePart("���������");

            var frame = new BikePart("����");
            var wheelFront = new BikePart("�������� ������");
            var wheelBack = new BikePart("������ ������");
            var seat = new BikePart("�������");
            var handlebar = new BikePart("����");

            bike.Add(frame);
            bike.Add(wheelFront);
            bike.Add(wheelBack);
            bike.Add(seat);
            bike.Add(handlebar);

            var transmission = new CompositeBikePart("�����������");
            var chain = new BikePart("����");
            var gear = new BikePart("��������");

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
