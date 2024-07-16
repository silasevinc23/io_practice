// See https://aka.ms/new-console-template for more information

using System;

namespace kullbig
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen aşağıdaki bilgileri giriniz:");

            Console.Write("T.C Kimlik Numarası:"); //T.C Kimlik Numarası: yazısından sonra alt satıra geçmeden olduğu satırdan input alabilmesi için Console.WriteLine() yerine Console.Write() kullandım.
            string kimlikno = Console.ReadLine();
            Console.Write("Adı:");
            string ad = Console.ReadLine();
            Console.Write("Soyadı:");
            string soyad = Console.ReadLine();
            Console.Write("Telefon numarası:"); 
            string tlfno = Console.ReadLine();//Telefon numarası ile herhangi bir sayısal işlem yapılmadığından string olarak aldım.
            Console.Write("Yas:");
            string yas = Console.ReadLine();
            Console.Write("İlk aldığı ürünün fiyatı:");
            int ilk = Convert.ToInt32(Console.ReadLine());// Aşağıda sayısal işlem yapılacağı için int tipinde aldım.
            Console.Write("İkinci aldığı ürünün fiyatı:");
            int ikinci = Convert.ToInt32(Console.ReadLine());// Aşağıda sayısal işlem yapılacağı için int tipinde aldım.
            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine($"{ kimlikno} Tc numaralı {ad} {soyad} isimli kişi için kayıt oluşturulmuştur.  ");
            Console.WriteLine($"{ tlfno} telefon numarasına bildirim mesajı gönderilmiştir.  ");
            Console.WriteLine((ilk+ikinci)+ " toplam harcama karşılığı kazanılan %10 patika puan miktarı -> "+ (ilk + ikinci) * 0.1 +"TL'dir."     );




        }
    }
}

