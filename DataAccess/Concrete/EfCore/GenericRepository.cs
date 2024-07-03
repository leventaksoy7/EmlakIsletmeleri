using DAL.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete.EfCore
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly EfContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(EfContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public void Create(T entity)
        {
            try
            {
                _dbSet.Add(entity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public void Update(T entity)
        {
            try
            {
                _dbSet.Update(entity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public void Delete(T entity)
        {
            try
            {
                _dbSet.Remove(entity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
