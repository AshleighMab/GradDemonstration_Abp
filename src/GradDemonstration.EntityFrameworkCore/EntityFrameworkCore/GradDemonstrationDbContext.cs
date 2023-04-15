using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using GradDemonstration.Authorization.Roles;
using GradDemonstration.Authorization.Users;
using GradDemonstration.MultiTenancy;
using GradDemonstration.Domain;

namespace GradDemonstration.EntityFrameworkCore
{
    public class GradDemonstrationDbContext : AbpZeroDbContext<Tenant, Role, User, GradDemonstrationDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Person> Persons { get; set; }
        public DbSet<Product> Products { get; set; }
        public GradDemonstrationDbContext(DbContextOptions<GradDemonstrationDbContext> options)
            : base(options)
        {
        }
    }
}
