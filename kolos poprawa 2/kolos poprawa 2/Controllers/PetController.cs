using kolos_poprawa_2.DTOs.Requests;
using kolos_poprawa_2.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolos_poprawa_2.Controllers
{
    
        [Route("api/teams")]
        [ApiController]
        public class PetController : ControllerBase
        {
            private readonly IPetDbService _dbService;

        public PetController(IPetDbService dbService)
            {
                _dbService = dbService;
            }

            [HttpGet("pets")]
            public async Task<IActionResult> GetPets(int id)
            {
                
                    var response = await _dbService.GetPets(id);
                    return Ok(response);
            }

        [HttpPost("pets")]
        public async Task<IActionResult> AddPet(AddPetRequest request) 
        {
            await _dbService.addPet(request);
            return Ok();
        }
        }
    }

