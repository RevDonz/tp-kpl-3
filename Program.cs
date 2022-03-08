// See https://aka.ms/new-console-template for more information
using System;
namespace tpmodul3_1302204051;

class MainClass
{
    static void Main(string[] args)
    {
        // Display the number of command line arguments.
        KodePos kode = new KodePos();
        Console.WriteLine(kode.getKodePos(KodePos.Kelurahan.Batununggal));
    }
}
