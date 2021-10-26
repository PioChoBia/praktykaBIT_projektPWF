using System.ComponentModel.DataAnnotations;

namespace ProjektPWF.Models
{
    public class TabStatus
    {
        [Key]
        public int IdStatus { get; set; }

        [StringLength(50)]
        public string Status { get; set; }
    }
}