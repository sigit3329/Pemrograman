using System;

namespace ResponsiPemrograman2684
{
    class Program
    {
        public class Karyawan
        {
            public int identitas;
            public string nama;
            public int gaji;
            public Karyawan(int nik, string name, int gajibulanan)
            {

                identitas = nik;
                nama = name;
                gaji = gajibulanan;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("NO" + " NIK/NAMA" + "         " + "Gaji Bulanan");
            Karyawan karyawan1 = new Karyawan(19112684, "Gafi", 3000000);
            Karyawan karyawan2 = new Karyawan(17111919, "Ghema", 2000000);
            Console.WriteLine("1." + karyawan1.identitas + " " + karyawan1.nama + "     " + karyawan1.gaji);
            Console.WriteLine("2." + karyawan2.identitas + " " + karyawan2.nama + "    " + karyawan2.gaji);
            if (karyawan1.gaji <= 0 || karyawan2.gaji <= 0)
            {
                Console.WriteLine("Anda memasukkan gaji minus");
                karyawan1.gaji = 0;
                karyawan2.gaji = 0;
                Console.WriteLine("1." + karyawan1.identitas + " " + karyawan1.nama + "     " + karyawan1.gaji);
                Console.WriteLine("2." + karyawan2.identitas + " " + karyawan2.nama + "    " + karyawan2.gaji);
            }
            else
            {
                Console.WriteLine("Asyiiiiik kenaikan gaji 10%!!");
                int tambah = karyawan1.gaji * 10 / 100;
                karyawan1.gaji += tambah;
                int tambah1 = karyawan2.gaji * 10 / 100;
                karyawan2.gaji += tambah1;
                Console.WriteLine("1." + karyawan1.identitas + " " + karyawan1.nama + "     " + karyawan1.gaji);
                Console.WriteLine("2." + karyawan2.identitas + " " + karyawan2.nama + "    " + karyawan2.gaji);
            }

        }
    }
}