//  Aynı uygulama içerisinde 4 adet metot tanımlamanız ve çağırmanız isteniyor :
// 
// Geriye Değer Döndürmeyen Bir void metot.
// Ekrana sevdiğiniz bir şarkı sözünü yazdırsın. 
// 
// Geriye Tamsayı Döndüren Bir metot
// Rastgele bir sayı üretip bu sayının 2'ye bölümünden kalanı geriye döndürsün.
// 
// Parametre Alan ve Geriye Değer Döndüren Bir Metot
// Parametre olarak aldığı iki sayının çarpımını geriye dönsün.
// 
// Parametre Alan ve Geriye Değer Döndürmeyen bir Metot
// Parametre olarak isim ve soyisim bilgilerini alıp " Hoş Geldiniz {isim} {soyisim} " şeklinde ekrana bassın.

using System;

namespace MetotlarOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            SarkiSozu();
            BolumdenKalan();
            Carpim(5,7);
            Karsilama("Edip", "Akbayram");
            
        }

        private static void SarkiSozu()
        {
            Console.WriteLine("Ceza mı bu?\nÇektiğim çile mi?\nYıllardır tuttuğum nöbet bitmeyecek mi?");
        }

        private static int BolumdenKalan()
        {
            Random rand = new Random();   //RASTGELE BİR SAYI OLUŞTURMAK İÇİN

            int number = rand.Next(); 
            
            int mode = number % 2;
            
            Console.WriteLine($"{number} sayısının 2 ile bölümünden kalan: {mode}");
            
            return mode;

        }

        private static int Carpim(int x, int y)
        {
            return x * y;
        }

        private static void Karsilama(string isim, string soyisim)
        {
            Console.WriteLine($"Hoş Geldiniz {isim} {soyisim}");
        }
    }
}