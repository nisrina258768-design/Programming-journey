using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas2_fungsi
{
    internal class Program
    {
        // Fungsi rata-rata tiga nilai
        static double RataRata(double a, double b, double c)
        {
            double hasil = (a + b + c) / 3;
            return hasil; // Mengembalikan nilai

        }

        static void Main(string[] args)
        {
            Console.Write("Masukkan nilai pertama: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Masukkan nilai kedua: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Masukkan nilai ketiga: ");
            double c = double.Parse(Console.ReadLine());

            // Panggil fungsi
            double hasilRata = RataRata(a, b, c);

            // Tampilkan hasil
            Console.WriteLine("Hasil rata-rata: " + hasilRata);
        }
    }
}
