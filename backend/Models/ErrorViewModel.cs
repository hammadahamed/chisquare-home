using System.ComponentModel.DataAnnotations;

namespace chi2.Models
{
    public class ErrorViewModel
    {
        [Key]
        public string RequestId { get; set; }

        // Other properties...

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
