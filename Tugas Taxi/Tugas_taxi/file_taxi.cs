using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_taxi
{
    class File_taxi
    {
        public string Nama_Driver { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        public void info()
        {
            Console.WriteLine($"Driver Name : {Nama_Driver}");

            if (OnDuty) Console.WriteLine($"On Duty     : Yes");
            else Console.WriteLine($"On Duty     : No");

            Console.WriteLine($"Number Of Passengers : {NumPassenger}");
            Console.WriteLine();
        }

        public void naik()
        {
            Console.WriteLine($"{Nama_Driver} sedang menjemput penumpang");
        }

        public void turun()
        {
            Console.WriteLine($"{Nama_Driver} selesai mengantar penumpang");
        }
    }
}
