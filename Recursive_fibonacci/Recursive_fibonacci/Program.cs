using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {

            Stopwatch sw = new Stopwatch(); // kodun çalışma süresini öğrenebilmek için stopwatch fonksiyonu kullanıldı.
            Console.WriteLine("Kaçıncı fibonacci sayısı:");
            int x = Convert.ToInt32(Console.ReadLine()); // bulunmak istenen sayı öğrenilip x'e atandı.

            sw.Start(); // süre başlatıldı.
            Console.WriteLine("{0}. fibonacci sayısı:", x);
            Console.Write(Fib(x)); // fibonacci sayısı bulundu
            sw.Stop(); // süre durduruldu

            TimeSpan toplamSure = sw.Elapsed; //  süre değerine erişimi sağlayabilmek için timespan yapısı kullanıldı.
            string sure = String.Format("{0}:{1}:{2}.{3}", toplamSure.Hours, toplamSure.Minutes, toplamSure.Seconds, toplamSure.TotalMilliseconds * 1000000);// süre bulunuldu.

            Console.WriteLine();
            Console.WriteLine("Toplam Süre:" + sure); // ekrana yazdırıldı.
            Console.ReadLine(); // sure yi ekranda görebilmek için yazıldı.
        }

        public static int Fib(int a)
        {
            if (a == 0 | a == 1)
            {
                return 1;
            }
            else
            {
                return (Fib(a - 1) + Fib(a - 2));
            }

        }
    }
}
 