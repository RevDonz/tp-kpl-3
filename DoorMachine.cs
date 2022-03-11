using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul3_1302204051
{
    internal class DoorMachine
    {
        public enum DoorState { Terkunci, Terbuka };
        public enum Trigger { BukaPintu, KunciPintu };

        public class Transisi
        {
            public DoorState prevState;
            public DoorState nextState;
            public Trigger trigger;

            public Transisi(DoorState prev, DoorState next, Trigger aksi)
            {
                this.prevState = prev;
                this.nextState = next;
                this.trigger = aksi;
            }
        }

        Transisi[] listPerpindahan =
        {
            new Transisi(DoorState.Terbuka, DoorState.Terkunci, Trigger.KunciPintu),
            new Transisi(DoorState.Terkunci, DoorState.Terbuka, Trigger.BukaPintu)
        };

        public DoorState CurrentState= DoorState.Terkunci;

        public DoorState getNextState(DoorState prev, Trigger aksi)
        {
            DoorState StateAkhir = prev;

            for (int i = 0; i < listPerpindahan.Length; i++)
            {
                DoorState StateAwal = listPerpindahan[i].prevState;
                Trigger aksiState = listPerpindahan[i].trigger;

                if (StateAwal == prev && aksiState == aksi)
                {
                    StateAkhir = listPerpindahan[i].nextState;
                }
            }

            return StateAkhir;
        }

        public void activateTrigger(Trigger trigger)
        {
            CurrentState = getNextState(CurrentState, trigger);

            if (CurrentState == DoorState.Terkunci)
            {
                Console.WriteLine("Pintu terkunci");
            } else
            {
                Console.WriteLine("Pintu tidak terkunci");
            }
        }

        public DoorMachine()
        {

        }
    }
}
