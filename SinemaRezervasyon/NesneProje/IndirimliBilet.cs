using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneProje
{
    class IndirimliBilet: Bilet
    {

        internal IndirimliBilet(string musAd, string musSoyad, string musTC, Koltuk koltuk)
        {
            base.MusAd = musAd;
            base.MusSoyad = musSoyad;
            base.MusTC = musTC;
            base.Koltuk = koltuk;
            base.Fiyat = 15;
        }
    }
}
