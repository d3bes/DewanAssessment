using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DewanAssessment.mvc.Ripository
{
    public interface IBaseRipository<T> where T : class
    {
        Task<List<T>> GetAllAsync () ;
        Task<T> GetByIdAsync (int id);

        Task<T> Add (T item);
        Task<bool> UpdateAsync (T item);
        bool Delete (T item);
        Task<bool> GetByIdBoolAsync(string name);

        
    }
    
        
    
}