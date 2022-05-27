using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıflarım
{
    public class Admin
    {
     
        public Veritabanı.Admin GetAdmin(string kullanıcıadi, string sifre)
        {
            Veritabanı.HesapSistemiEntities1 entity = new Veritabanı.HesapSistemiEntities1();
            var sonuc = entity.Admin.Where(p => p.admin_name == kullanıcıadi).FirstOrDefault();
            return sonuc;
        }


        
    }
}
