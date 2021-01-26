using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneProje
{
    class Koltuk
    { 

        private int siraNo;
        private int koltukNo;
        private bool doluMu;

        public Koltuk(int siraNo, int koltukNo, bool doluMu)
        {
            this.siraNo = siraNo;
            this.koltukNo = koltukNo;
            this.doluMu = doluMu;
        }

        public int SiraNo { get => siraNo; }
        public int KoltukNo { get => koltukNo; }
        public bool DoluMu { get => doluMu; }

        public bool yerAyir()
        {
            if (!doluMu)
            {
                this.doluMu = true;
                return true;
            }
            return false;
        }
    }
}
