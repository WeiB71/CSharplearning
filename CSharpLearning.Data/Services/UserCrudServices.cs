using CSharpLearning.Data.Database;
using CSharpLearning.Data.Models;
using CSharpLearning.Data.Sql;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.Data.Services
{
    public class UserCrudService
    {
        private readonly string _connStr;

        public UserCrudService()
        {
            _connStr = DatabaseConfig.GetSqlConnectionString();
        }

        public async Task<List<User>> GetAllAsync()
        {
            var users = new List<User>();

            using var conn = new SqlConnection(_connStr);
            await conn.OpenAsync();

            using var cmd = new SqlCommand("SELECT * FROM Users", conn);
            using var reader = await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                users.Add(new User
                {
                    Id = reader.GetGuid(0),
                    Username = reader.GetString(1),
                    Email = reader.GetString(2),
                    Role = reader.GetString(3),
                    CreatedAt = reader.GetString(4)
                });
            }

            return users;
        }
        public async Task<bool> AddAsync(User user)
        {
            using var conn = new SqlConnection(_connStr);
            await conn.OpenAsync();

            using var cmd = new SqlCommand(UserInlineSql.Insert, conn);
            cmd.Parameters.AddWithValue("@Id", user.Id);
            cmd.Parameters.AddWithValue("@Username", user.Username);
            cmd.Parameters.AddWithValue("@Email", user.Email);
            cmd.Parameters.AddWithValue("@Role", user.Role);
            cmd.Parameters.AddWithValue("@CreatedAt", user.CreatedAt);

            var result = await cmd.ExecuteNonQueryAsync();
            return result > 0;
        }

        public async Task<bool> UpdateAsync(User user)
        {
            using var conn = new SqlConnection(_connStr);
            await conn.OpenAsync();

            using var cmd = new SqlCommand(UserInlineSql.Update, conn);
            cmd.Parameters.AddWithValue("@Id", user.Id);
            cmd.Parameters.AddWithValue("@Username", user.Username);
            cmd.Parameters.AddWithValue("@Email", user.Email);
            cmd.Parameters.AddWithValue("@Role", user.Role);
            cmd.Parameters.AddWithValue("@CreatedAt", user.CreatedAt);

            var result = await cmd.ExecuteNonQueryAsync();
            return result > 0;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            using var conn = new SqlConnection(_connStr);
            await conn.OpenAsync();

            using var cmd = new SqlCommand(UserInlineSql.Delete, conn);
            cmd.Parameters.AddWithValue("@Id", id);

            var result = await cmd.ExecuteNonQueryAsync();
            return result > 0;
        }
    }
}
