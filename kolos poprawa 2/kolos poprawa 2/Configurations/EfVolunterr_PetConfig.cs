using kolos_poprawa_2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolos_poprawa_2.Configurations
{
    public class EfVolunterr_PetConfig : IEntityTypeConfiguration<Volunteer_Pet>
    {
        public void Configure(EntityTypeBuilder<Volunteer_Pet> builder)
        {
            builder.HasKey(n => new { n.IdVolunteer, n.IdPet });

            builder.HasOne(n => n.Pet)
                .WithMany(n => n.Volunteer_Pets)
                .HasForeignKey(n => n.IdPet);

            builder.HasOne(n => n.Volunteer)
                .WithMany(n => n.Volunteer_Pets)
                .HasForeignKey(n => n.IdVolunteer);
        }
    }
}
