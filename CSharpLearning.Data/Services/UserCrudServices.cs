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
            _connStr = DatabaseConfig.GetSqlServerConnectionString();
        }

        public async Task<List<User>> GetAllAsync()
        {
            var list = new List<User>();

            using var conn = new SqlConnection(_connStr);
            await conn.OpenAsync();

            using var cmd = new SqlCommand(UserInlineSql.GetAll, conn);
            using var reader = await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                list.Add(new User
                {
                    Id = reader.GetInt32(0),
                    Username = reader.GetString(1),
                    Email = reader.GetString(2),
                    Role = reader.GetString(3),
                    CreatedAt = reader.GetString(4)
                });
            }

            return list;
        }

        // You can add AddUserAsync, UpdateUserAsync, DeleteUserAsync here as well if needed.
    }
}
