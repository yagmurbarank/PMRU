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
            builder.HasKey(d => d.DepartmentID);
            builder.Property(d => d.DepartmentDescription).HasMaxLength(255).IsRequired();

            // Diğer konfigürasyonları ekleyebilirsiniz.

            // Örnek veri eklemek için:
            builder.HasData(
                new Department { DepartmentID = 1, DepartmentDescription = "Güvenlik" },
                new Department { DepartmentID = 2, DepartmentDescription = "Üretim" },
                new Department { DepartmentID = 3, DepartmentDescription = "Finans" },
                new Department { DepartmentID = 4, DepartmentDescription = "İnsan Kaynakları" },
                new Department { DepartmentID = 5, DepartmentDescription = "Satış Pazarlama" },
                new Department { DepartmentID = 6, DepartmentDescription = "IT" },
                new Department { DepartmentID = 7, DepartmentDescription = "Sağlık" }
                
            );
        }
    }
}
