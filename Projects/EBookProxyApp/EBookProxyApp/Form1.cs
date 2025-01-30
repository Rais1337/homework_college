namespace EBookProxyApp
{
    public partial class Form1 : Form
    {
        private IBook book = new ProxyBook();
        private int currentPage = 0;

        public Form1()
        {
            InitializeComponent();
            LoadPage();
        }

        private void LoadPage()
        {
            txtPageContent.Text = book.GetPage(currentPage);
            UpdateButtons();
        }

        private void UpdateButtons()
        {
            btnPrevPage.Enabled = currentPage > 0;
            btnNextPage.Enabled = currentPage < book.GetTotalPages() - 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtPageContent_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage--;
                LoadPage();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(searchText)) return;

            string pageText = book.GetPage(currentPage);
            int index = pageText.IndexOf(searchText, StringComparison.OrdinalIgnoreCase);

            if (index >= 0)
            {
                txtPageContent.Text = HighlightText(pageText, searchText);
            }
            else
            {
                MessageBox.Show("Текст не найден!", "Результат поиска", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (currentPage < book.GetTotalPages() - 1)
            {
                currentPage++;
                LoadPage();
            }
        }

        private string HighlightText(string text, string searchText)
        {
            return text.Replace(searchText, $"[{searchText}]", StringComparison.OrdinalIgnoreCase);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
