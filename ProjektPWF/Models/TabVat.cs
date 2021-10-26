using System.ComponentModel.DataAnnotations;

namespace ProjektPWF.Models
{
    public class TabVat
    {
        [Key]
        public int IdVat { get; set; }

        public double StawkaVat { get; set; }
        
    }
}