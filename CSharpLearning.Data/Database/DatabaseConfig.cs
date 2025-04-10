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
        public static string GetSqlConnectionString()
        {
            return "Server=sql1002.site4now.net;Database=db_ab2a0d_insentrydb;User Id=db_ab2a0d_insentrydb_admin;Password=1524Smarter.;TrustServerCertificate=True;";
        }
    }
}
