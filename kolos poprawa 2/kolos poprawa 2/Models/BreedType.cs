﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolos_poprawa_2.Models
{
    public class BreedType
    {
        public int idBreedType { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public IEnumerable<Pet> Pets { get; set; }
    }
}
