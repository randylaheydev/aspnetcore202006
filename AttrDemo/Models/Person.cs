using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace attrdemo.Models
{
    public class Person
    {
        [Display(Name = "Navn", ResourceType = typeof(attrdemo.Resourcers.Index))]
        [Required(ErrorMessage = "FEJL")]
        public string Navn { get; set; }

        [DataType(DataType.Text)]
        public int Alder { get; set; }
        
        public bool ErSmart { get; set; }

    }
}
