using System.ComponentModel.DataAnnotations;

namespace ProjektPWF.Models
{
    public class TabStatus
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string Termin { get; set; }
    }
}