using System.ComponentModel.DataAnnotations;

namespace TigerTix.Web.Models
{
    public class IndexViewModel
    {
        [Required]
        public string Username { get; set; }
    }
}
