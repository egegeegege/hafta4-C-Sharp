using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] iller = new string[82] {"","Adana", "Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin",
                                "Aydın", "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale",
                                "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir",
                                "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Isparta", "Mersin", "İstanbul", "İzmir",
                                "Kars", "Kastamonu", "Kayseri", "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya",
                                "Manisa", "Kahramanmaraş", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya",
                                "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa", "Uşak",
                                "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt", "Karaman", "Kırıkkale", "Batman", "Şırnak",
                                "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük", "Kilis", "Osmaniye", "Düzce"};

            Console.WriteLine("Şehir gir plaka bul");

            string sehir = Console.ReadLine();
            string bulunanSehir = "";
            foreach (var il in iller)
            {
                if(il.ToLower() == sehir.ToLower())
                {
                    bulunanSehir = il;
                }
            }
            int plaka = Array.IndexOf(iller,bulunanSehir);
            if (plaka <= 0)
            {
                Console.WriteLine("Aradığınız şehir yok!");
            }
            else
            {
                if (plaka < 10)
                {
                    Console.WriteLine("0"+plaka);
                }
                else
                {
                    Console.WriteLine(plaka);
                }

            }

            Console.ReadLine();
        }
    }
}
