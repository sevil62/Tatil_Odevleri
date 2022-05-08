using BLL.IntRep;
using DAL.Context;
using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BaseRep
{
    public class BaseRepository<T> : IRepository<T>where T :BaseEntity
    {

        MyContext db=new MyContext();

        public string Create(T model)
        {
           db.Set<T>().Add(model);
            db.SaveChanges();
            return "Veri kaydedildi";
        }

        public string Delete(int id)
        {
            var deleted=db.Set<T>().Find(id);
            db.Set<T>().Remove(deleted);
            db.SaveChanges();
            return "Veri silindi";
        }

        public T FindById(int id)
        {
            return db.Set<T>().Find(id);
            
        }

        public List<T> GetList()
        {
            return db.Set<T>().ToList();
        }

       

        public string Update(T model)
        {
            db.Entry(model).State =System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return "Veri güncellendi";
        }
    }
}
