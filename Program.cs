/*
 * 1. Program akan menerima input angka 1 sampai 9
 * 2. Program menerima input berupa angka dari user untuk dasar sebagai ukuran tinggi segitiga
 * 3. Setelah user menginput angka, kemudian inputan tersebut akan disimpan kedalam sebuah variabel dan dijadikan dasar perulangan untuk tinggi segitiga
 * 4. Setelah persyaratan terpenuhi, maka akan dilanjutkan ke langkah selanjutnya yaitu looping angka tiap baris
 * 5. Angka yang ditampikan akan sesuai dengan baris diurut dari angka baris itu sendiri(pada baris 2 akan tampil angka dari 2 1) hingga angka menjadi angka 1
 * 6. Setiap setelah menampilkan angka akan di pisahkan spasi
 * 7. Perulangan akan terus dilakukan sesuai angka yang di input oleh user
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSegitigaPascal
{
    /// <summary>
    /// name class
    /// </summary>
    class Program
    {
        /// <summary>
        /// operasi segitiga pascal
        /// </summary>
        /// <param name="args">berisi array argumen-argumen yang diberikan pengguna saat menjalankan aplikasi</param>
        static void Main(string[] args)
        {
            int n, a, b; 
            Console.Write("Jumlah baris dari angka 1 sampai 9 : ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n >= 1 && n <= 9)
            {
                Console.WriteLine(" ");
                Console.WriteLine("=====Hasil=====");
                Console.WriteLine(" ");
                for (a = 1; a <= n; a++)
                {
                    for (b = a; b >= 1; b--)
                    {
                        Console.Write(b);
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }

            else
            {
                Console.Write("Masukan angka dari 1 sampai 9 ");
            }
            Console.ReadKey();
        }
    }
}
