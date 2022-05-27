using System;
using System.Collections.Generic;

namespace Veritabanı
{
    internal class KutuphaneEntitiy
    {
        public IEnumerable<object> Kullanici { get; internal set; }

        public static implicit operator KutuphaneEntitiy(HesapSistemiEntitiy v)
        {
            throw new NotImplementedException();
        }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}