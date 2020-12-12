using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Scania.Br.KD.API.Maxload.Synchronization.Dao;
using Scania.Br.KD.API.Maxload.Synchronization.Models;
using System;
using System.Web.Http.Cors;

namespace Scania.Br.KD.Digital.Standard.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [Route("api/[controller]")]
    [ApiController]
    [Authorize("Admin")]
    public class RoundsRuleController : ControllerBase
    {
        private readonly RoundsRuleDao _context;
        public RoundsRuleController(RoundsRuleDao context)
        {
            this._context = context;
        }
        // GET: api/Maxload
        [HttpGet]
        public ActionResult Get()
        {            
            return Ok(_context.Get());
        }

        // GET: api/Maxload/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult Get(int id)
        {
            return  Ok(_context.GetPerId(id));
        }

        // POST: api/Maxload
        [HttpPost]
        public ActionResult Post([FromBody] RoundsRuleModel value)
        {
            _context.Set(value);
            return NoContent();
        }

        // PUT: api/Maxload/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] RoundsRuleModel value)
        {
            _context.Update(id,value);
            return NoContent();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _context.Remove(id);
            return NoContent();
        }

       
    }
}