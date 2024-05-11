using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullanıcıdan aldığımız değerlerin toplamı doğum yılınızı geçene kadar toplayıp ekrana yazdırın.
            try
            {
                Console.WriteLine("Doğum tarihiniz giriniz: {01.01.1992}");
                DateTime dogumTarihi = Convert.ToDateTime(Console.ReadLine());
                int yil = dogumTarihi.Year;

                int toplam = 0 , adet = 0;

                do
                {
                    try
                    {
                        Console.WriteLine("Sayı giriniz");
                        int s1 = Convert.ToInt32(Console.ReadLine());
                        toplam += s1;
                        adet++;
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Hatalı sayı girişi");  
                    }

                } while (yil > toplam);

                Console.WriteLine("Girilen {0} adet sayını toplamı: {1}", adet, toplam);
            }
            catch (Exception)
            {

                Console.WriteLine("Doğum tarihi hatası!");
            }

            Console.ReadLine();

        }
    }
}
