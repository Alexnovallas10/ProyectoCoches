using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProyectoCoches_DATA.Data.Entitys;
using ProyectoCoches_DATA.Data.Repository;
using ProyectoCoches_MVC.Models;

namespace ProyectoCoches_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository _IRepository;

        public HomeController(IRepository IRepository)
        {
            _IRepository = IRepository;
        }

        public IActionResult Index()
        {
            var items = _IRepository.List<Coches>();
            return View(items);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult InsertarCoche(Coches coches)
        {

            var items = _IRepository.Add<Coches>(coches);         
            return View(items);
        }

        public IActionResult InsertarDatosUsuario(Datosusuario datosusuario) {

            var items = _IRepository.Add<Datosusuario>(datosusuario);
            return View(items);
        }

        public IActionResult Contact()
        {
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
