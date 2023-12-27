using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PMRU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Persistence.Configurations
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(d => d.Id);
            builder.Property(d => d.DepartmentDescription).HasMaxLength(255).IsRequired();

            builder.HasData(
                new Department { Id = 1, DepartmentDescription = "Güvenlik" },
                new Department { Id = 2, DepartmentDescription = "Üretim" },
                new Department { Id = 3, DepartmentDescription = "Finans" },
                new Department { Id = 4, DepartmentDescription = "İnsan Kaynakları" },
                new Department { Id = 5, DepartmentDescription = "Satış Pazarlama" },
                new Department { Id = 6, DepartmentDescription = "IT" },
                new Department { Id = 7, DepartmentDescription = "Sağlık" }
                
            );
        }
    }
}
