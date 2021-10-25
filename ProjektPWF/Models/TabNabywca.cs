using System.ComponentModel.DataAnnotations;

namespace ProjektPWF.Models
{
    public class TabNabywca
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string Nazwa { get; set; }

        [StringLength(100)]
        public string Adres { get; set; }

        [StringLength(30)]
        public string Nip { get; set; }
    }
}