using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaktoriyelÖdev
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, sonuc;
            string g;

            Console.WriteLine("Faktöriyeli alınacak pozitif bir tam sayıyı giriniz (q: çıkış):");
            g = Console.ReadLine();

            while (g != "q")
            {
                sonuc = 1;
                a = Convert.ToInt32(g);
                if (a == 0 || a > 0)
                {
                    for (int i = 1; i <= a; i++)
                    {
                        sonuc = i * sonuc;
                    }

                    Console.WriteLine("Sonuç: " + sonuc);

                }
                else
                {
                    Console.WriteLine("Lütfen pozitif bir değer giriniz");
                }

                Console.WriteLine("Faktöriyeli alınacak pozitif bir tam sayıyı giriniz (q: çıkış):");
                g = Console.ReadLine();
            }




        }
    }
}
