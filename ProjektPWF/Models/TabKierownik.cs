using System.ComponentModel.DataAnnotations;

namespace ProjektPWF.Models
{
    public class TabKierownik
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string ImieNazwisko { get; set; }
    }
}