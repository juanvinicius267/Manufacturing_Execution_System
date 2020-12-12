using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Scania.Br.KD.API.Maxload.Synchronization.Dao;
using Scania.Br.KD.API.Maxload.Synchronization.Models;

namespace Scania.Br.KD.API.Maxload.Synchronization.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [Route("api/[controller]")]
    [ApiController]
    public class MaxloadController : ControllerBase
    {
        private readonly MaxloadDao _context;
        public MaxloadController(MaxloadDao context)
        {
            this._context = context;
        }
        // GET: api/Maxload
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(_context.Get());
            }
            catch (Exception)
            {

                return BadRequest();
            }
            
        }

        // GET: api/Maxload/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Maxload
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Maxload/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
