using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = " tempat barang barang di toko sembako";

            Console.WriteLine("1. Gula");
            Console.WriteLine("2. Garam");
            Console.WriteLine("3. Beras");

            Console.Write("Masukan Pilihan [1, 2, 3 ]: ");
            
            int Pilihan = Int32.Parse(Console.ReadLine());


            if (Pilihan == 1)
            {
                Gula gula = new Gula();
                gula.Tempat();
            }
            
            else if (Pilihan == 2)
            {
                Garam garam = new Garam();
                garam.Tempat();
            }
            
            else if (Pilihan == 3)
            {
                Beras beras = new Beras();
                beras.Tempat();
            }
            else
            {
                Console.WriteLine("Maaf Pilihan Anda Tidak Ada");
            }

            Console.WriteLine("\n Tekan Sembarang Key untuk keluar");
            Console.ReadKey();


        }
    }
}
