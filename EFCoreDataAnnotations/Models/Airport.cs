using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using EFCoreDataAnnotations.Models;

namespace EFCoreDataAnnotations.Models
{
    public class Airport
    {
        public int Id {get; set;}
        public string Iata {get; set;}
        public string Description {get; set;}
        public double Latitude {get; set;}
        public double Longitude {get; set;}        
    }
}