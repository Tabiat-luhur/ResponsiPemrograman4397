using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResposiPemrograman4397
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan farhan = new Karyawan();
            Karyawan purnama = new Karyawan();

           
            farhan.Nik = 121212134;         
            farhan.Nama = "Farhan ";
            farhan.GajiBulanan = 3000000;

            purnama.Nik = 134567890;
            purnama.Nama = "Purnama";
            purnama.GajiBulanan = 2000000;

            Console.WriteLine("Nik Nama                    Gaji Bulanan");
            Console.WriteLine("-------------------------------------------");
            farhan.gajiawal();
            purnama.gajiawal();

            Console.WriteLine("\nAsyiiiik kenaikan gaji 10%\n\n");

            Console.WriteLine("Nik Nama                    Gaji Bulanan");
            Console.WriteLine("-------------------------------------------");
            farhan.gajiakhir();
            purnama.gajiakhir();

            Console.ReadKey();
        }
    }
}
