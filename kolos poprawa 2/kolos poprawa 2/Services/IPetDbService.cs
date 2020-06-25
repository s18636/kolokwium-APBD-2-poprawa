using kolos_poprawa_2.DTOs.Requests;
using kolos_poprawa_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolos_poprawa_2.Services
{
    public interface IPetDbService
    {
        public Task<Pet> GetPets( int year);
        public Task addPet(AddPetRequest request);
    }
}
