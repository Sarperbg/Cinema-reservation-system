using System;
using System.Collections;
using System.Collections.Generic;

namespace NesneProje
{
    class Gosterim
    {
        private List<Koltuk> koltuklar;
        private string filmAdi;
        private int seans;
        private DateTime tarih;
        private int salonNo;

        public Gosterim(string filmAdi, int seans, DateTime tarih, int salonNo)
        {
            koltuklar = new List<Koltuk> { };
            this.filmAdi = filmAdi;
            this.seans = seans;
            this.tarih = tarih;
            this.salonNo = salonNo;
        }

        public void koltukEkle(Koltuk koltuk)
        {
            koltuklar.Add(koltuk);
        }

        public Koltuk koltukDoluMu(int siraNo, int koltukNo)
        {
            //koltuk boş ise geriye o koltuğu return ediyor;
            foreach(Koltuk i in koltuklar)
            {
                if(i.SiraNo == siraNo && i.KoltukNo == koltukNo)
                {
                    if (i.DoluMu)
                        return null;
                    else
                        return i;
                }
            }
            return null;
        }

        public override string ToString()
        {
            return "Film Adı: " + filmAdi + "\nSeans: " + seans + "\nSalon: " + salonNo + "\nTarih: " + tarih.ToShortDateString();
        }

    }
}
