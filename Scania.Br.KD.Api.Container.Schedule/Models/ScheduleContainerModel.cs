using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Scania.Br.Container.Scheduling.Models
{
    public class ScheduleContainerModel
    {
        [Key]
        public int Id { get; set; }
        public string BatchId { get; set; }
        public string Container_Number  { get; set; }
        public DateTime Star_Date { get; set; }
        public DateTime End_Date { get; set; }
        public string Line { get; set; }
        public int Dock{ get; set; }
        public DateTime Create_Date { get; set; }
        public Nullable<DateTime> Edit_Date { get; set; }
        public string User_Create { get; set; }
        public string User_Edit { get; set; }
        public string Container_Type { get; set; }
        public string License_Plate { get; set; }
        //public int ShippingCompanyId { get; set; }
        public string Shipping_Company { get; set; }
    }
}
