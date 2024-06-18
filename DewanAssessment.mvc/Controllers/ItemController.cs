using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DewanAssessment.mvc.Models;
using DewanAssessment.mvc.Ripository;
using DewanAssessment.mvc.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic; // Ensure this is not conflicting with your model type

using Microsoft.Extensions.Logging;

namespace DewanAssessment.mvc.Controllers
{
    [Route("[controller]/[action]")]
    public class ItemController : Controller
    {
        private readonly ILogger<ItemController> _logger;
        private IMapper _mapper {get;set;}
    private  IBaseRipository<Item> _baseRipository { get;  set; }


        public ItemController(IBaseRipository<Item> baseRipository, IMapper mapper , ILogger<ItemController> logger)
    {
        _baseRipository = baseRipository;
        _mapper = mapper;
        _logger = logger;

    }

        public async Task<IActionResult> Index()
        {
           var items = await _baseRipository.GetAllAsync();
      
        var result = _mapper.Map<List<ItemVM>>(items);
    
 
        return View(result);
        }
        
        public async Task<IActionResult> UpdateItem (ItemVM itemVM)
        {

            var item = _mapper.Map<Item>(itemVM);
            await _baseRipository.UpdateAsync(item);
            return RedirectToAction("Index");

        }

        public async Task<IActionResult> AddItem (ItemVM itemVM)
        {
            
            var item = _mapper.Map<Item>(itemVM);
            if(! await _baseRipository.GetByIdBoolAsync(item.Name))
            {
            await _baseRipository.Add(item);


            return RedirectToAction("Index");

            }
            
            TempData["duplicate"] = "may there is a duplicate"; 
        
            return RedirectToAction("Index");
            
        }

        public  async Task<IActionResult> RemoveItem (int id)
        {
            var item = await _baseRipository.GetByIdAsync(id);
    
            _baseRipository.Delete(item);
        
        return RedirectToAction("Index");

            
        }


    }
}