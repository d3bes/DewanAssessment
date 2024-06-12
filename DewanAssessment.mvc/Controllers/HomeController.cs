using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DewanAssessment.mvc.Models;
using DewanAssessment.mvc.Ripository;
using DewanAssessment.mvc.ViewModels;
using AutoMapper;

namespace DewanAssessment.mvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private IMapper _mapper {get;set;}
    private  IBaseRipository<Item> _baseRipository { get;  set; }

    public HomeController(IBaseRipository<Item> baseRipository, IMapper mapper , ILogger<HomeController> logger)
    {
        _baseRipository = baseRipository;
        _mapper = mapper;
        _logger = logger;

    }



    public IActionResult Index()
    {

        // var items = await _baseRipository.GetAllAsync();

        // var result = _mapper.Map<List<ItemVM>>(items);


        // return View(result);
    return  RedirectToAction("Index", "Item");
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
