using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ntier.ORM.Entity
{
   public class Urun
    {
        public int UrunId { get; set; }

        public string UrunAdi { get; set; }

        public int TedarikciId { get; set; }

        public int KategoriId { get; set; }

        public string BirimdekiMiktar { get; set; }

        public decimal Fiyat { get; set; }

        public short Stok { get; set; }

        public short YeniSatis { get; set; }

        public bool Sonlandi { get; set; }
    }
}
