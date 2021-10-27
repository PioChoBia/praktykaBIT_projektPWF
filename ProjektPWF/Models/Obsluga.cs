using System.ComponentModel.DataAnnotations;

namespace ProjektPWF.Models
{
    public class Obsluga
    {
        //nawet specjalnie daje to
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string Stawka { get; set; }
    }
}