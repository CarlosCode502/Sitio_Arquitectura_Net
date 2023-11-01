using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web_Arquitecto_Net.Models;

namespace Web_Arquitecto_Net.Controllers;

public class ArquitectosController : Controller
{
    private readonly ILogger<ArquitectosController> logger;

    public ArquitectosController(ILogger<ArquitectosController> logger)
    {
        this.logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Contacto()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}