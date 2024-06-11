using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using DewanAssessment.mvc.Models;

namespace DewanAssessment.mvc.Ripository
{
    public interface IitemRepo
    {
        public Task<List<Item>> items ();
        public Task<Item> GetItemAsync ();

        
    }
}