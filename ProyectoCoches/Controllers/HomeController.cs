
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProyectoCoches.Models;


namespace ProyectoCoches.Controllers
{

    public class HomeController : Controller
    {
        //private readonly IRepository _repositorio;

        //public HomeController(IRepository repository)
        //{
        //    _repositorio = repository;
        //}

        //public IActionResult Index()
        //{
        //    var items = _repositorio.List<Usuarios>();
        //    return View(items);
        //}

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
}
