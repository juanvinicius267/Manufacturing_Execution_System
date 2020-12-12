using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Scania.Br.KD.Api.Container.Schedule.Models
{
    public class ContainerTypeModel
    {
        [Key]
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string ComprimentoExterno { get; set; }
        public string LarguraExterna { get; set; }
        public string AlturaExterna { get; set; }
        public string ComprimentoInterno { get; set; }
        public string LarguraInterna { get; set; }
        public string AlturaInterna { get; set; }
        public string CapacidadeM3 { get; set; }
        public string PesoMaximo { get; set; }
        public DateTime DataDeGravacao { get; set; }



    }
}

