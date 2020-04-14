using System;

namespace ResponsiPemrograman2742
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan1 = new Karyawan(1911, "Muhammad Ridho Herprabowo", 2000000);
            Karyawan karyawan2 = new Karyawan(2742, "Jono", 2000000);
            Karyawan karyawan3 = new Karyawan(1519, "Paijo", -100000);


            Console.WriteLine("==================================================");
            Console.WriteLine(" NO | NIK / NAMA\t\t | Gaji Bulanan\t |");
            Console.WriteLine("==================================================");
            Console.WriteLine(" 1. | {0} {1} \t\t | {2}\t |", karyawan1.NIK, karyawan1.Nama, karyawan1.GajiBulanan);
            Console.WriteLine(" 2. | {0} {1} \t\t | {2}\t |", karyawan2.NIK, karyawan2.Nama, karyawan2.GajiBulanan);
            Console.WriteLine(" 3. | {0} {1} \t\t | {2}\t\t |", karyawan3.NIK, karyawan3.Nama, karyawan3.GajiBulanan);

            Console.WriteLine("\n\Selamat anda mendapat kenaikan Gaji!!!\n");

            Console.WriteLine("==================================================");
            Console.WriteLine(" NO | NIK / NAMA\t\t | Gaji Bulanan\t |");
            Console.WriteLine("==================================================");
            Console.WriteLine(" 1. | {0} {1} \t\t | {2}\t |", karyawan1.NIK, karyawan1.Nama, karyawan1.NaikGaji);
            Console.WriteLine(" 2. | {0} {1} \t\t | {2}\t |", karyawan2.NIK, karyawan2.Nama, karyawan2.NaikGaji);
            Console.WriteLine(" 3. | {0} {1} \t\t | {2}\t\t |", karyawan3.NIK, karyawan3.Nama, karyawan3.GajiBulanan);


            Console.ReadKey();
        }
    }

}