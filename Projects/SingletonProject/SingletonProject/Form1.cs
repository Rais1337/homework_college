using SingletonLibrary;

namespace SingletonProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DbManager.Instance.ConnectToDatabase();
            DocumentSaver.Instance.SaveDocument("example.docx");
            Logger.Instance.Log("Программа запущена");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Logger.Instance.Log("Документ сохранен");
        }
    }
}
