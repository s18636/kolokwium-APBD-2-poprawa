using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolos_poprawa_2.DTOs.Requests
{
    public class AddPetRequest
    {
        public string BreedName { get; set; }

        public string Name { get; set; }

        public bool isMale { get; set; }

        public DateTime DateRegistered { get; set; }

        public DateTime ApprocimateDateOfBirth { get; set; }
    }
}
