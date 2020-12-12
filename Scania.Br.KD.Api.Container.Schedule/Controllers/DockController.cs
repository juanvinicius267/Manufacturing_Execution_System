using Microsoft.AspNetCore.Mvc;
using Scania.Br.Container.Scheduling.Models;
using Scania.Br.KD.Api.Container.Schedule.Dao;
using System;
using System.Web.Http.Cors;

namespace Scania.Br.KD.Api.Container.Schedule.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [Route("api/[controller]")]
    [ApiController]
    public class DockController : ControllerBase
    {
        private readonly DockDao _context;
        public DockController(DockDao context)
        {
            this._context = context;
        }
        // GET: api/Dock
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

        // GET: api/Dock/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            if (ModelState.IsValid)
            {
                return Ok(_context.GetDataPerId(id));
            }
            return BadRequest();
        }

        // POST: api/Dock
        [HttpPost]
        public ActionResult Post([FromBody] DockModel value)
        {
            if (ModelState.IsValid)
            {
                _context.SetData(value);
                return NoContent();
            }
            return BadRequest();
        }

        // PUT: api/Dock/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] DockModel value)
        {
            if (ModelState.IsValid)
            {
                _context.Update(id, value);
                return NoContent();
            }
            return BadRequest();
        }

        // DELETE: api/ApiWithActions/5
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
