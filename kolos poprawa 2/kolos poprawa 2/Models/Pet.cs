﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolos_poprawa_2.Models
{
    public class Pet
    {
        public int IdPet { get; set; }

        public int IdBreedType { get; set; }

        public string Name { get; set; }

        public bool IsMale { get; set; }

        public DateTime DateRegistered { get; set; }

        public DateTime ApprocimateDateOfBirth { get; set; }

        public DateTime DateAdopted { get; set; }

        public BreedType BreedType { get; set; }

        public IEnumerable<Volunteer_Pet> Volunteer_Pets { get; set; }

    }
}
