using System.ComponentModel.DataAnnotations;

namespace DotNetCoreCamp.Models
{
    public class RoleViewModel
    {
        [Required(ErrorMessage = "Lütfen bir rol adı giriniz...")]
        public string name { get; set; }
    }
}
