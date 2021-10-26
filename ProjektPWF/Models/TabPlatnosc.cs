using System.ComponentModel.DataAnnotations;

namespace ProjektPWF.Models
{
    public class TabPlatnosc
    {
        [Key]
        public int IdPlatnosc { get; set; }

        [StringLength(100)]
        public string Rodzaj { get; set; }

    }
}