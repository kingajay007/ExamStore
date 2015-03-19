using ExamStore.Data;
using ExamStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamStore.Services
{
    public class EfRepository<T> : IRepository<T> where T: class
    {
        private StoreContext _context = new StoreContext();
        public IQueryable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public T FindById(int id)
        {
            var entity = _context.Set<T>().Find(id);
            return entity;
        }

        public bool Create(T TObject)
        {
            try
            {
                _context.Set<T>().Add(TObject);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public bool Update(int id,T TObject)
        {
            try
            {
                var existing = _context.Set<T>().Find(id);
                _context.Entry(existing).CurrentValues.SetValues(TObject);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {   
                throw ex;
            }
        }

        public bool Delete(T TObject)
        {
            _context.Entry(TObject).State = System.Data.Entity.EntityState.Deleted;
            _context.SaveChanges();
            return true;
        }

        public bool CreateMultiple(List<T> TObjects)
        {
            try
            {
                foreach (T item in TObjects)
                {
                    _context.Entry(item).State = System.Data.Entity.EntityState.Added;
                }
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
    }
}