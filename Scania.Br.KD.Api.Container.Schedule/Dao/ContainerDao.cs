using Scania.Br.Container.Scheduling.Models;
using Scania.Br.KD.Api.Container.Schedule.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scania.Br.KD.Api.Container.Schedule.Dao
{
    public class ContainerDao
    {
        private readonly ContainerContext _context;
        public ContainerDao(ContainerContext context)
        {
            this._context = context;
        }
        public List<ScheduleContainerModel> GetDataOnDb()
        {
            List <ScheduleContainerModel> data = new List<ScheduleContainerModel>();
            data = _context.TB_Schedule_Container.ToList();
            return data;
        }

        public List<ScheduleContainerModel> GetPerId(int id)
        {
            return _context.TB_Schedule_Container.Where(i => i.Id == id).ToList();
        }

        public void SetData(ScheduleContainerModel value)
        {
            _context.TB_Schedule_Container.Add(value);
            _context.SaveChanges();
        }
        public void UpdateData(int value, ScheduleContainerModel data)
        {
            data.Id = value;
            _context.TB_Schedule_Container.Update(data);
            _context.SaveChanges();
        }
        public void DeleteData(int value)
        {
            _context.TB_Schedule_Container.Remove(_context.TB_Schedule_Container.Find(value));
            _context.SaveChanges();
        }
    }
}
