using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using CSharpLearning.Data.Sql;
using CSharpLearning.Data.Database;
using CSharpLearning.Data.Models;
using CSharpLearning.Data.Services;
// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Csharplearning.WinUI
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        private readonly BookInlineCrudService _crudService;
        private readonly string _dbPath = DatabaseConfig.GetDbPath();

        public MainWindow()
        {
            this.InitializeComponent();
            _crudService = new BookInlineCrudService(_dbPath);
            LoadBooks();
        }
        private async void LoadBooks()
        {
            BooksListView.ItemsSource = await _crudService.GetAllBooksAsync();
        }

        private async void AddBook_Click(object sender, RoutedEventArgs e)
        {
           
            var book = new Book
            {
                Id =  new Random().Next(1000, 9999),
                Title = TitleBox.Text,
                Author = AuthorBox.Text,
                DatePublished = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                DateCreated = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

            };

            await _crudService.AddBookAsync(book);
            LoadBooks();
            TitleBox.Text = AuthorBox.Text = string.Empty;
        }

    }
}
