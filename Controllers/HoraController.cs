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
    public class HoraController : Controller
    {
        public IActionResult Index(){

            return View();
        }
        [HttpPost]
        
        public string  DataHora(){

            return DateTime.Now.ToString();
        }
     }
}