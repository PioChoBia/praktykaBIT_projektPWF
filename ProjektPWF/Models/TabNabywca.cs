using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
