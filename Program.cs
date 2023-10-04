namespace If_ElseIf_Ternary;

class Program
{
    static void Main(string[] args)
    {
        int time = DateTime.Now.Hour;       // burada datetime kütüphanesinden yararlandıok
        if(time>=6 && time<11)
        Console.WriteLine("günaydın");      // eğer saat sabah 6 ile 11 arasında ise bize günaydın yazacak
        else if(time<=18)
        Console.WriteLine("iyi günler");    // eğer 18 eşit yada küçükse iyi günler yazacak
        else
        Console.WriteLine("iyi geceler");   // değilse iyi geceler yazdıracak      

        string sonuc = time<=18 ? "iyi günler" : "iyi geceler"; // bu koşul sağlanırsa soru işaretinden önceki ilk ifade çalışır. değilse sonraki ifade çalışır.
        sonuc =time>=6 && time<11 ? "günaydın" : time<=18 ? "iyi günler" : "iyigeceler"; //time11 den küçük küçük eşit 11 ise günaydın değilse diğer koşul olan 18eşit yada küçük olma koşulunu çalıştırıyor ve 18den küçükse iyi günler değilse iyi geceler yazacak.

        //İKİ YAZIM ARASINDAKİ FARK BİRİSİ UZUN İNCE OLDUĞUNDAN OKUNMASI ANLAŞILMASI ZOR OLUYOR. DİĞERİ SATIR SATIR OLDUĞUNDAN OKUNMASI ANLAŞILMASI DAHA KOLAY
        Console.WriteLine(sonuc);  

    }
}
// HACKER RANK ÖDEVİ     

class Solution
{
    public static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine().Trim());
        if (N % 2 == 1)                                      // EGER TAMSAYIMIZ TEK İSE WİRD YAZDIR
        {
            Console.WriteLine("Weird");
        }
        else if (N % 2 == 0 && (N >= 2 && N <= 5))          // EGER SAYIMIZ ÇİFT SAYI İSE VE (2 YE EŞİTBÜYÜK VE 5 EŞİTKÜÇÜK İSE NOT WEİRD YAZDIR)
        {
            Console.WriteLine("Not Weird");
        }
        else if (N % 2 == 0 && (N >=6 && N <= 20))         // EGER SAYIMIZ ÇİFT SAYI İSE VE (6 EŞİTBÜYÜK VE 20 EŞİTKÜÇÜK İSE WEİRD YAZDIR)
        {
            Console.WriteLine("Weird");
        }
        else if (N % 2 == 0 && N >= 20)                   // EGER SAYIMIZ ÇİFT SAYI İSE VE (20 EŞİTBÜYÜK İSE NOT WEİRD YAZDIR)
        {
            Console.WriteLine("Not Weird");
        }
    }
}

