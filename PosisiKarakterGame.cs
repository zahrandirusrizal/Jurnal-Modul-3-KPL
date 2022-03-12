using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JURNALMOD3
{
    public class PosisiKarakterGame
    {
        public enum KarakterState { Berdiri, Jongkok, Tengkurap, Terbang};
        public enum TombolAksi { TombolW, TombolS, TombolX};

        public class Transisi
        {
            public KarakterState StateSebelum;
            public KarakterState StateSetelah;
            public TombolAksi AksiKarakter;

            public Transisi(KarakterState StateSebelum, KarakterState StateSetelah, TombolAksi AksiKarakter)
            {
                this.StateSebelum = StateSebelum ;
                this.StateSetelah = StateSetelah ;
                this.AksiKarakter = AksiKarakter ;
            }

        }

        Transisi[] daftarState =
        {
            new Transisi(KarakterState.Berdiri, KarakterState.Terbang, TombolAksi.TombolW),
            new Transisi(KarakterState.Berdiri, KarakterState.Jongkok, TombolAksi.TombolS),
            new Transisi(KarakterState.Terbang, KarakterState.Berdiri, TombolAksi.TombolS),
            new Transisi(KarakterState.Terbang, KarakterState.Jongkok, TombolAksi.TombolX),
            new Transisi(KarakterState.Jongkok, KarakterState.Berdiri, TombolAksi.TombolW),
            new Transisi(KarakterState.Jongkok, KarakterState.Tengkurap, TombolAksi.TombolS),
            new Transisi(KarakterState.Tengkurap, KarakterState.Terbang, TombolAksi.TombolW)
        };

        public KarakterState KarakterSaatIni = KarakterState.Berdiri;

        public KarakterState changeState(KarakterState statusKarakter, TombolAksi tombolTekan)
        {
            KarakterState nextState = statusKarakter;

            for(int i = 0; i < daftarState.Length; i++)
            {
                if(daftarState[i].StateSebelum == statusKarakter && daftarState[i].AksiKarakter == tombolTekan)
                {
                    nextState = daftarState[i].StateSetelah;
                }
            }
            return nextState;
        }

        public void TombolDitekan(TombolAksi tombol)
        {
            KarakterState saat_ini = changeState(KarakterSaatIni, tombol);
            KarakterSaatIni = saat_ini;
            //1302204080 % 3 = 2
            if(tombol == TombolAksi.TombolX && KarakterSaatIni == KarakterState.Jongkok)
            {
                Console.WriteLine("Posisi Landing");
            } else if(tombol == TombolAksi.TombolW && KarakterSaatIni == KarakterState.Terbang)
            {
                Console.WriteLine("Posisi Take Off");
            }
        }

        public PosisiKarakterGame()
        {
        }
    }
}
