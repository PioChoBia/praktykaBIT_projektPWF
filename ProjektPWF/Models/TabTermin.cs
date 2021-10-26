using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjektPWF.Models
{
    public class TabTermin
    {
        [Key]
        public int Id { get; set; }

        public int Termin { get; set; }
    }
}