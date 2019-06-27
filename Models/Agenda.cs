using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Linq;
using System.Collections;
using System.ComponentModel.DataAnnotations;
namespace blog13.Models
{
    public class Agenda
    {  
       
        public int id {get;set;}

  
        public string nome {get;set;}

         public string telefone {get;set;}

    }
}