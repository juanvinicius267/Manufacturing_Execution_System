using Microsoft.EntityFrameworkCore;
using Scania.Br.KD.Api.Container.Schedule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scania.Br.KD.Api.Container.Schedule.Data
{
    public class KdexContext : DbContext
    {
        public KdexContext(DbContextOptions<KdexContext> options)
            : base(options)
        {
        } 
        public DbSet<ScheduleModel> Schedule { get; set; }
    }
}
