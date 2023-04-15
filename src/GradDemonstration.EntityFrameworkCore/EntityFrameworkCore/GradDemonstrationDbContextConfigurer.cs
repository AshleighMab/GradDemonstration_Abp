using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace GradDemonstration.EntityFrameworkCore
{
    public static class GradDemonstrationDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<GradDemonstrationDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<GradDemonstrationDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
