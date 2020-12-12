using Microsoft.EntityFrameworkCore;
using Scania.Br.Container.Scheduling.Models;
using Scania.Br.KD.Api.Container.Schedule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scania.Br.KD.Api.Container.Schedule.Data
{
    public class ContainerContext : DbContext
    {
        public ContainerContext(DbContextOptions<ContainerContext> options)
            : base(options)
        {
        }

        public DbSet<ScheduleContainerModel> TB_Schedule_Container { get; set; }
        public DbSet<DockModel> Tb_Dock { get; set; }
        public DbSet<LineModel> Tb_Line { get; set; }
        public DbSet<ContainerTypeModel> Tb_ContainerType { get; set; }

    }
}
