using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleUygulamalari_ikiSayininToplami
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, toplam;
            Console.Write("1. Sayı girin:");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayiyi Girin: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            toplam = sayi1 + sayi2;
            Console.WriteLine("{0} + {1} = {2}", sayi1,sayi2,toplam);
            Console.ReadKey();
        }
    }
}
