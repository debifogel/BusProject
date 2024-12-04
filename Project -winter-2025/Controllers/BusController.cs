﻿using Buses.Core.classes;
using Buses.Core.Services;
using Microsoft.AspNetCore.Mvc;



// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project__winter_2025.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusController : ControllerBase
    {
        private  readonly IBusService _context;
        public BusController(IBusService context)
        {
            _context = context;
        }
        //צריך לחשוב איך לעשות את זה
        // GET: api/<BusController>
        //[HttpGet]
        //public IEnumerable<Bus> Get()
        //{
        //    return _context. buses;
        //}

        // GET api/<BusController>/5


        [HttpGet]
        public IEnumerable<object>? Get([FromQuery] string? name, [FromQuery] string? destination, [FromQuery] string? source, [FromQuery] CompanyName? company)
        {

            return _context.GetAll(name,company,destination,source);
            
        }
       

        // POST api/<BusController>
        [HttpPost]
        public IActionResult Post([FromBody] Busfrombody bus)
        {
            
            _context.Post(bus);
            return Ok();
        }

        // PUT api/<BusController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]  Bus bus)
        {
            _context.UpDate(id, bus);
            return Ok();
        }

        // DELETE api/<BusController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _context.Delete(id);
            return Ok();
        }
    }
}
