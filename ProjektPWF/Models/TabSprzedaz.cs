using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektPWF.Models
{
    class TabSprzedaz
    {
        [Key]
        public int IdSprzedaz { get; set; } 

        [Column(TypeName="Date")]
        public DateTime DataSprzedazy { get; set; }

        [Column(TypeName = "Date")]
        public DateTime DataWystawienia { get; set; }

        public int NrZlecenia { get; set; }

        public int NrUmowy { get; set; }
        [StringLength(1000)]

        public string Tresc { get; set; }

        public double Netto { get; set; }

        [StringLength(200)]
        public string Uwagi { get; set; }
        
        public int IdDostarczanie { get; set; }
        [ForeignKey("IdDostarczanie")]
        public int? TabDostarczanie { get; set; }
        public virtual TabDostarczanie Dostarczanie { get; set; }

        public int IdKierownik { get; set; }
        [ForeignKey("IdKierownik")]
        public int? TabKierownik { get; set; }
        public virtual TabKierownik Kierownik { get; set; }

        public int IdNabywca { get; set; }
        [ForeignKey("IdNabywca")]
        public int? TabNabywca { get; set; }
        public virtual TabNabywca Nabywca { get; set; }

        public int IdPlatnosc { get; set; }
        [ForeignKey("IdPlatnosc")]
        public int? TabPlatnosc { get; set; }
        public virtual TabPlatnosc Platnosc { get; set; }

        public int IdStatus { get; set; }
        [ForeignKey("IdStatus")]
        public int? TabStatus { get; set; }
        public virtual TabStatus Status { get; set; }

        public int IdTermin { get; set; }
        [ForeignKey("IdTermin")]
        public int? TabTermin { get; set; }
        public virtual TabTermin Termin { get; set; }
        
        public int IdVat { get; set; }
        [ForeignKey("IdVat")]
        public int? TabVat { get; set; }
        public virtual TabVat Vat { get; set; }
    }
}
