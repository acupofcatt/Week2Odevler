//Kullanıcının girdiği bir limit değerine kadar 0'dan bir sayaç çalıştırıp artırarak, ekrana " Ben bir Patika'lıyım " yazdırınız.
// 
// ( Sayacınız 0'dan başlayarak 1'er 1'er artacak, koşulunuz ( Sayac <= Limit ) )

using System;

namespace WhileDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            ByWhile();  //sayac = 0 değerinde yazdırmaya başlayıp sayac = limit değerinde son yazdırmasını yapacak 
            ByDoWhile(); //sayac = 1 değerinde yazdırmaya başlayıp sayac = limit +1 değerinde son yazdırmasını yapacak 
        }

        private static void ByDoWhile()
        {
            int sayac = 0;
            int limit = LimitDeger() - 1; //kural sayac=0 dan başlayıp sayac <= limit şartını sağlayana kadar devam edeceğinden kullanıcının girdiğinden 1 fazla döngü oluşacak. bunu engellemek içn -1 yaptım

            do
            {
                Console.WriteLine("Ben bir Patikalıyım");   //sayac kontrolü yapmadan ilk kez yazdırıp sonra devam ettirecek, ilk kez yazdırdığında sayac = 1
                sayac++;                                    //yazdırdıktan sonra sayac dğerini bir artıracak

            } while (sayac <= limit);   //sayac kontrolü yapıp kural sağlanıyorsa döngüde kalacak
                                        //burada son yazdırmasını aslında sayac = limit + 1 değerinde olduğunda yapıp kontrolü sonra sağlayacak.
                                        //limit değeri 3se sayac 4 olduğunda son yazdırmasını yapıp kontrol edecek koşul sağlanmadığı için döngüden çıkacak
            
        }
        private static void ByWhile()
        {
            
            int limit = LimitDeger() - 1; //kural sayac=0 dan başlayıp sayac <= limit şartını sağlayana kadar devam edeceğinden kullanıcının girdiğinden 1 fazla döngü oluşacak. bunu engellemek içn -1 yaptım
            
            int sayac = 0;
            
                while (sayac <= limit)  //önce sayac kontrolü yapıp şartlar sağlanıyorsa çıktı yazdıracak. şartlar sağlanmadığı noktada döngüyü sonlandıracak
                {
                    Console.WriteLine("Ben bir Patikalıyım");  //ilk yazdırması sayac = 0 değerinde, son yazdırması sayac = limit değeinde
                    sayac++;                                    //sayaç birer artarak döngüyü devam ettirecek
                }
                


        }

        private static int LimitDeger()
        {

            int limit = 0;

            string? input;
            do

            {
                Console.Write("Lütfen kaç kez yazdırmak istediğinizi giriniz: ");
                input = Console.ReadLine(); // Kullanıcıdan string olarak veri alır

                if (string.IsNullOrEmpty(input)) //kullanıcının null değer girmesi durumunda uyarı oluşturdum
                {
                    Console.WriteLine("Lütfen geçerli bir tamsayı değeri giriniz.");
                }
                else if (!int.TryParse(input, out limit)) //int dönüşümü kontrolü
                {
                    Console.WriteLine("Lütfen geçerli bir tamsayı değeri giriniz."); //int olmadıysa hata ver
                }
              
            } while (limit <= 0); //değer 0'dsn büyük bir değer olmadığı sürece döngüyü devam ettirir

            return limit;
        }

    }
}