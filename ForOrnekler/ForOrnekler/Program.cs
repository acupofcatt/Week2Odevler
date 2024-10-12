/*1 -> Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.

2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.

3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.

4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.

5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
*/


using System; 
   
   namespace ForOrnek
   {
       class Program
       {
           static void Main(string[] args)
           {
  //SORU 1
               
               for (int i = 1; i <= 10; i++)    //koşulu 1'den başlatıp 10'a eşit olana kadar sağlattım

               {
                   Console.WriteLine($"{i} Kendime inanıyorum, ben bu yazılım işini hallederim!"); //1'den 10'a kadar yazdığını görmek için sayıları da ekledim
               }
               
         

 //SORU 2  

       for (int i = 1; i <= 20; i++)    //koşulu 1'den başlatıp 20'ye eşit olana kadar birer artırmasını sağlattım

       {
           Console.WriteLine(i); //sayıların her değerini ekrana yansıtıyor
       }       
   
 //SORU 3
       
       for (int i = 2; i <= 20; i += 2)    //koşulu 1'den başlatıp 20'ye eşit olana kadar birer artırmasını sağlattım

       {
           Console.WriteLine(i); //sayıların her değerini ekrana yansıtıyor
       }       

//SORU 4
        
       int toplam = 0;
       for (int i = 50; i <= 150; i++)  //i 50den başlayıp 150'ye kadar devam edecek
       {
           toplam += i; //döngüdeki her sayıyı toplam değerine ekliyor
       }
       
       Console.WriteLine("50 ile 150 arasındaki sayıların toplamı " + toplam);
     
//SORU 5
        int tekToplam = 0;
        int ciftToplam = 0;
        
        for (int i = 1; i <= 120; i++)
        {
            if (i % 2 != 0) //teklik kontrolü
            {
                tekToplam += i; //sayı tekse tekToplam değerine ekler
            } 
            else
            {
                ciftToplam += i; //sayı çiftse çift toplam değerine ekler
            }
            
        }
       
        Console.WriteLine("1 ile 120 arasındaki tek sayıların toplamı " + tekToplam);
        Console.WriteLine("1 ile 120 arasındaki çift sayıların toplamı " + ciftToplam);
           }
           
       } 
   }      
