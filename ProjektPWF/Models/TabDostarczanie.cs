using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjektPWF.Models
{
    public class TabDostarczanie
    {
        [Key]
        public int IdDostarczanie { get; set; }

        [StringLength(100)]
        public string Sposob { get; set; }
                
    }
}