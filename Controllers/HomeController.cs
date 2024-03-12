using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Aspnet1.Models;
using IlkProje;

namespace Aspnet1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<Ogrenci> ogrencis = new List<Ogrenci>();


        ogrencis.Add(new Ogrenci()
        {
            Id = 1,
            Ad = "Ayşe",
            Soyad = "Bulut"
        });
        ogrencis.Add(new Ogrenci()
        {
            Id = 2,
            Ad = "Burak",
            Soyad = "Soylu"
        });



        return View(ogrencis);
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
