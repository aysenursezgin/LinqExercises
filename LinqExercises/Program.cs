using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Random random = new Random();

        // Rastgele 10 adet sayıdan oluşan bir liste oluşturma
        List<int> sayilar = Enumerable.Range(0, 10).Select(_ => random.Next(-10, 25)).ToList();

        Console.WriteLine("Rastgele Sayılar: " + string.Join(", ", sayilar));

       
        // Çift olan sayılar
        var ciftSayilar = sayilar.Where(x => x % 2 == 0);
        Console.WriteLine("Çift Sayılar: " + string.Join(", ", ciftSayilar));

        
        // Tek olan sayılar
        var tekSayilar = sayilar.Where(x => x % 2 != 0);
        Console.WriteLine("Tek Sayılar: " + string.Join(", ", tekSayilar));

       
        // Negatif sayılar
        var negatifSayilar = sayilar.Where(x => x < 0);
        Console.WriteLine("Negatif Sayılar: " + string.Join(", ", negatifSayilar));

       
        // Pozitif sayılar
        var pozitifSayilar = sayilar.Where(x => x > 0);
        Console.WriteLine("Pozitif Sayılar: " + string.Join(", ", pozitifSayilar));

        
        // 15'ten büyük ve 22'den küçük sayılar
        var araliktaSayilar = sayilar.Where(x => x > 15 && x < 22);
        Console.WriteLine("15'ten büyük ve 22'den küçük sayılar: " + string.Join(", ", araliktaSayilar));


        // Her bir sayının karesi
        var kareler = sayilar.Select(x => x * x).ToList();
        Console.WriteLine("Sayılardan Her Birinin Karesi: " + string.Join(", ", kareler));
    }
}

