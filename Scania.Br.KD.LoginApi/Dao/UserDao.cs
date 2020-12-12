using Scania.Br.KD.LoginApi.Data;
using Scania.Br.KD.LoginApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scania.Br.KD.LoginApi.Dao
{
    public class UserDao
    {
        private readonly UserContext _context;
        public UserDao(UserContext context)
        {
            this._context = context;
        }
        public User GetAll(User user)
        {
            return _context.Tb_User.Where(w => w.Username == user.Username && w.Password == user.Password ).First();
        }
    }
}
