﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

using WAEFCore22.AppCode.Interface.Repos;

using Whatsapp.Models.Data;

namespace WAEFCore22.AppCode.BusinessLogic.Repos
{
    public class GenericRepository : IGenericRepository
    {
        private readonly ApplicationContext _dbContext;

        public GenericRepository(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }



        public async Task<IEnumerable<T>> FindAsync<T>(Expression<Func<T, bool>> expression = null) where T : class
        {
            try
            {
                return await _dbContext.Set<T>().Where(expression).ToListAsync();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<T> SingleOrDefaultAsync<T>(Expression<Func<T, bool>> expression=null) where T : class
        {
            return await _dbContext.Set<T>().SingleOrDefaultAsync(expression);
        }

        public void Add<T>(T entity) where T : class
        {
            var i = _dbContext.Set<T>().Add(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
        }



        public void Delete<T>(T entity) where T : class
        {
            _dbContext.Set<T>().Remove(entity);
        }

        public async Task<IEnumerable<T>> FindAllRecords<T>(Expression<Func<T, bool>> expression = null) where T : class
        {

            try
            {
                var result = await Task.FromResult(_dbContext.Set<T>());
                return result.ToList();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<IEnumerable<T>> FindAllRecords1<T>() where T : class
        {
            try
            {
                return await _dbContext.Set<T>().ToListAsync();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public async Task<IEnumerable<T>> Get<T>(
            Expression<Func<T,
            bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "") where T : class
        {
            try
            {
                IQueryable<T> query = _dbContext.Set<T>();

                if (filter != null)
                {
                    query = query.Where(filter);
                }

                foreach (var includeProperty in includeProperties.Split
                    (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }

                if (orderBy != null)
                {
                    return await orderBy(query).ToListAsync();
                }
                else
                {
                    return await query.ToListAsync();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
      
    }
}
