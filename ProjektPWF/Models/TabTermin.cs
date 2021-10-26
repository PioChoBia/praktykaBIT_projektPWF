using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjektPWF.Models
{
    public class TabTermin
    {
        [Key]
        public int IdTermin { get; set; }

        [Column(TypeName = "Date")]
        public DateTime Termin { get; set; }
    }
}