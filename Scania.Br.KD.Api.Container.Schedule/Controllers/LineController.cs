using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Scania.Br.Container.Scheduling.Models;
using Scania.Br.KD.Api.Container.Schedule.Dao;


namespace Scania.Br.KD.Api.Container.Schedule.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [Route("api/[controller]")]
    [ApiController]
    public class LineController : ControllerBase
    {
        private readonly LineDao _context;
        public LineController(LineDao context)
        {
            this._context = context;
        }
        // GET: api/Line
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

        // GET: api/Line/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            if (ModelState.IsValid)
            {
                return Ok(_context.GetDataPerId(id));
            }
            return BadRequest();
        }

        // POST: api/Line
        [HttpPost]
        public ActionResult Post([FromBody] LineModel value)
        {
            if (ModelState.IsValid)
            {
                _context.SetData(value);
                return NoContent();
            }
            return BadRequest();
        }

        // PUT: api/Line/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] LineModel value)
        {
            if (ModelState.IsValid)
            {
                _context.Update(id, value);
                return NoContent();
            }
            return BadRequest();
        }

        // DELETE: api/Line/5
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
