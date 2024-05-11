using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_cozum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             kullanıcıdan alınan cinsiyet bilgisine göre (E,e,K,k,Kadın,kadın);
             kullanıcının maaşı istenecek, yaşı istenecek, çalıştığı gün sayısı istenecek.
             eğer erkek ise =>
                eğer yaşı 60'ın üzerinde ise maaşının 10 katı ikaramiye verilerek emekli edilecek ve emekli oldunuz şu kadar ikramiye aldınız mesajı verilecek.
                eğer yaşı 60'ın altında ise çalıştığı gün sayısı 6000'in üstünde ise maaşının 11 katı verilecek emekli edilecek ve emekli oldunuz şu kadar ikramiye aldınız mesajı verilecek.
                eğer yaşı 60'ın altında ve çalıştığı gün sayısı 6000'in altında ise emekli olamadınız mesajı verilecek.
             eğer kadın ise =>
                eğer yaşı 55'ın üzerinde ise maaşının 10 katı ikaramiye verilerek emekli edilecek ve emekli oldunuz şu kadar ikramiye aldınız mesajı verilecek.
                eğer yaşı 55'ın altında ise çalıştığı gün sayısı 5000'in üstünde ise maaşının 11 katı verilecek emekli edilecek ve emekli oldunuz şu kadar ikramiye aldınız mesajı verilecek.
                eğer yaşı 55'ın altında ve çalıştığı gün sayısı 5000'in altında ise emekli olamadınız mesajı verilecek.

             */
            // switch case => cinsiyet kontrolü
            // if ler => yaş ve gün sayısı kontrolü
            // try catch => hata ayıklama
            Basla:
            try
            {
                Console.WriteLine("Lütfen Cinsiyet bilginizi giriniz: (E,e,Kadın,k)");
                string cinsiyet = Console.ReadLine().ToLower();
                Console.WriteLine("Lütfen Maaşınızı giriniz:");
                int maas = int.Parse(Console.ReadLine());
                Console.WriteLine("Lütfen Yaşınızı giriniz:");
                int yas = int.Parse(Console.ReadLine());
                Console.WriteLine("Lütfen Çalıştığınız Gün Sayısını giriniz:");
                int gun = int.Parse(Console.ReadLine());

                switch (cinsiyet)
                {
                    case "erkek": // cinsiyet kontrolü
                    case "e":
                        if (yas >= 60)  //yaşın 60 ve 60 tan büyük olma durumu
                        {
                            Console.WriteLine("Tebrikler maaşınızın 10 katını alarak emekli oldunuz. İkramiyeniz: {0}",maas * 10);
                        }
                        else //yaşın 60 tan küçük olma durumu
                        {
                            if(gun >= 6000) //çalıştığı gün sayısı 6000 ve 6000 den büyük olma durumu
                            {
                                Console.WriteLine("Tebrikler maaşınızın 11 katını alarak emekli oldunuz. İkramiyeniz: {0}", maas * 11);
                            }
                            else
                            {
                                Console.WriteLine("Üzgünüm emekli olamadınız.");
                            }
                        }
                    break;
                    case "kadın":
                    case "k":
                        if (yas >= 55)  //yaşın 55 ve 55 tan büyük olma durumu
                        {
                            Console.WriteLine("Tebrikler maaşınızın 10 katını alarak emekli oldunuz. İkramiyeniz: {0}", maas * 10);
                        }
                        else //yaşın 55 tan küçük olma durumu
                        {
                            if (gun >= 5000) //çalıştığı gün sayısı 5000 ve 5000 den büyük olma durumu
                            {
                                Console.WriteLine("Tebrikler maaşınızın 11 katını alarak emekli oldunuz. İkramiyeniz: {0}", maas * 11);
                            }
                            else
                            {
                                Console.WriteLine("Üzgünüm emekli olamadınız.");
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Lütfen uygun bir cinsiyet değeri giriniz");
                        goto Basla;
                    break;
                }


            }
            catch (Exception)
            {
                Console.WriteLine("Hata oluştu lütfen tekrar deneyiniz.");
                goto Basla;
            }

            Console.ReadLine();

        }
    }
}
