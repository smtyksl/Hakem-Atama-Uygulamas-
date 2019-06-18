using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OrduAtama
{
    public static class Selectors
    {

        public static IQueryable<HakemData> ToHakemData(this IQueryable<Hakem> dataSource)
        {
            return dataSource
                    .Select(l => new HakemData
                    {
                        Id = l.Id,
                        Ad = l.Ad,
                        Soyad = l.SoyAd,
                        VizeDurumu = l.VizeDurumu1.Ad,
                        Klasman = l.Klasman.Ad,
                        
                    });
        }
    }
}
