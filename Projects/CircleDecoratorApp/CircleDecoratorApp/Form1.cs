namespace CircleDecoratorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ICircle circle = new Circle(50);

            ICircle winFormsDecorator = new WinFormsCircleDecorator(circle, this);
            winFormsDecorator.Draw();
        }

    }
}
