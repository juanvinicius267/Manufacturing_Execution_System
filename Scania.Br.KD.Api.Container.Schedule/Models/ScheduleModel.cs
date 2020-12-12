using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Scania.Br.KD.Api.Container.Schedule.Models
{
    public class ScheduleModel
    {
        [Key]
        public int IdJanela { get; set; }
        public int? IdControlTower { get; set; }
        public string Tittle { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime LastUpdate { get; set; }
        public string Country { get; set; }
        public string Batch { get; set; }     
        public int? Container { get; set; }
        public int? Doca { get; set; }
        public string URL { get; set; }

    }
}
