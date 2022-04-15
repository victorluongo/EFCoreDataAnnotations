using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreDataAnnotations.Models
{
    [Table("Flights")]
    public class Flight
    {
        [Key]
        public int Id {get; set;}
        
        [Required]
        [Column("FlightNumber", TypeName = "VARCHAR(6)")]
        public string Number {get; set;}
        
        [MaxLength(150)]
        public string Description {get; set;}
    }
}