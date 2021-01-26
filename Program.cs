using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneProje
{
    class Program
    {
        static void Main(string[] args)
        {
            RezervasyonSistemi rs = new RezervasyonSistemi();
            rs.start();
            Console.ReadKey();
        }
    }
}
