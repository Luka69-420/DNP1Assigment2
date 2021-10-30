using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;
using WebApplication.Data;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdultsController : ControllerBase
    {
        private IAdultsService adultsService;

        public AdultsController(IAdultsService adultsService)
        {
            this.adultsService = adultsService;
        }

        [HttpGet]
        public async Task<ActionResult<IList<Adult>>> getAdults()
        {
            try
            {
                IList<Adult> adults = await adultsService.GetAdultsAsync();
                return Ok(adults);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<Adult>> addAdult([FromBody] Adult adult)
        {
            try
            {
                Adult added = await adultsService.AddAdultsAsync(adult);
                return Created($"/{added.Id}", added);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult> DeleteTodo([FromRoute] int id)
        {
            Adult deleted = await adultsService.DeleteAdultAsync(id);
            return Ok(deleted);
        }

    }
    
    
}