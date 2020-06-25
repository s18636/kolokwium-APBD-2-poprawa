using kolos_poprawa_2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolos_poprawa_2.Configurations
{
    public class EfVolunteerConfig : IEntityTypeConfiguration<Volunteer>
    {
        public void Configure(EntityTypeBuilder<Volunteer> builder)
        {
            builder.HasKey(n => n.IdVolunteer);
            builder.Property(n => n.IdVolunteer).ValueGeneratedOnAdd();

            builder.HasOne(n => n.Supervisor)
                .WithMany(n => n.Volunteers)
                .HasForeignKey(n => n.IdSupervisor);

        }
    }
}
