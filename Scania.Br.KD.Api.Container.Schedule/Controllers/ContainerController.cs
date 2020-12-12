using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Cors;
using Microsoft.AspNetCore.Mvc;
using Scania.Br.Container.Scheduling.Models;
using Scania.Br.KD.Api.Container.Schedule.Dao;

namespace Scania.Br.KD.Api.Container.Schedule.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [Route("api/[controller]")]
    [ApiController]
    public class ContainerController : ControllerBase
    {
        private readonly ContainerDao _context;
        public ContainerController(ContainerDao context)
        {
            this._context = context;
        }
        // GET api/Container
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(_context.GetDataOnDb());
            }
            catch (Exception)
            {
                return BadRequest();
            }
            
           
        }

        // GET api/Container/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_context.GetPerId(id));
        }

        // POST api/Container
    
        [HttpPost]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public ActionResult Post([FromBody] ScheduleContainerModel value)
        {
            
            if (ModelState.IsValid)
            {
                _context.SetData(value);
                return Ok();
            }
            return BadRequest();
        }


        // PUT api/Container/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] ScheduleContainerModel value)
        {
            if (ModelState.IsValid)
            {
                _context.UpdateData(id, value);
                return NoContent();
            }
            return BadRequest();
        }

        // DELETE api/Container/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                _context.DeleteData(id);
                return NoContent();
            }
            return BadRequest();
        }
    }
}
