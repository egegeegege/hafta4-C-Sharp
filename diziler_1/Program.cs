using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Diziler (Arrays)
            /* 
             String ifadeler aslında birer dizidir.
             Diziler birden çok yapıyı içinde barındıran koleksiyon yapılarıdır.
             Dizileri tanımlarken içinde olacak eleman sayısını belirttiğimiz yada belirtmediğimiz durumlar olabilir.
             Dizinin her bir elemanı bir index numarasına sahiptir. ve bu index numaraları otomatik olarak verilir ve 0 dan başlar.
             Diziler data protected yapıdadır ve içinde olacak elemanlara göre tip verilir.

             Yapı => int[] diziAdi = new int[5] => 5 elemanlı int bir dizi oluşturur.
             string[] diziAdi = new string[5]            
             
             
             */

            int[] dizi = new int[5];

            Console.WriteLine(dizi); // array (dizi) yada collection yapılarının tamamı ekranda gösterilmez.

            Console.WriteLine(dizi[2]);  // eğer diziye bir eleman ataması yapılmaz ise dizi elamanı default değer alır.

            //Console.WriteLine(dizi[5]);  // dizi sınırlarının dışında bir işlem yaparsak hata verir!
            dizi[0] = 10;
            dizi[1] = 20;
            dizi[2] = 30;
            dizi[3] = 40;
            dizi[4] = 50;
            // dizi[5] = 60; // dizi sınırlanının dışında bir eleman ataması yapılamaz.
            Console.WriteLine(dizi[1]);

            // dizi oluşturulurken eleman sayısı belirtilmeden ve değer set ederek oluşturulabilir.

            int[] deger = { 4, 5, 8, 3, 6, 7, 5, 7, 5, 7,6,8,2 };

            Console.WriteLine(deger); // dizinin tamamı gösterilmez !!

            Console.WriteLine("Dizi uzunluğu: {0}",deger.Length);

            Console.WriteLine("For ile Dizi");
            for (int i = 0; i < deger.Length; i++)
            {
                Console.WriteLine(deger[i]);
            }

            Console.WriteLine("While ile Dizi");
            int a = 0;
            while (a<deger.Length)
            {
                Console.WriteLine(deger[a]);
                a++;
            }

            // foreach
            Console.WriteLine("Foreach ile Dizi");

            foreach (int eleman in deger)
            {
                Console.WriteLine(eleman);
            }

            string[] isimler = new string[3];
            isimler[0] = "Eda";
            isimler[1] = "Yakup";
            isimler[2] = "Kerem";

            foreach (var isim in isimler)
            {
                Console.WriteLine(isim);
            }

            string[] okullar = { "İTÜ", "ODTÜ", "BOĞAZİÇİ" };

            Console.WriteLine(okullar[1]);

            foreach (var item in okullar)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
