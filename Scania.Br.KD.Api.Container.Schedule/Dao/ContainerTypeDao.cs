using Scania.Br.KD.Api.Container.Schedule.Data;
using Scania.Br.KD.Api.Container.Schedule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scania.Br.KD.Api.Container.Schedule.Dao
{
    public class ContainerTypeDao
    {
        private readonly ContainerContext _context;
        public ContainerTypeDao(ContainerContext context)
        {
            this._context = context;
        }
        public List<ContainerTypeModel> GetAllData()
        {
            return _context.Tb_ContainerType.ToList();
        }

        public ContainerTypeModel GetDataPerId(int id)
        {
            return _context.Tb_ContainerType.Find(id);
        }
        public void SetData(ContainerTypeModel data)
        {
            _context.Tb_ContainerType.Add(data);
            _context.SaveChanges();
        }
        public void Update(int id, ContainerTypeModel data)
        {
            data.Id = id;
            _context.Tb_ContainerType.Update(data);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            _context.Tb_ContainerType.Remove(GetDataPerId(id));
            _context.SaveChanges();
        }
    }
}
