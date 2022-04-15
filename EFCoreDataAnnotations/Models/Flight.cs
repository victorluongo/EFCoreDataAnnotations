using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreDataAnnotations.Models
{
    public class Flight
    {
        public int Id {get; set;}
        public string Number {get; set;}
        public string Description {get; set;}
    }
}