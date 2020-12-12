using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace Scania.Br.KD.MES.UI.Controllers
{
    public class CalendarController : Controller
    {
        public IActionResult Index()
        {
            return Redirect("/Calendar.html");
        }

      

       
    }
}
