using Scania.Br.Container.Scheduling.Models;
using Scania.Br.KD.Api.Container.Schedule.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scania.Br.KD.Api.Container.Schedule.Dao
{
    public class LineDao
    {
        private readonly ContainerContext _context; 
        public LineDao(ContainerContext context)
        {
            this._context = context;
        }

        public List<LineModel> GetAllData()
        {
            return _context.Tb_Line.ToList();
        }

        public LineModel GetDataPerId(int id)
        {
            return _context.Tb_Line.Find(id);
        }
        public void SetData(LineModel data)
        {
            _context.Tb_Line.Add(data);
            _context.SaveChanges();
        }
        public void Update(int id, LineModel data)
        {
             data.Id = id; 
            _context.Tb_Line.Update(data);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            _context.Tb_Line.Remove(GetDataPerId(id));
            _context.SaveChanges();
        }




    }
}
