using Microsoft.EntityFrameworkCore;
using Scania.Br.KD.LoginApi.Models;

namespace Scania.Br.KD.LoginApi.Data
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options)
         : base(options)
        {
        }

        public DbSet<User> Tb_User { get; set; }
       
    }
}
