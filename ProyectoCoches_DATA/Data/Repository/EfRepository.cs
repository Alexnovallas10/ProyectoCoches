
using Microsoft.EntityFrameworkCore;
using ProyectoCoches_DATA.Data.Context;
using ProyectoCoches_DATA.Data.Entitys;
using System.Collections.Generic;
using System.Linq;


namespace ProyectoCoches_DATA.Data.Repository
{
    public class EfRepository : IRepository
    {

        private readonly ProyectocochesContext _dbContext;

        public EfRepository(ProyectocochesContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Coches> ListaCoches()
        {
            return _dbContext.Coches.ToList();
        }

        public List<T> ListaGenerica<T>() where T : BaseEntity
        {
            return _dbContext.Set<T>().ToList();
        }


        public T GetById<T>(int id) where T : BaseEntity
        {
            return _dbContext.Set<T>().SingleOrDefault(e => e.Id == id);
        }

        public List<T> List<T>() where T : BaseEntity
        {
            return _dbContext.Set<T>().ToList();
        }

        public T Add<T>(T entity) where T : BaseEntity
        {
            _dbContext.Set<T>().Add(entity);
            _dbContext.SaveChanges();

            return entity;
        }

        public void Delete<T>(T entity) where T : BaseEntity
        {
            _dbContext.Set<T>().Remove(entity);
            _dbContext.SaveChanges();
        }

        public void Update<T>(T entity)where T : BaseEntity
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}

