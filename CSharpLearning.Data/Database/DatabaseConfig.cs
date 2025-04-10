using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;

namespace CSharpLearning.Data.Database
{
    public static class DatabaseConfig
    {
        public static string GetDbPath()
        {
            var folder = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "CSharpLearning"
            );

            // Ensure folder exists!
            Directory.CreateDirectory(folder);

            return Path.Combine(folder, "CSharplearning.db");
        }

    }
}
