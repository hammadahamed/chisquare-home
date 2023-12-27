using System.ComponentModel.DataAnnotations;

namespace chi2.Models
{
    public class UserViewModel
    {
            [Key]
            public int Id { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
    }
}