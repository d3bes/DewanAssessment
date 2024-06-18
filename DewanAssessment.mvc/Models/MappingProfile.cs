using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DewanAssessment.mvc.ViewModels;

namespace DewanAssessment.mvc.Models
{
    public class MappingProfile:Profile
    {

        public MappingProfile()
        {
         CreateMap<Item,ItemVM>();   
          CreateMap<ItemVM, Item>();
          CreateMap<CartItemVM,Item>();
          CreateMap<Item,CartItemVM>();
        }
        
    }
}