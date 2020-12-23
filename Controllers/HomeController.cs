using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using blog13.Models;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace blog13.Controllers
{
    public class HomeController : Controller
    {
       
         [HttpGet]
         [RequireHttps]
        
        public IActionResult Index()
        {        
           using (var db = new AgendaContexto2()){
                 
                  return View(db.Agendas.Where(s => s.id == 2).ToList());       
           }
                      
        }
         [HttpGet]
         [RequireHttps]
        public IActionResult Privacy()
         {
            using (AgendaContexto2 dbcontexto = new AgendaContexto2())
             {
                  IEnumerable<Agenda> Agendas = dbcontexto.Agendas.ToList();
                  Agendas =  Agendas.Where(s => s.id == 3);
                  
                  ViewBag.f = Agendas;
                  
                 return View();
                  //return View(db.Agendas.Where(s => s.id == 3).ToList());       
             }
         }
         public IActionResult My()
         {                         
                         
                  var dbcontexto = new AgendaContexto();
             
                  IEnumerable<Agenda> Agendas = dbcontexto.Agendas.ToList();
                   //Agendas =  Agendas.Where(s => s.id == 1);
                  
                  ViewBag.g = Agendas;
                  
                 return View();
                  //return View(db.Agendas.Where(s => s.id == 3).ToList());       
             
 

         }
         
         
        [RequireHttps]
        [HttpGet]
        [HttpPost]
        
       public IActionResult Sq()
         {                         
                         
                  var dbcontexto = new AgendaContexto3();
             
                  IEnumerable<Agenda> Agendas = dbcontexto.Agendas.ToList();
                   //Agendas =  Agendas.Where(s => s.id == 1);
                  
                  ViewBag.g = Agendas;
                  
                 return View();
                  //return View(db.Agvaendas.Where(s => s.id == 3).ToList());       
             
 

         }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
