using kolos_poprawa_2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolos_poprawa_2.Configurations
{
    public class EfBreedTypeConfig : IEntityTypeConfiguration<BreedType>
    {
        public void Configure(EntityTypeBuilder<BreedType> builder)
        {
            builder.HasKey(n => n.IdBreedType);
            builder.Property(n => n.IdBreedType).ValueGeneratedOnAdd();
        }
    }
}
