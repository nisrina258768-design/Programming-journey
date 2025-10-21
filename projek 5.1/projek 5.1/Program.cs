using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projek_5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Membuat array dengan 5 elemen tipe data string
            string[] siswa = new string[5];

            //Mengisi elemen Array
            siswa[0] = "Nisrina";
            siswa[1] = "Agda";
            siswa[2] = "Ayu";
            siswa[3] = "Intan";
            siswa[4] = "Kirana";

            //Menampilkan isi Array tanpa perulangan
            Console.WriteLine("Daftar nama siswa: ");
            Console.WriteLine("Siswa ke-1: " + siswa[0]);
            Console.WriteLine("Siswa ke-2: " + siswa[1]);
            Console.WriteLine("Siswa ke-3: " + siswa[2]);
            Console.WriteLine("Siswa ke-4: " + siswa[3]);
            Console.WriteLine("Siswa ke-5: " + siswa[4]);
    
        }
    }
}
