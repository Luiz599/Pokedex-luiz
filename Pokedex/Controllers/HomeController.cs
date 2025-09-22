using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pokedex.Data;
using Pokedex.Models;

namespace Pokedex.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _db;

    public HomeController(ILogger<HomeController> logger, AppDbContext db)
    {
        _logger = logger;
        _db = db;
    }

    public IActionResult Index()
    {
<<<<<<< HEAD
        var pokemons = _db.Pokemons
            .Include(p => p.Tipos)
            .ThenInclude(pt => pt.Tipo)
            .ToList();
=======
        var pokemons = _db.Pokemons.Include(p => p.Tipos).ThenInclude(pt => pt.Tipo).ToList();
>>>>>>> dcefb029732002a8cf9409544e2d56bc3a1a650e
        return View(pokemons);
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
