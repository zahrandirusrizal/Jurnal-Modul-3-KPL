// See https://aka.ms/new-console-template for more information


using System;

namespace JURNALMOD3
{
    class Program
    {
        static void Main(string [] args)
        {
            KodeBuah.Buah namaBuah = KodeBuah.Buah.Paprika;
            System.Console.WriteLine(KodeBuah.getKodeBuah(namaBuah));
        }
    }

}
