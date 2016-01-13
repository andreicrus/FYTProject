using FYT.Models;
using System.Data.Entity.ModelConfiguration;

namespace FYT.DAL.Configuration
{
    public class ProjectInfoConfiguration : EntityTypeConfiguration<ProjectInfo>
    {
        public ProjectInfoConfiguration()
        {
            this.Property(p => p.AssemblyTitle)
                .IsRequired().HasMaxLength(100);

            this.Property(p => p.AssemblyDescription)
                .IsOptional().HasMaxLength(100);

            this.Property(p => p.AssemblyVersion)
                .IsOptional().HasMaxLength(100);

            this.Property(p => p.Company)
                .IsOptional().HasMaxLength(100);

            this.Property(p => p.Guid)
                .IsOptional().HasMaxLength(100);

            this.Property(p => p.Product)
                .IsOptional().HasMaxLength(100);

            this.Property(p => p.CreatedOn)
                .IsRequired().HasColumnType("datetime");

            this.Property(p => p.ModifiedOn)
                .IsRequired().HasColumnType("datetime");
        }
    }
}
