using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Scania.Br.KD.Api.Container.Schedule.Dao;
using Scania.Br.KD.Api.Container.Schedule.Data;
using Scania.Br.KD.Api.Container.Schedule.Models;

namespace Scania.Br.KD.Api.Container.Schedule.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [Route("api/[controller]")]
    [ApiController]
    public class ContainerTypeController : ControllerBase
    {
        private readonly ContainerTypeDao _context;
        public ContainerTypeController(ContainerTypeDao context)
        {
            this._context = context;
        }
        // GET: api/ContainerType
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(_context.GetAllData());
            }
            catch (Exception)
            {
                return BadRequest();
            }

        }

        // GET: api/ContainerType/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            if (ModelState.IsValid)
            {
                return Ok(_context.GetDataPerId(id));
            }
            return BadRequest();
        }

        // POST: api/ContainerType
        [HttpPost]
        public ActionResult Post([FromBody] ContainerTypeModel value)
        {
            if (ModelState.IsValid)
            {
                _context.SetData(value);
                return NoContent();
            }
            return BadRequest();
        }

        // PUT: api/ContainerType/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] ContainerTypeModel value)
        {
            if (ModelState.IsValid)
            {
                _context.Update(id, value);
                return NoContent();
            }
            return BadRequest();
        }

        // DELETE: api/ContainerType/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                _context.Delete(id);
                return NoContent();
            }
            return BadRequest();
        }
    }
}
