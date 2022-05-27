using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflarim
{
   public class Admin
    {
        private object nesne;
        private object p;

        public string yemekekle (Veritabanı.Cesitler Cesit )
        {
            Veritabanı.HesapSistemiEntities1 entit = new Veritabanı.HesapSistemiEntities1();
            Veritabanı.Cesitler cesitler = new Veritabanı.Cesitler();
            cesitler = Cesit;
            entit.Cesitler.Add(cesitler);
            var hedef=entit.SaveChanges();
            if (hedef == 1)
                return "1";
            else
                return "0";

        }
        public string yemekcikar(string yemekad, string yemekfiyat, Veritabanı.Cesitler Cesit)
        {
            Veritabanı.HesapSistemiEntities1 entitt = new Veritabanı.HesapSistemiEntities1();
            Veritabanı.Cesitler cesitler1 = new Veritabanı.Cesitler();           
            var aranan = entitt.Cesitler.Where(p => p.cesit_ad == yemekad, p.cesit_fiyat == yemekfiyat).FirstOrDefault();
            entitt.Cesitler.Remove(aranan);

            var hedef = entitt.SaveChanges();
            if (hedef == 1)
                return "1";
            else
                return "0";

        }

        public string VeriGuncelle(string yemekad, string yemekfiyat, Veritabanı.Cesitler Cesit)

        {

            Veritabanı.KutuphaneEntitiy ekleme = new Veritabanı.HesapSistemiEntitiy();

            Veritabanı.Cesitler yeni = new Veritabani.Cesitler();

            var aranan = ekleme.Kullanici.Where(p => p.cesit_ad == yemekad, p.cesit_fiyat == yemekfiyat).ToList().FirstOrDefault();

            aranan = nesne;

            ekleme.SaveChanges();

            var verilerigetir = Listele();

            return "1";

        }

        private object Listele()
        {
            throw new NotImplementedException();
        }
    }
}
