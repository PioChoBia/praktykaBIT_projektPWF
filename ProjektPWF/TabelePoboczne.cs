using ProjektPWF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektPWF
{
    class TabelePoboczne
    {
        public List<DostarczanieViewModel> WyswietlDostarczanie()
        {
            using (var dbContext = new ApplicationDbContext())
            {
                var dane = dbContext.DostarczanieC.AsNoTracking().
                    Select(s => new DostarczanieViewModel
                    {
                        Id=s.Id,
                        Sposob=s.Sposob
                    }).ToList();
                return dane;
            }
        }









    }
}
