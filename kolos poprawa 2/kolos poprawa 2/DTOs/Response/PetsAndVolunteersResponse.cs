using kolos_poprawa_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolos_poprawa_2.DTOs.Response
{
    public class PetsAndVolunteersResponse
    {
        public Pet Pet { get; set; }

        public IEnumerable<Volunteer> volunteers { get; set; }
    }
}
