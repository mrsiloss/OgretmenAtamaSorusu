using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgretmenAtamaSorusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi, sayii, x;
            string[] il = { "Muş", "Ağrı", "Bolu", "Mersin", "Ankara", "Sivas", "Kayseri" };
            string[] isim = { "Asuman", "İclal", "Emin", "Bekir", "Ahmet", "Can", "Esma" };
            bool[] D = new bool[7];
            bool[] D1 = new bool[7];

            for (x = 0; x <= 6; x++)

            {
                Console.WriteLine("Bool D dizisinin  " + x + ". elemanı= " + D[x]);
                Console.WriteLine("Bool D1 dizisinin " + x + ". elemanı= " + D1[x]);
            }
            Random rastgele = new Random();


            for (x = 0; x <= 6; x++)
            {



                do
                { //bu döngü ve d[sayi]=true satırı ile bir şehire birden fazla öğretmen atanması engelleniyor.
                    sayi = rastgele.Next(0, 7);//sıfır dahil, 7 dahil değil.

                } while (D[sayi] == true);
                D[sayi] = true;

                do
                { //bu döngü ve d[sayi]=true satırı ile bir şehire birden fazla öğretmen atanması engelleniyor.

                    sayii = rastgele.Next(0, 7);

                } while (D1[sayii] == true);
                D1[sayii] = true;



                Console.WriteLine(isim[sayii] + "\t= " + il[sayi]);

            }
            for (x= 0; x <= 6; x++)
            {
                Console.WriteLine("Bool D dizisinin  " + x + ". elemanı= " + D[x]);
                Console.WriteLine("Bool D1 dizisinin " + x + ". elemanı= " + D1[x]);
            }
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
