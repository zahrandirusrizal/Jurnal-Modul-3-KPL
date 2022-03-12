using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JURNALMOD3
{
    public class KodeBuah
    {
        public enum Buah { Apel, Aprikot, Alpukat, Pisang, Paprika, 
            Blackberry,
            Ceri, 
            Kelapa,
            Jagung,
            Kurma,
            Durian,
            Anggur,
            Melon,
            Semangka
        }

        public KodeBuah()
        {
        }

        public static String getKodeBuah(Buah kodeBuah_masukan)
        {
            String[] arrayofKodeBuah = { "A00" , "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00" };
            int keluaran = (int)kodeBuah_masukan;
            return arrayofKodeBuah[keluaran];
        }



    }
}
