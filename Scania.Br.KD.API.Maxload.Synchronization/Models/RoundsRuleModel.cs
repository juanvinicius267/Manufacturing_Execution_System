using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Scania.Br.KD.API.Maxload.Synchronization.Models
{
    public class RoundsRuleModel
    {

        [Key]
        public int RoundsId { get; set; }
        public string Component { get; set; }
        public string MuCode { get; set; }
        public int CabRounds { get; set; }
        public int SkdRounds { get; set; }
        public int SkidRounds { get; set; }
        public int EcuRounds { get; set; }
        public bool CabLine { get; set; }
        public bool SkdLine { get; set; }
        public bool SkidLine { get; set; }
        public bool EcuLine { get; set; }
        public bool CabDock { get; set; }
        public bool SkdDock { get; set; }
        public bool SkidDock { get; set; }
        public bool EcuDock { get; set; }
        public DateTime SavedHour { get; set; }
    }
}
