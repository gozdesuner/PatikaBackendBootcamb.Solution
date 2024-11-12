using _7.Week_Pratik_2_PatikafyMusic;

class Program
{
    static void Main()
    {
        List<Sarkici> sarkicilar = new List<Sarkici> // Şarkıcı nesnelerinden oluşan bir liste oluşturuyoruz.
        {
            // Her bir şarkıcı nesnesini listeye ekliyoruz.
            new Sarkici { Ad = "Ajda Pekkan", MuzikTur= "Pop", CikisYili = 1968, AlbumSatis = 20000000 },
            new Sarkici { Ad = "Sezen Aksu", MuzikTur= "Türk Halk Müziği / Pop", CikisYili= 1971, AlbumSatis = 10000000 },
            new Sarkici{ Ad = "Funda Arar", MuzikTur= "Pop",CikisYili = 1999, AlbumSatis = 3000000 },
            new Sarkici { Ad = "Sertab Erener", MuzikTur = "Pop", CikisYili = 1994, AlbumSatis = 5000000 },
            new Sarkici { Ad= "Sıla", MuzikTur = "Pop", CikisYili= 2009, AlbumSatis = 3000000 },
            new Sarkici { Ad = "Serdar Ortaç", MuzikTur = "Pop",CikisYili = 1994, AlbumSatis = 10000000 },
            new Sarkici { Ad = "Tarkan", MuzikTur = "Pop", CikisYili = 1992, AlbumSatis = 40000000 },
            new Sarkici { Ad = "Hande Yener", MuzikTur = "Pop", CikisYili = 1999, AlbumSatis = 7000000 },
            new Sarkici { Ad = "Hadise", MuzikTur= "Pop", CikisYili = 2005, AlbumSatis = 5000000 },
            new Sarkici { Ad = "Gülben Ergen", MuzikTur = "Pop / Türk Halk Müziği", CikisYili = 1997, AlbumSatis = 10000000 }
        };

        // 1. Adı 'S' ile başlayan şarkıcılar
        var sIleBaslayanlar = sarkicilar.Where(s => s.Ad.StartsWith("S"));
        Console.WriteLine("Adı 'S' ile başlayan şarkıcılar:");
        foreach (var sarkici in sIleBaslayanlar)
        {
            Console.WriteLine(sarkici.Ad);
        }
        Console.WriteLine();


        // 2. Albüm satışları 10 milyon'un üzerinde olan şarkıcılar
        var onMilyonUstu = sarkicilar.Where(s => s.AlbumSatis > 10_000_000);
        Console.WriteLine("Albüm satışları 10 milyon'un üzerinde olan şarkıcılar:");
        foreach (var sarkici in onMilyonUstu)
        {
            Console.WriteLine($"{sarkici.Ad} - {sarkici.AlbumSatis}");
        }
        Console.WriteLine();


        // 3. 2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar
        var eskiPopSarkicilar = sarkicilar
           .Where(s => s.CikisYili < 2000 && s.MuzikTur == "Pop")// 2000'den önce ve pop müzik yapanlar
           .OrderBy(s => s.CikisYili)// Çıkış yılına göre sıralama
           .ThenBy(s => s.Ad);// Aynı çıkış yılına sahip olanları ada göre sıralama

        Console.WriteLine("2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar:");
        foreach (var sarkici in eskiPopSarkicilar)
        {
            Console.WriteLine($"{sarkici.Ad} - Çıkış Yılı: {sarkici.CikisYili}");
        }
        Console.WriteLine();


        // 4. En çok albüm satan şarkıcı
        var enCokAlbumSatan = sarkicilar.OrderByDescending(s => s.AlbumSatis).FirstOrDefault();
        Console.WriteLine("En çok albüm satan şarkıcı:");
        Console.WriteLine($"{enCokAlbumSatan.Ad} - Albüm Satış: {enCokAlbumSatan.AlbumSatis}");
        Console.WriteLine();

        // 5. En yeni çıkış yapan şarkıcı ve en eski çıkış yapan şarkıcı
        var enYeniCikisYapan = sarkicilar.OrderByDescending(s => s.CikisYili).FirstOrDefault();
        var enEskiCikisYapan = sarkicilar.OrderBy(s => s.CikisYili).FirstOrDefault();

        Console.WriteLine("En yeni çıkış yapan şarkıcı:");
        Console.WriteLine($"{enYeniCikisYapan.Ad} - Çıkış Yılı: {enYeniCikisYapan.CikisYili}");
        Console.WriteLine();

        Console.WriteLine("En eski çıkış yapan şarkıcı:");
        Console.WriteLine($"{enEskiCikisYapan.Ad} - Çıkış Yılı: {enEskiCikisYapan.CikisYili}");
    }
}



