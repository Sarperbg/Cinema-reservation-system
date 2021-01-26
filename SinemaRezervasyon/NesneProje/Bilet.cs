using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneProje
{
    abstract class Bilet
    {
        private string musAd;
        private string musSoyad;
        private string musTC;
        private Koltuk koltuk;
        private int fiyat;

        protected string MusAd { get => musAd; set => musAd = value; }
        protected string MusSoyad { get => musSoyad; set => musSoyad = value; }
        protected string MusTC { get => musTC; set => musTC = value; }
        protected int Fiyat { get => fiyat; set => fiyat = value; }
        protected Koltuk Koltuk { get => koltuk; set => koltuk = value; }

        public override String ToString()
        {
            return "Bilet:\nMüşteri Adı: " + musAd + "\nMüşteri Soyadı: " + musSoyad + "\nSıra: " + koltuk.SiraNo + "\nNo: " + koltuk.KoltukNo + "\nFiyat: " + fiyat;      
        }
    }
}
