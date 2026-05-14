using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP3_Recetify.Models;

namespace TP3_Recetify.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    [HttpGet]
    public IActionResult generarSugerencia(SugeridorReceta datos)
    {
       ViewBag.dificultad = datos.determinarDificultad();
       ViewBag.plato = datos.devolverComida();
       ViewBag.tiempo = datos.calcularTiempo();
       ViewBag.datos = datos;
       
        return View("generarSugerencia");
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
