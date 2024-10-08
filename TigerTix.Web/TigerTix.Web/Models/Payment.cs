using System;
using System.ComponentModel.DataAnnotations;

namespace TigerTix.Web.Models
{
    public class Payment
    {
        public string CardNumber { get; set; }
        public string ExpirationDate { get; set; }
        public string CVV { get; set; }
        public string Name { get; set; }
        public string ZipCode { get; set; }
    }
}
