using System.ComponentModel.DataAnnotations;

namespace ProjektPWF.Models
{
    public class TabVat
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string Stawka { get; set; }
    }
}