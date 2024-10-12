/*1 -> Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.

2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.

3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.

4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.

5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
*/


using System; 
   
   namespace WhileOrnek
   {
       class Program
       {
           static void Main(string[] args)
           { 
                int i = 0;    //çıktıda ilk olarak 1'i alabilmek için koşulu 0'dan başlattım
                while (i < 10)
                {
                    i++;
                   Console.WriteLine($"{i} Kendime inanıyorum, ben bu yazılım işini hallederim!"); //1'den 10'a kadar yazdığını görmek için sayıları da ekledim
               }
          

 //SORU 2  

         i = 0; 
        while(i < 20)    //koşulu 0'dan başlatıp 20'ye eşit olana kadar birer artırmasını sağlattım

        {
            i++;
           Console.WriteLine(i); //sayıların her değerini ekrana yansıtıyor
       }       
   
 //SORU 3
       
        i = 0;
        while(i < 20) 
               //koşulu 0'dan başlatıp 20 olana kadar ikişer artırmasını sağlattım, sonuç 20 vermesi için 20den küçük kalmalı

        {
            i += 2; 
           Console.WriteLine(i); //sayıların her değerini ekrana yansıtıyor
       }       

//SORU 4
        
       int toplam = 0;
       i = 50; 
        
        while(i <= 150) //i = 150 olana kadar devam ettirdim
        {
            toplam += i;    //değeri toplama ekledi
            i++;            //bir artırarark döngüye devam etti

       }
       
       Console.WriteLine("50 ile 150 arasındaki sayıların toplamı " + toplam);
     
//SORU 5
        int tekToplam = 0;
        int ciftToplam = 0;
        
        i = 1; 
        while (i <= 120) //sayı 120'ye eşit olana kadar devam eder
        {
            
            if (i % 2 != 0) //teklik kontrolü
            {
                tekToplam += i; //tekse tekToplama ekledi
            } 
            else
            {
                ciftToplam += i; //çiftse ciftToplama ekledi
            }
            i++;
            
        }
       
        Console.WriteLine("1 ile 120 arasındaki tek sayıların toplamı " + tekToplam);
        Console.WriteLine("1 ile 120 arasındaki çift sayıların toplamı " + ciftToplam);

     
           }
           
       } 
   }      
