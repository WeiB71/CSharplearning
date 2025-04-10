namespace CSharpLearning.Data.Sql
{
    /// <summary>
    /// Contains raw inline SQL queries for CRUD operations on the Books table.
    /// This keeps the logic out of the repository and helps demonstrate classic SQL control.
    /// </summary>
    public static class BookInlineSql
    {
        public const string Create = @"
            INSERT INTO Books (Id, Title, Description, Author, DatePublished, DateCreated)
            VALUES ($id, $title, $desc, $author, $published, $created);";

        public const string ReadAll = "SELECT * FROM Books;";
        public const string ReadById = "SELECT * FROM Books WHERE Id = $id;";
        public const string Update = @"
            UPDATE Books SET
                Title = $title,
                Description = $desc,
                Author = $author,
                DatePublished = $published,
                DateCreated = $created
            WHERE Id = $id;";

        public const string Delete = "DELETE FROM Books WHERE Id = $id;";
    }
}
