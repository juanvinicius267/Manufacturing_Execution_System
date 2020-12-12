using Scania.Br.Container.Scheduling.Models;
using Scania.Br.KD.Api.Container.Schedule.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scania.Br.KD.Api.Container.Schedule.Dao
{
    public class DockDao
    {
        private readonly ContainerContext _context;
        public DockDao(ContainerContext context)
        {
            this._context = context;
        }
        public List<DockModel> GetAllData()
        {
            return _context.Tb_Dock.ToList();
        }

        public DockModel GetDataPerId(int id)
        {
            return _context.Tb_Dock.Find(id);
        }
        public void SetData(DockModel data)
        {
            _context.Tb_Dock.Add(data);
            _context.SaveChanges();
        }
        public void Update(int id, DockModel data)
        {
            data.Id = id;
            _context.Tb_Dock.Update(data);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            _context.Tb_Dock.Remove(GetDataPerId(id));
            _context.SaveChanges();
        }
    }
}
