using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Cors;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Scania.Br.KD.API.Maxload.Synchronization.Dao;

namespace Scania.Br.KD.API.Maxload.Synchronization.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [Route("api/[controller]")]
    public class LoadFileController : Controller
    {
        private readonly MaxloadDao _context;
        IHostingEnvironment _evt;
        public LoadFileController(IHostingEnvironment envirement, MaxloadDao context)
        {
            this._evt = envirement;
            this._context = context;
        }
      
        
       
        [HttpPost]
        public async Task<IActionResult> Post(IFormFile file)
        {
           await _context.Set(_context.FilterData(_context.OpenFile(file)));
            return NoContent();
        }
       
    }
}