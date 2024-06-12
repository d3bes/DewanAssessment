using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DewanAssessment.mvc.Context;
using DewanAssessment.mvc.Models;
using Microsoft.EntityFrameworkCore;

namespace DewanAssessment.mvc.Ripository
{

    public class BaseRipository<T> : IBaseRipository<T> where T : class
    {
        public  AppDbContext _context;
        public BaseRipository(AppDbContext context) 
        {
            _context = context;
        }
        public  async Task<T> Add(T item)
        {
           await _context.Set<T>().AddAsync(item);
           await _context.SaveChangesAsync();
            return item;

        }

        public bool Delete(T item)
        {
            _context.Set<T>().Remove(item);
            _context.SaveChanges();
            return true;
        
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
           return  await _context.Set<T>().FindAsync(id);
             
        }
    
        public async Task<bool> GetByIdBoolAsync(string name)
        {
            var item =  await _context.Set<Item>().FirstOrDefaultAsync(item => item.Name == name);
                return item!=null;

        }

        public async Task<bool> UpdateAsync(T item)
        {
              _context.Set<T>().Update(item);
            await _context.SaveChangesAsync();
        return true;

        }
    }
}