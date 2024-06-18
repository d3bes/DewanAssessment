using AutoMapper;
using DewanAssessment.mvc.Models;
using Microsoft.AspNetCore.Mvc;
using DewanAssessment.mvc.Ripository;
using DewanAssessment.mvc.ViewModels;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace DewanAssessment.mvc.Controllers
{
    [Route("[controller]/[action]")]
    public class CartController : Controller
    {
        private readonly ILogger<CartController> _logger;
        private IBaseRipository<Item> _baseRepository { get;set;}
        private IMapper _mapper { get; set;}

        public CartController(ILogger<CartController> logger, IBaseRipository<Item> baseRepository, IMapper mapper)
        {
            _logger = logger;
            _baseRepository = baseRepository;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        public  async Task<IActionResult> GetCookieAndSendList( )
        {
        
            string idJson =  HttpContext.Session.GetString("idCookie");
            
            List<int> itemsIdsList ;
            
            if(!string.IsNullOrEmpty(idJson))
            {
                itemsIdsList = JsonConvert.DeserializeObject<List<int>>(idJson);

                List<CartItemVM> CartItemVMs = new List<CartItemVM>();
                foreach(var id in itemsIdsList) 
                {
                 var item = _baseRepository.GetByIdAsync(id);
                 CartItemVM temp = _mapper.Map<CartItemVM>(item);
                 CartItemVMs.Add(temp);
                
                }
                return View("_offCanvas", CartItemVMs);

            }
            else 
            {
            return RedirectToAction("Index","Item");
            }
           


        }

            // HttpContext.Session.SetString("idCookie", idJson);

            public async Task<IActionResult> SetCookie(int id)
            {
            

           string idJson =  HttpContext.Session.GetString("idCookie");
           if(string.IsNullOrEmpty(idJson))
           {
            HttpContext.Session.SetString("idCookie", Convert.ToString(id));
        
           }
           else
           {
            var idList = JsonConvert.DeserializeObject<List<int>>(idJson);
            idList.Append(id);

           }

            return RedirectToAction("Index", "Item");


 
            }
        public async Task<IActionResult> GetCart (string [] ids)
        {
            List<Item> result = new List<Item>();

            foreach (string id in ids)
            {

                Item item = await _baseRepository.GetByIdAsync(Convert.ToInt32(id));
                result.Add(item);

            }
        return View("_offCanvas", result);
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }

  
}