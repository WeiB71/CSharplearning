using CSharpLearning.Data.Database;
using CSharpLearning.Data.Models;
using CSharpLearning.Data.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharplearning
{
    public partial class EditBookForm : Form
    {
        private readonly BookInlineCrudService _crudService;
        private readonly Book _book;
        public EditBookForm(Book book)
        {
            InitializeComponent();
            _book = book;

            var dbPath = DatabaseConfig.GetDbPath();
            _crudService = new BookInlineCrudService(dbPath);
        }
        private void EditBookForm_Load(object sender, EventArgs e)
        {
            txtTitle.Text = _book.Title;
            txtDescription.Text = _book.Description;
            txtAuthor.Text = _book.Author;
            dtpDatepublished.Text = _book.DatePublished;

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            _book.Title = txtTitle.Text.Trim();
            _book.Description = txtDescription.Text.Trim();
            _book.Author = txtAuthor.Text.Trim();
            _book.DatePublished = dtpDatepublished.Text.Trim();

            var success = await _crudService.UpdateBookAsync(_book);
            MessageBox.Show(success ? "✅ Book updated!" : "❌ Update failed.");
            if (success)
            {
                this.Close(); // triggers refresh in ViewBooksForm
            }
        }

        private void EditBookForm_Load_1(object sender, EventArgs e)
        {
            txtTitle.Text = _book.Title;
            txtDescription.Text = _book.Description;
            txtAuthor.Text = _book.Author;

            // Safely convert string to DateTime for the DatePublished DateTimePicker
            if (DateTime.TryParse(_book.DatePublished, out var parsed))
                dtpDatepublished.Value = parsed;
            else
                dtpDatepublished.Value = DateTime.Now;

          
        }
    }
}
