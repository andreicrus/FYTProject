using FYT.DAL.Configuration;
using FYT.Models;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace FYT.DAL
{
    public class DataContext : DbContext
    {
        public DbSet<ProjectInfo> ProjectInfo { get; set; }

        public static string ConnectionStringName
        {
            get
            {
                if (ConfigurationManager.AppSettings["ConnectionString"]
                    != null)
                {
                    return ConfigurationManager.
                        AppSettings["ConnectionString"].ToString();
                }

                return "DefaultConnection";
            }
        }

        static DataContext()
        {
            Database.SetInitializer(new CustomDatabaseInitializer());
        }

        public DataContext()
            : base(nameOrConnectionString: ConnectionStringName)
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProjectInfoConfiguration());
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            // Add ASP.NET WebPages SimpleSecurity tables

            base.OnModelCreating(modelBuilder);
        }

        private void ApplyRules()
        {}

        public override int SaveChanges()
        {
            ApplyRules();

            return base.SaveChanges();
        }
    }
}