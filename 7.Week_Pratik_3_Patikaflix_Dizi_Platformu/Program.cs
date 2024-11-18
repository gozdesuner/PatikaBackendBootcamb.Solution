using _7.Week_Pratik_3_Patikaflix_Dizi_Platformu;

public class Program
{
    public static void Main()
    {
        List<Dizi> diziler = new List<Dizi>();
        string eklemeDevam;

        do
        {
            Console.Write("Dizi Adı: ");
            string diziAd = Console.ReadLine();

            Console.Write("Yapım Yılı: ");
            string yapimYili = Console.ReadLine();

            Console.Write("Türü: ");
            string türü = Console.ReadLine();

            Console.Write("Yayın Yılı: ");
            string yayinYili = Console.ReadLine();

            Console.Write("Yönetmen: ");
            string yönetmen = Console.ReadLine();

            Console.Write("Yayınlandığı İlk Platform: ");
            string yayinlandiğiIlkPlatform = Console.ReadLine();

            diziler.Add(new Dizi(diziAd, yapimYili, türü, yayinYili, yönetmen, yayinlandiğiIlkPlatform));

            Console.Write("Yeni bir dizi eklemek istiyor musunuz? (E/H): ");
            eklemeDevam = Console.ReadLine().ToUpper();


        }

        while (eklemeDevam == "E");

        List<KomediDizisi> komediDizileri = diziler
            .Where(dizi => dizi.Turu.ToLower() == "komedi")
            .Select(dizi => new KomediDizisi(dizi.DiziAd, dizi.Turu, dizi.Yönetmen))
            .OrderBy(dizi => dizi.DiziAdi)
            .ThenBy(dizi => dizi.Yonetmen)
            .ToList();

        Console.WriteLine("\nKomedi Dizileri Listesi:");
        foreach (var dizi in komediDizileri)
        {
            Console.WriteLine($"Dizi Adı: {dizi.DiziAdi},Türü:{dizi.DiziTuru}, Yönetmen: {dizi.Yonetmen}");
        }



    }
}
#