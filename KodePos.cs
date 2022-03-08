using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul3_1302204051
{
    internal class KodePos
    {
        public enum Kelurahan { Batununggal, Kujangsari, Mengger, Wates, Cijaura, Jatisari, Margasari, Sekejati, Kebonwaru, Maleer, Samoja};
        public String getKodePos(Kelurahan kelurahan)
        {
            String[] kodePos = { "40266", "40287", "40267", "40256", "40287", "40286", "40286", "40286", "40272", "40274", "40273" };

            return kodePos[(int) kelurahan];
        }
    }
}
