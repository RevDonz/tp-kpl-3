using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul3_1302204051
{

    internal class DoorMachine
    {
        public DoorState prevState;
        public DoorState nextState;
        public Trigger trigger;

        public enum DoorState { Terkunci, Terbuka };
        public enum Trigger { BukaPintu, KunciPintu };

        public DoorState currentState;

        public DoorMachine(DoorState prevState, DoorState nextState, Trigger trigger)
        {
            this.prevState = prevState;
            this.nextState = nextState;
            this.trigger = trigger;
        }

        DoorMachine[] doorMachines =
        {
            new DoorMachine(DoorState.Terbuka, DoorState.Terkunci, Trigger.KunciPintu),
            new DoorMachine(DoorState.Terkunci, DoorState.Terbuka, Trigger.BukaPintu)
        };

        public DoorState getNextState(DoorState prevState, Trigger trigger)
        {
            DoorState nextState = prevState;
            for (int i = 0; i < doorMachines.Length; i++)
            {
                if(doorMachines[i].trigger == trigger && doorMachines[i].prevState == prevState)
                {
                    nextState = doorMachines[i].nextState;
                }
            }

            return nextState;
        }

        public void activeTrigger(Trigger trigger)
        {
            DoorState nextState = getNextState(currentState, trigger);
            currentState = nextState;
            if (currentState == DoorState.Terbuka)
            {
                Console.WriteLine("Pintu tidak terkunci");
            } 
            else
            {
                Console.WriteLine("Pintu Terkunci");
            }
        }

    }
}
