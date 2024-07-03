using MyTeknik.Core.Entity;
using MyTeknik.Core.Service;
using MyTeknik.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyTeknik.Service.DbService
{
    public class CoreDbService<T> : IDbService<T> where T : CoreEntity
    {
        private readonly MyTeknikContext _db;
        public CoreDbService(MyTeknikContext db)
        {
            _db = db;
        }
        public bool Add(T item)
        {
            try
            {
                _db.Set<T>().Add(item);
                return Save();
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(T item)
        {
            try
            {
                _db.Set<T>().Remove(item);
                return Save();
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<T> GetAll()=> _db.Set<T>().ToList();    

        public T GetById(int id)
        {
            return _db.Set<T>().Find(id);
        }

        public bool Save()=> _db.SaveChanges() >0 ? true : false;

        public bool Update(T item)
        {
            try
            {
                _db.Set<T>().Update(item);
                return Save();
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
