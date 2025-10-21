using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas1_fungsi
{
    internal class Program
    {
        // Fungsi Kali tiga bilangan
        static void Kali(int a, int b, int c)
        {
            int hasil = a * b * c;
            Console.WriteLine("Hasil perkalian: " + hasil);

        }

        static void Main(string[] args)
        {
            Console.Write("Masukkan bilangan pertama: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Masukkan bilangan kedua: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Masukkan bilangan ketiga: ");
            int c = int.Parse(Console.ReadLine());

            Kali(a, b, c); // Panggil fungsi
        }
    }
}
