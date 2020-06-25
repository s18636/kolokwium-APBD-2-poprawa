using kolos_poprawa_2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolos_poprawa_2.Configurations
{
    public class EfPetConfig : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder.HasKey(n => n.IdPet);
            builder.Property(n => n.IdPet).ValueGeneratedOnAdd();

            builder.HasOne(n => n.BreedType)
                .WithMany(n => n.Pets)
                .HasForeignKey(n => n.IdBreedType);
        }
    }
}
