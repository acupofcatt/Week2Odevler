using System;

namespace Tatil
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. kullanıcıdan lokasyon iste
            //2. kullanıcıdan kaç kişi olduklarını iste
            //3. kişi ve lokasyon yazdırıp özet çıkar
            //4. hava yolu kara yolu
            //5. fiyat hesaplayıp çıktı ver.
            //6. tekrar ister mi diye sor
            //.6.1 tekrar istemezse iyi günler de
            // 6.2 tekrar isterse başa dön

            string roadOption;
            string loc;
            string sum;
            string? answer;
            do
            {
                int total = 0;
                int locPrice = TravelLocation();
                int number = NumberOfPersons();

                //Kullanıcıya seçtiği lokasyonla ilgili bilgi vermek için atamalar
                if (locPrice == 4000)
                {
                    loc = "Bodrum";
                    sum =
                        "Bodrum’da denize girin, tarihi yerleri keşfedin, tekne turlarına katılın, gece hayatını deneyimleyin ve Ege mutfağının tadını çıkarın.";
                }
                else if (locPrice == 3000)
                {
                    loc = "Marmaris";
                    sum =
                        "Marmaris’te denize girin, doğa yürüyüşlerine çıkın, tekne turlarıyla koyları keşfedin, su sporlarına katılın ve sahil restoranlarında lezzetli deniz ürünleri yiyin.";
                }
                else
                {
                    loc = "Çeşme";
                    sum =
                        "Çeşme’de plajlarda denize girin, Alaçatı sokaklarını keşfedin, rüzgar sörfü yapın, termal suların tadını çıkarın ve Ege mutfağının lezzetlerini deneyin.";
                }

                Console.WriteLine($"Tatile {number} kişi {loc} lokasyonuna gideceksiniz.\n {sum}");

                int optionPrice = RoadOption();


                if (optionPrice == 1500)    //çıktıda hangi seçimi yaptığını vermek için yeni atama yaptım
                {
                    roadOption = "Kara Yolu";
                }
                else
                {
                    roadOption = "Hava Yolu";
                }


                total = number * (optionPrice + locPrice);  //toplam fiyatı hesaplama

                Console.WriteLine($"{loc} lokasyonu için {number} kişi için {roadOption} fiyatı: {total}");

                Console.WriteLine("Başka bir tatil planlamak ister misiniz? Evet veya hayır seçiniz.");

                answer = Console.ReadLine();

                if (string.IsNullOrEmpty(answer)) //kullanıcının null değer girmesi durumunda başa dönmemek için cevabını hayır kabul ettim
                {
                    answer = "HAYIR";
                }
                
                answer = answer.ToUpper();

                if (answer != "EVET")   //farklı ifadelerde başa dönmemesi için evet harici verilen her cevabı hayır kabul ettim
                {
                    Console.WriteLine("İyi günler dileriz.");  
                       
                }
            } while (answer == "EVET"); //cevap evet olduğu sürece döngüde kal
        }

        private static int TravelLocation() //Lokasyon belirlediğimiz fonksiyon
        {
            int locPrice = 0;
            bool result = false;

            // 1. Kullanıcıya soru sor (WriteLine, Giriniz...)
            // 2. Kullanıcıdan değeri al (ReadLine)
            // 3. Null veya boş kontrolünü yap
            // 3.1 Eeğer null veya boş ise 1. adıma dön
            // 3.2 Eğer null değilse girilen cevabı kontrol et
            // 3.2.1 Eğer girilen cevap geçerli değilse 1. adıma dön
            // 3.2.2 Eğer girilen cevap geçerli ise cevabı geri dön ve döngüyü sonlandır

            do
            {
                Console.Write("Lütfen gitmek istediğiniz lokasyonu seçiniz: (Bodrum, Marmaris, Çeşme): ");
                string? loc = Console.ReadLine();


                if (string.IsNullOrEmpty(loc)) //kullanıcının null değer girmesi durumunda uyarı oluşturdum
                {
                    Console.WriteLine("Lütfen birini seçiniz: Bodrum, Marmaris, Çeşme");
                }
                else
                {
                    loc = loc.ToUpper();    //tüm harfleri büyük karakter olarak değerlendirdim

                    if (loc == "BODRUM")
                    {
                        locPrice = 4000;
                        result = true;
                    }
                    else if (loc == "MARMARİS")
                    {
                        locPrice = 3000;
                        result = true;
                    }
                    else if (loc == "ÇEŞME")
                    {
                        locPrice = 5000;
                        result = true;
                    }
                    else  //istediğim seçimlerden biri değilse hata ver
                    {
                        Console.WriteLine("Lütfen birini seçiniz: Bodrum, Marmaris, Çeşme");
                    }
                }
            } while (!result);  //sonuç false olduğu sürece döngüde kal


            return locPrice;
        }

        private static int NumberOfPersons()    //Kaç kişi oladuklarını belirlediğimiz fonksiyon
        {
            // 1.Kullanıcıdn değer iste
            // 2. Kullanıcıdan değeri al
            // 3.Aldığın değere null or empty kontrolü yap
            // 3.1. Eğer null veya empty ise başa dön
            // 3.2. Eğer null veya empty değilse int kontrolü yap
            // 3.2.1. Eğer int değilse başa dön
            // 3.2.2 Eğer int ise döngüyü sonlandır ve değeri geri dön
            int number = 0;

            string? person;
            do
            {
                Console.WriteLine("Tatile kaç kişi gideceksiniz?");
                person = Console.ReadLine(); // Kullanıcıdan string olarak veri alır

                if (string.IsNullOrEmpty(person)) //kullanıcının null değer girmesi durumunda uyarı oluşturdum
                {
                    Console.WriteLine("Lütfen geçerli bir sayı değeri giriniz.");
                }
                else if (!int.TryParse(person, out number)) //int dönüşümü kontrolü
                {
                    Console.WriteLine("Geçersiz giriş! Lütfen bir tam sayı girin."); //int olmadıysa hata ver
                }
            } while (number <= 0); //değer 0'dsn büyük bir değer olmadığı sürece döngüyü devam ettirir


            return number;
        }

        private static int RoadOption() //yol tercihi belirlenen fonksiyon
        {
            //1. Kullanıcıdan değer iste
            //2. O değeri al
            //3. null or empty kontrol
            //3.1 nullsa başa dön
            //3.2 null değilse integer kontrolü yap
            //3.2.1 integer değilse başa dön
            //3.2.2 integersa 1 mi 2 mi kkontrolü yap
            //3.2.2.1 1 veya 2 değilse başa dön
            //3.2.2.2 1 veya 2 ise bitir
            
            int option = 0;
            int optionPrice = 0;

            string? road;
            do
            {
                Console.WriteLine(
                    "Kara yolu ile gitmek istiyorsanız 1 Hava yolu ile gitmek istiyorsanız 2 yazınız.");

                road = Console.ReadLine(); // Kullanıcıdan string olarak veri alır

                if (string.IsNullOrEmpty(road)) //kullanıcının null değer girmesi durumunda uyarı oluşturdum
                {
                    Console.WriteLine("Lütfen geçerli bir sayı değeri giriniz.");
                }
                else if (!int.TryParse(road, out option))   //veri int oluyor mu kontrol
                {
                    Console.WriteLine("Geçersiz giriş! Lütfen 1 veya 2 girin."); //int olmuyorsa hata
                }
                else //int oluyorsa döngüye gir
                {
                    option = int.Parse(road);
                    switch (option)
                    {
                        case 1: //kara yolu seçildi

                            optionPrice = 1500; 
                            break;

                        case 2: //hava yolu seçildi

                            optionPrice = 4000;
                            break;

                        default:

                            Console.WriteLine("Lütfen kara yolu için 1 hava yolu için 2 seçiniz.");
                            break;
                    }
                }
            } while (!((option == 1) || (option == 2))); //değer bir veya iki olmadığı sürece döngüyü devam ettirir

            return optionPrice;
        }
    }
}