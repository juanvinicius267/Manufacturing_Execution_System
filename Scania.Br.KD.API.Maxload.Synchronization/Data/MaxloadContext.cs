using Microsoft.EntityFrameworkCore;
using Scania.Br.KD.API.Maxload.Synchronization.Models;

namespace Scania.Br.KD.API.Maxload.Synchronization.Data
{
    public class MaxloadContext : DbContext
    {
        public MaxloadContext(DbContextOptions<MaxloadContext> options)
           : base(options)
        {
        }

        public DbSet<MaxloadModel> Tb_Maxload { get; set; }
        public DbSet<RoundsRuleModel> Tb_RoundsRule { get; set; }
   
    }
}
