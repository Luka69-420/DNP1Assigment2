using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FamilyWebApplication.Data;
using Microsoft.AspNetCore.Mvc;
using Models;
using AdultDataList = WebApplicationAssigment.Data.AdultDataList;

namespace WebApplicationAssigment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FamilyController : ControllerBase
    {
        private AdultDataList familyService;

        public FamilyController(AdultDataList familyService)
        {
            this.familyService = familyService;
        }

        [HttpGet]
        public async Task<ActionResult<IList<Family>>> GetFamilies()
        {
            try
            {
                IList<Family> families = familyService.GetFamilies();
                return Ok(families);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<Family>> addFamily([FromBody] Family family)
        {
            try
            {
                Family added = familyService.AddFamily(family);
                return Created($"/{added.HouseNumber}", added);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete]
        [Route("{HouseNo:int}")]
        public async Task RemoveFamily([FromRoute] int HouseNo)
        {
            familyService.RemoveFamily(HouseNo);
        }
    }
}