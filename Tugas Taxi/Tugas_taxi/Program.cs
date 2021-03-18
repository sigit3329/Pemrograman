using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            File_taxi taxi = new File_taxi
            {
                Nama_Driver = "Jono",
                OnDuty = true,
                NumPassenger = 10
            };

            taxi.info();
            taxi.naik();//memanggil void naik yg ada di file_taxi.cs
            taxi.turun();

            Console.ReadKey();
        }
    }
}
