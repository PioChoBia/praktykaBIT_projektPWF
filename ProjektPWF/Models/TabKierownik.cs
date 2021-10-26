﻿using System.ComponentModel.DataAnnotations;

namespace ProjektPWF.Models
{
    public class TabKierownik
    {
        [Key]
        public int IdKierownik { get; set; }
        //public virtual TabSprzedaz Kierownik { get; set; }

        [StringLength(20)]
        public string ImieKierownika { get; set; }
        
        [StringLength(30)]
        public string NazwiskoKierownika { get; set; }
    }
}