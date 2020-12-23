using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace blog13.Models
{
     public class Agenda2MySQL
    {  
        [Key]
        [Range(1,999999999)]
        [Required(ErrorMessage = "")]
        
        public int id {get;set;}

        [Required(ErrorMessage = "Informe um nome")]
        [DataType(DataType.Text)]
        [StringLength(10,MinimumLength=4)]

        public string nome {get;set;}

        [Required(ErrorMessage = "Informe um telefone")]
        [DataType(DataType.Text)]
        [StringLength(10,MinimumLength=4)]
      
        public string telefone {get;set;}

    }
}