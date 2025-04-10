using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpLearning.Data.Models;
using CSharpLearning.Data.Services;
using CSharpLearning.Data.Database;
namespace CSharplearning
{
    public partial class ViewBookForm : Form
    {
        private readonly BookInlineCrudService _crudService;
        public ViewBookForm()
        {
            InitializeComponent();
            var dbPath = DatabaseConfig.GetDbPath();
            _crudService = new BookInlineCrudService(dbPath);
        }

        private async void ViewBookForm_Load(object sender, EventArgs e)
        {
            await LoadBooksAsync();
        }
        private async Task LoadBooksAsync()
        {
            var books = await _crudService.GetAllBooksAsync();
            dgvBooks.DataSource = books;
        }

        private Book? GetSelectedBook()
        {
            if (dgvBooks.CurrentRow?.DataBoundItem is Book book)
                return book;
            return null;
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadBooksAsync();
        }

        private async void btnDelete_Click_1(object sender, EventArgs e)
        {
            var selected = GetSelectedBook();
            if (selected == null)
            {
                MessageBox.Show("Select a book to delete.");
                return;
            }

            var confirm = MessageBox.Show(
                $"Are you sure you want to delete \"{selected.Title}\"?",
                "Confirm Delete", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                var result = await _crudService.DeleteBookAsync(selected.Id);
                MessageBox.Show(result ? "Deleted." : "Delete failed.");
                await LoadBooksAsync();
            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            var selected = GetSelectedBook();
            if (selected == null)
            {
                MessageBox.Show("Please select a book to edit.");
                return;
            }

            var editForm = new EditBookForm(selected);
            editForm.FormClosed += async (_, _) => await LoadBooksAsync();
            editForm.ShowDialog();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            var addForm = new AddBookForm();
            addForm.FormClosed += async (_, _) => await LoadBooksAsync();
            addForm.ShowDialog();
        }
    }
}
