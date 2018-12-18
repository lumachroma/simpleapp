using System.ComponentModel.DataAnnotations;

namespace SimpleApp.Controllers
{
    public class NewSessionModel
    {
        [Required]
        public string SessionName { get; set; }
    }
}
