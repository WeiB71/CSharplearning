using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.Data.Models
{
    public class Book
    {
        public int Id { get; set; }  // Primary key
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string DatePublished { get; set; } = string.Empty;
        public string DateCreated { get; set; } = string.Empty;
    }
}
