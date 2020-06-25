using kolos_poprawa_2.DTOs.Requests;
using kolos_poprawa_2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolos_poprawa_2.Services
{
    public class SqlServerPetDbService : IPetDbService
    {

        private readonly PetDbContext _context;

        public SqlServerPetDbService(PetDbContext context)
        {
            _context = context;
        }
        public async Task addPet(AddPetRequest request)
        {

            var BreedType = await _context.BreedTypes
                    .SingleOrDefaultAsync(p => p.Name == request.BreedName);
            if (BreedType == null)await  _context.BreedTypes.AddAsync(new BreedType
            {
                Name = request.BreedName
            });

            BreedType = await _context.BreedTypes
                    .SingleOrDefaultAsync(p => p.Name == request.BreedName);
            var pet = new Pet()
            {
                Name = request.Name,
                IsMale = request.isMale,
                DateRegistered = request.DateRegistered,
                ApprocimateDateOfBirth = request.ApprocimateDateOfBirth,
                IdBreedType = BreedType.IdBreedType

            };

            await _context.Pets.AddAsync(pet);
        }

        public async Task<Pet> GetPets(int year)
        {
            var pets = await _context.Pets
                .SingleOrDefaultAsync(p => p.DateRegistered.Year == year);

            return pets;
            
        }
    }
}
