using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıflarım
{
    public class Fatura
    {
        public int Veriekle(Veritabanı.Fatura nesne)
        {
            Veritabanı.HesapSistemiEntities ekleme = new Veritabanı.HesapSistemiEntities();
            Veritabanı.Fatura yeni = new Veritabanı.Fatura();

            yeni = nesne;
            ekleme.Fatura.Add(yeni);
            int sonuc = ekleme.SaveChanges();

            if (sonuc == 1)
                return 1;
            else
                return 0;





        }
    }
}
