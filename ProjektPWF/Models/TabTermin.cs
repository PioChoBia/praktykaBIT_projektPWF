using System.ComponentModel.DataAnnotations;

namespace ProjektPWF.Models
{
    public class TabTermin
    {
        [Key]
        public int Id { get; set; }

        public int Termin { get; set; }
    }
}