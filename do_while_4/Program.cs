using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullanıcıdan alınacak ürün sayısına göre her bir ürünün fiyatını isteyeceğiz ve 0 a basıp fiyatlar alındıktan sonra  girilen tüm fiyatlarını toplamını göstereceğiz.

            int urunSayisi = 0;

            while (true)
            {
                try
                {
                    Console.WriteLine("Ürün sayısını giriniz");
                    urunSayisi = int.Parse(Console.ReadLine());
                    if(urunSayisi > 0)
                    {
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Lütfen ürün sayısını düzgün girin.");
                }
            }

            double toplam = 0, sayac = 0;

            do
            {
                try
                {
                    Console.WriteLine("{0}. ürünün fiyatını giriniz",sayac+1);
                    double fiyat = Convert.ToDouble(Console.ReadLine());
                    toplam += fiyat;
                    urunSayisi--;
                    sayac++;
                }
                catch (Exception)
                {
                    Console.WriteLine("Hata oluştu!");
                }
            } while (urunSayisi>0);

            Console.WriteLine("Girilen {0} adet ürünün toplam fiyatı {1} TL",sayac,toplam);
            Console.WriteLine("********************************************************");
            Console.ReadLine();
        }
    }
}
