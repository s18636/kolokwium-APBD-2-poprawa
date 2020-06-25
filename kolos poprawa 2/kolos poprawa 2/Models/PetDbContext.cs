using kolos_poprawa_2.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolos_poprawa_2.Models
{
    public class PetDbContext : DbContext
    {
        public DbSet<BreedType> BreedTypes { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Volunteer_Pet> Volunteer_Pets { get; set; }
        public DbSet<Volunteer> Volunteers { get; set; }

        public PetDbContext()
        {

        }

        public PetDbContext(DbContextOptions options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new EfBreedTypeConfig());
            modelBuilder.ApplyConfiguration(new EfPetConfig());
            modelBuilder.ApplyConfiguration(new EfVolunteerConfig());
            modelBuilder.ApplyConfiguration(new EfVolunterr_PetConfig());

        }

    }
}
