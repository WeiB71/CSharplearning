using CSharpLearning.Data.Models;
using CSharpLearning.Data.Sql;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharpLearning.Data.Services
{
    /// <summary>
    /// Provides direct CRUD operations using inline SQL for the Books table.
    /// Suitable for teaching SQL flow or lightweight apps without full abstraction layers.
    /// </summary>
    public class BookInlineCrudService
    {
        private readonly string _dbPath;

        public BookInlineCrudService(string dbPath)
        {
            _dbPath = dbPath;
        }

        public async Task<bool> AddBookAsync(Book book)
        {
            using var conn = new SqliteConnection($"Data Source={_dbPath}");
            await conn.OpenAsync();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = BookInlineSql.Create;

            cmd.Parameters.AddWithValue("$id", book.Id);
            cmd.Parameters.AddWithValue("$title", book.Title);
            cmd.Parameters.AddWithValue("$desc", book.Description);
            cmd.Parameters.AddWithValue("$author", book.Author);
            cmd.Parameters.AddWithValue("$published", book.DatePublished);
            cmd.Parameters.AddWithValue("$created", book.DateCreated);

            return await cmd.ExecuteNonQueryAsync() > 0;
        }

        public async Task<List<Book>> GetAllBooksAsync()
        {
            var books = new List<Book>();

            using var conn = new SqliteConnection($"Data Source={_dbPath}");
            await conn.OpenAsync();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = BookInlineSql.ReadAll;

            using var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                books.Add(new Book
                {
                    Id = reader.GetInt32(0),
                    Title = reader.GetString(1),
                    Description = reader.GetString(2),
                    Author = reader.GetString(3),
                    DatePublished = reader.GetString(4),
                    DateCreated = reader.GetString(5)
                });
            }

            return books;
        }

        public async Task<Book?> GetBookByIdAsync(int id)
        {
            using var conn = new SqliteConnection($"Data Source={_dbPath}");
            await conn.OpenAsync();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = BookInlineSql.ReadById;
            cmd.Parameters.AddWithValue("$id", id);

            using var reader = await cmd.ExecuteReaderAsync();
            if (await reader.ReadAsync())
            {
                return new Book
                {
                    Id = reader.GetInt32(0),
                    Title = reader.GetString(1),
                    Description = reader.GetString(2),
                    Author = reader.GetString(3),
                    DatePublished = reader.GetString(4),
                    DateCreated = reader.GetString(5)
                };
            }

            return null;
        }

        public async Task<bool> UpdateBookAsync(Book book)
        {
            using var conn = new SqliteConnection($"Data Source={_dbPath}");
            await conn.OpenAsync();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = BookInlineSql.Update;

            cmd.Parameters.AddWithValue("$id", book.Id);
            cmd.Parameters.AddWithValue("$title", book.Title);
            cmd.Parameters.AddWithValue("$desc", book.Description);
            cmd.Parameters.AddWithValue("$author", book.Author);
            cmd.Parameters.AddWithValue("$published", book.DatePublished);
            cmd.Parameters.AddWithValue("$created", book.DateCreated);

            return await cmd.ExecuteNonQueryAsync() > 0;
        }

        public async Task<bool> DeleteBookAsync(int id)
        {
            using var conn = new SqliteConnection($"Data Source={_dbPath}");
            await conn.OpenAsync();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = BookInlineSql.Delete;
            cmd.Parameters.AddWithValue("$id", id);

            return await cmd.ExecuteNonQueryAsync() > 0;
        }
    }
}
