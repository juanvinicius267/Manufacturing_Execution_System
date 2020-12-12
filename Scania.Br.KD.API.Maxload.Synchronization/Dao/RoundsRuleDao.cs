using Scania.Br.KD.API.Maxload.Synchronization.Data;
using Scania.Br.KD.API.Maxload.Synchronization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scania.Br.KD.API.Maxload.Synchronization.Dao
{
    public class RoundsRuleDao
    {
        private readonly MaxloadContext _context;
        public RoundsRuleDao(MaxloadContext context)
        {
            this._context = context;
        }
        public List<RoundsRuleModel> Get()
        {
            return _context.Tb_RoundsRule.ToList();
        }
        public List<RoundsRuleModel> GetPerId(int id)
        {
            return _context.Tb_RoundsRule.Where(l => l.RoundsId == id).ToList();
        }
        public void Set(RoundsRuleModel data)
        {
            _context.Tb_RoundsRule.Add(data);
            _context.SaveChanges();
        }
        public void Update(int id, RoundsRuleModel data)
        {
            _context.Tb_RoundsRule.Update(_context.Tb_RoundsRule.Find(id));
            _context.SaveChanges();
        }
        public void Remove(int id)
        {
             _context.Tb_RoundsRule.Remove(_context.Tb_RoundsRule.Find(id));
            _context.SaveChanges();
        }
    }
}
