using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;
using WebApplicationAssigment.Data;

namespace WebApplicationAssigment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdultsController : ControllerBase
    {
       // private AdultDataList adultsService;
        private IAdultService AdultService;

        public AdultsController(IAdultService AdultService)
        {
            this.AdultService = AdultService;
        }

        [HttpGet]
        public async Task<ActionResult<IList<Adult>>> getAdults()
        {
            try
            {
                IList<Adult> adults = await AdultService.GetAdultsAsync();
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
                await AdultService.PostAdultAsync(adult);
               return Created($"/{adult.Id}", adult);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task RemoveAdult([FromRoute] int id)
        {
            try
            {
                await AdultService.RemoveAdult(id);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                StatusCode(500, e.Message);
            }
        }
    }
}