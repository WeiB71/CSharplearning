using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.Data.Models
{
    namespace CSharpLearning.Data.Models
    {
        public class User
        {
            public int Id { get; set; }           // Primary Key
            public string Username { get; set; } = string.Empty;
            public string Email { get; set; } = string.Empty;
            public string Role { get; set; } = string.Empty;
            public string CreatedAt { get; set; } = string.Empty;
        }
    }

}
