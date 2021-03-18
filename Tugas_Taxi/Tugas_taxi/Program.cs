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
            Class1 taxi = new Class1{
                NamaDriver = "Jono",
                Jalan = true,
                Nomor = 10
            };

            taxi.info();//memanggil void info yg ada di Class1.cs
            taxi.naik();
            taxi.turun();

            Console.ReadKey();

        }
    }
}
