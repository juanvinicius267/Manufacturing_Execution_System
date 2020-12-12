using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Scania.Br.KD.API.Maxload.Synchronization.Models
{
    public class MaxloadModel
    {
        [Key]
        public int MaxloadId { get; set; }
        public string BatchId { get; set; }
        public int ContainerNum { get; set; }
        public string Component { get; set; }        
        public string MuCode { get; set; }
        public string BoxeNumber { get; set; }
        public int PriorityNumber { get; set; }
        public int PriorityNumber2 { get; set; }
        public DateTime SavedHour { get; set; }
    }
}
