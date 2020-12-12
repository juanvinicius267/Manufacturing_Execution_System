using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Scania.Br.KD.Api.Container.Schedule.Data;
using Scania.Br.KD.Api.Container.Schedule.Models;

namespace Scania.Br.KD.Api.Container.Schedule.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiScheduleContainerController : ControllerBase
    {
        private readonly KdexContext _context;
        public ApiScheduleContainerController(KdexContext context)
        {
            this._context = context;
        }
        // GET: api/ApiScheduleContainer
        [HttpGet]
        public ActionResult Get()
        {
            DateTime ActualDate = DateTime.Now;
            List<ScheduleModel> data = _context.Schedule
                .Where(d => d.StartTime.Date == ActualDate.Date)
                .ToList();
            return Ok(data);
            
        }

       
    }
}
