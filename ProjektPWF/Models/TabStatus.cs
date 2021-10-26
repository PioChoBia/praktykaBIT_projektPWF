using System.ComponentModel.DataAnnotations;

namespace ProjektPWF.Models
{
    public class TabStatus
    {
        [Key]
        public int Id{ get; set; }

        [StringLength(50)]
        public string Status { get; set; }
    }
}