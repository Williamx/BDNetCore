using System;

using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.ComponentModel.DataAnnotations;
using blog13.Models;
namespace blog13.Areas.Retorno.Controllers
{
    public class LojaController : Controller
    {
       
         [Area("Retorno")]
         [HttpGet]
        public JsonResult Index()
        {        
          
           using (var db = new AgendaContexto2()){
                 
                  return Json(db.Agendas.ToList());       
           }         
        }
        
  
    }
}
