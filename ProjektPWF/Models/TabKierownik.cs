using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektPWF.Models
{
    public class TabKierownik
    {
        [Key]
        public int Id { get; set; }

        [StringLength(20)]
        public string ImieKierownika { get; set; }
        
        [StringLength(30)]
        public string NazwiskoKierownika { get; set; }
    }
}
