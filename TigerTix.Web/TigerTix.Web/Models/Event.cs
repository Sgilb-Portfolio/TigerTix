using System;
using System.ComponentModel.DataAnnotations;

namespace TigerTix.Web.Models
{
    public class Event
    {
        
        [Required]
        public string Sport { get; set; }

        [Required]
        public string Opponent { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        
        [Required]
        public string Location { get; set; }

        
    }
}
