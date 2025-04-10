using CSharpLearning.Data.Database;
using CSharpLearning.Data.Models;
using CSharpLearning.Data.Services;

namespace CSharplearning
{


    public partial class AddBookForm : Form
    {
        private BookInlineCrudService _crudService;
        public AddBookForm()
        {
            InitializeComponent();
            var dbPath = DatabaseConfig.GetDbPath(); // centralized
            _crudService = new BookInlineCrudService(dbPath);
            dtpDatepublished.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {

        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var book = new Book
            {
                Id = new Random().Next(1000, 9999),
                Title = txtTitle.Text.Trim(),
                Description = txtDescription.Text.Trim(),
                Author = txtAuthor.Text.Trim(),
                DatePublished = dtpDatepublished.Text.Trim(),
                DateCreated = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            };

           
            var success = await _crudService.AddBookAsync(book);


            MessageBox.Show(success ? "✅ Book added!" : "❌ Failed to add book.");
        }
    }
}
