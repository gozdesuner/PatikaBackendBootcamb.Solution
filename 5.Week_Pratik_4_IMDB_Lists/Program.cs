class Program
{
    static void Main()
    {
        List<Tuple<double, string>> filmList = new List<Tuple<double, string>>(); // IMDb puanı ve film ismini saklayacak Tuple yapısında bir film listesi oluşturuluyor.
        bool devam = true;// Kullanıcının film eklemeye devam etmek isteyip istemediğini kontrol edecek boolean değişken tanımlanıyor ve başlangıç değeri true olarak ayarlanıyor

        while (devam)// Kullanıcı devam etmek istediği sürece döngü tekrar edecek
        {
            Console.WriteLine("Film adı:"); // Kullanıcıdan film adını isteyen bir mesaj yazdırılıyor
            string isim = Console.ReadLine();// Kullanıcının girdiği film adı 'isim' değişkenine atanıyor.

            Console.WriteLine("IMDB puanı:");// Kullanıcıdan IMDb puanını isteyen bir mesaj yazdırılıyor.
            double imdbPuanı;// IMDb puanını saklayacak double türünde bir değişken tanımlanıyor.

            while (!double.TryParse(Console.ReadLine(), out imdbPuanı))// Girilen değerin double türüne dönüşüp dönüşmediğini kontrol ediyor.
            {
                Console.WriteLine("Geçerli bir IMDB puanı girin:");// Hatalı giriş yapılırsa kullanıcıya tekrar geçerli bir IMDb puanı girmesi söyleniyor.
                Console.WriteLine("IMDB puanı:"); // Tekrar IMDb puanı isteniyor.

            }
            filmList.Add(new Tuple<double, string>(imdbPuanı, isim));// Tuple yapısında IMDb puanı ve film adını listeye ekliyor

            Console.WriteLine("Yeni bir film eklemek ister misiniz?(Evet/Hayır):");
            string cevap = Console.ReadLine().ToLower();// Kullanıcıdan alınan cevap küçük harfe çevriliyor.
            devam = cevap == "evet";// Cevap "evet" ise döngü devam edecek, aksi takdirde sona erecek.
        }
        Console.WriteLine("\n Tüm filmler:");
        foreach (var film in filmList)// Tüm film listesindeki her bir film için döngü
        {
            Console.WriteLine($"Film Adı:{film.Item2},IMDB Puanı:{film.Item1}");// Film adı ve IMDb puanı ekrana yazdırılıyor
        }

        Console.WriteLine("\nİsmi 'A' ile başlayan filmler:");
        var aIleBaslayanFilm = filmList.Where(f => f.Item2.Length > 0 && (f.Item2[0] == 'A' || f.Item2[0] == 'a'));// İsmi 'A' veya 'a' ile başlayan filmleri filtreliyor
        foreach (var film in aIleBaslayanFilm)// Filtrelenen filmler için döngü
        {
            Console.WriteLine($"Film Adı:{film.Item2},IMDB Puanı:{film.Item1}");// Film adı ve IMDb puanı ekrana yazdırılıyor
        }
    }
}
