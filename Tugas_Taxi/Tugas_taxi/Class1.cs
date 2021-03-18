using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_taxi
{
    class Class1
    {
        public string NamaDriver { get; set; }
        public bool Jalan { get; set; }
        public int Nomor { get; set; }

        public void info()
        {
            Console.WriteLine($"Driver Name : {NamaDriver}");

            if (Jalan) Console.WriteLine($"On Duty     : Yes");
            else Console.WriteLine($"On Duty     : No");

            Console.WriteLine($"Number Of Passengers : {Nomor}");
            Console.WriteLine();
        }

        public void naik()
        {
            Console.WriteLine($"{NamaDriver} sedang menjemput penumpang");
        }

        public void turun()
        {
            Console.WriteLine($"{NamaDriver} selesai mengantar penumpang");
        }

    }
}
