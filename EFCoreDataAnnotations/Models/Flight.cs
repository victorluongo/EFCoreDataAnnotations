using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDataAnnotations.Models
{
    [Table("Flights")]
    [Index(nameof(Number), IsUnique=true)]
    public class Flight
    {
        [Key]
        public int Id {get; set;}
        
        [Required]
        [Column("FlightNumber", TypeName = "VARCHAR(6)")]
        public string Number {get; set;}
        
        [MaxLength(150)]
        public string Description {get; set;}

        public Airport Departure {get; set;}
        
        public Airport Arrival {get; set;}

        [NotMapped]
        public DateTime EAT {get; set;}
    }
}