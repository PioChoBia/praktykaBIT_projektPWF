using System.ComponentModel.DataAnnotations;

namespace ProjektPWF.Models
{
    public class TabNabywca
    {
        [Key]
        public int Id { get; set; }

        [StringLength(200)]
        public string NazwaNabywcy { get; set; }

        [StringLength(200)]
        public string AdresNabywcy { get; set; }

        [StringLength(13)]
        public string NIP { get; set; }
    }
}