using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflarim
{
    public class Cesit
    {
        public List<Veritabanı.Cesitler> Ces(int yemekid)
        {
            Veritabanı.HesapSistemiEntities1 entity = new Veritabanı.HesapSistemiEntities1();
            var sonuc = entity.Cesitler.Where(p => p.yemek_fk_id == yemekid).ToList();
            return sonuc;
        }

    }
}