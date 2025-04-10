using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.Data.Sql
{
    public static class UserInlineSql
    {
        public const string GetAll = "SELECT * FROM Users";
        public const string Insert = @"
            INSERT INTO Users (Username, Email, Role, CreatedAt)
            VALUES (@Username, @Email, @Role, @CreatedAt);";

        public const string Update = @"
            UPDATE Users SET
                Username = @Username,
                Email = @Email,
                Role = @Role,
                CreatedAt = @CreatedAt
            WHERE Id = @Id;";

        public const string Delete = "DELETE FROM Users WHERE Id = @Id;";
    }
}
