// See https://aka.ms/new-console-template for more information
using System;
namespace tpmodul3_1302204051;

class MainClass
{
    static void Main(string[] args)
    {
        System.Console.WriteLine(KodePos.getKodePos(KodePos.Kelurahan.Batununggal) + "\n");

        DoorMachine mesin1 = new DoorMachine();
        Console.WriteLine("State Saat ini : " + mesin1.CurrentState);
        mesin1.activateTrigger(DoorMachine.Trigger.BukaPintu);
    }
}
