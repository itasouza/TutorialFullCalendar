using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoWebCalendario.Models;

namespace ProjetoWebCalendario.Controllers
{
    public class HomeController : Controller
    {
        //http://www.macoratti.net/17/06/c_listas1.htm
        static List<Evento> eventos;

        public IActionResult Index()
        {
            return View();
        }


        public JsonResult DadosEvento()
        {

            eventos = new List<Evento>();
            eventos.Add(new Evento(1, "Tutorial PagSeguro", "#FFD700", "", Convert.ToDateTime("2020-01-06 13:00:00"), Convert.ToDateTime("2020-01-06 14:00:00")));
            eventos.Add(new Evento(2, "Tutorial FullCalendar editar detalhes do evento", "#0071c5", "https://www.google.com/", Convert.ToDateTime("2020-01-06 11:00:00"), Convert.ToDateTime("2020-01-06 12:00:00")));
            eventos.Add(new Evento(3, "Tutorial FullCalendar Visualizar detalhes do evento", "#42d29d", "https://www.google.com/",  Convert.ToDateTime("2020-01-06 08:00:00"), Convert.ToDateTime("2020-01-06 09:00:00")));
            eventos.Add(new Evento(2, "Tutorial FullCalendar editar detalhes do evento", "#0071c5", "https://www.google.com/", Convert.ToDateTime("2020-01-06 10:00:00"), Convert.ToDateTime("2020-01-06 11:00:00")));
            eventos.Add(new Evento(3, "Tutorial FullCalendar Visualizar detalhes do evento", "#42d29d", "https://www.google.com/", Convert.ToDateTime("2020-01-06 07:00:00"), Convert.ToDateTime("2020-01-06 08:00:00")));
            eventos.Add(new Evento(4, "Tutorial PagSeguro", "#FFD700", "", Convert.ToDateTime("2020-01-08 15:00:00"), Convert.ToDateTime("2020-01-08 16:00:00")));
            eventos.Add(new Evento(5, "Tutorial FullCalendar editar detalhes do evento", "#0071c5", "", Convert.ToDateTime("2020-01-08 15:00:00"), Convert.ToDateTime("2020-01-08 16:00:00")));
            eventos.Add(new Evento(6, "Tutorial FullCalendar Visualizar detalhes do evento", "#42d29d", "", Convert.ToDateTime("2020-01-08 15:00:00"), Convert.ToDateTime("2020-01-08 16:00:00")));

            return Json(eventos);
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
