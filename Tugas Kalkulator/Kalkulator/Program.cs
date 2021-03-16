using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Kalkulator";

            int selectMenu = SelectMenu();
            if (selectMenu < 1 || selectMenu > 4)
            {
                Console.WriteLine();
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                Console.WriteLine("Maaf, menu yang anda pilih tidak tersedia!");
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                ExitProgram();
            }

            Console.WriteLine();
            Console.Write("Silakan input angka yang pertama: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Silakan input angka yang kedua: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine();
            if (selectMenu == 1) Console.WriteLine($"Hasil penambahan dari {a} + {b} = {Penambahan(a, b)}");
            else if (selectMenu == 2) Console.WriteLine($"Hasil pengurangan dari {a} - {b} = {Pengurangan(a, b)}");
            else if (selectMenu == 3) Console.WriteLine($"Hasil perkalian dari {a} * {b} = {Perkalian(a, b)}");
            else Console.WriteLine($"Hasil pembagian dari {a} / {b} = {Pembagian(a, b)}");
            Console.WriteLine();
            Console.WriteLine("=================== D O N E ==================");
            ExitProgram();
        }

        static int SelectMenu()
        {
            Console.WriteLine("Silakan pilih menu yang ada di kalkulator 1-4");

            Console.WriteLine();
            Console.WriteLine("1. Operasi Penjumlahan");
            Console.WriteLine("2. Operasi pengurangan");
            Console.WriteLine("3. Operasi perkalian");
            Console.WriteLine("4. Operasi Pembagian");

            Console.WriteLine();
            Console.WriteLine("=====================================");
            Console.Write("Silakan masukan pilihan anda 1-4: ");

            return int.Parse(Console.ReadLine());
        }

        static int Penambahan(int a, int b) => a + b;
        static int Pengurangan(int a, int b) => a - b;
        static int Perkalian(int a, int b) => a * b;
        static double Pembagian(int a, int b) => (double)a / b;
        static void ExitProgram()
        {
            Console.WriteLine();
            Console.WriteLine("Pres any key to exit...");
            Console.ReadKey();

            Environment.Exit(0);
        }
    }
}

