class Program
{
    static void Main()
    {
        bool devamEt = true; // Kullanıcı başka ürün üretmek isteyip istemediğini kontrol etmek için kullanılır.

        while (devamEt)
        {
            // Kullanıcıdan telefon ya da bilgisayar üretmesini iste
            Console.WriteLine("Telefon üretmek için 1'e, Bilgisayar üretmek için 2'ye basın.");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                // Telefon üretimi
                Telefon telefon = new Telefon(); // Yeni bir Telefon nesnesi oluşturulur.
                UrunBilgileriniAl(telefon); // Ortak bilgileri kullanıcıdan al.
                Console.WriteLine("TR Lisanslı mı? (Evet/Hayır): ");
                telefon.TrLisansli = Console.ReadLine().ToLower() == "evet"; // TR lisans durumu sorulur.
                telefon.BilgileriYazdir(); // Bilgileri ekrana yazdır.
                telefon.UrunAdiGetir(); // Ürün adını ekrana yazdır.
                Console.WriteLine("Telefon başarıyla üretildi.");
            }
            else if (secim == "2")
            {
                // Bilgisayar üretimi
                Bilgisayar bilgisayar = new Bilgisayar(); // Yeni bir Bilgisayar nesnesi oluşturulur.
                UrunBilgileriniAl(bilgisayar); // Ortak bilgileri kullanıcıdan al.
                Console.WriteLine("USB Giriş Sayısı (2 veya 4): ");
                bilgisayar.UsbGirisSayisi = int.Parse(Console.ReadLine()); // USB giriş sayısı kullanıcıdan alınır.
                Console.WriteLine("Bluetooth var mı? (Evet/Hayır): ");
                bilgisayar.Bluetooth = Console.ReadLine().ToLower() == "evet"; // Bluetooth durumu sorulur.
                bilgisayar.BilgileriYazdir(); // Bilgileri ekrana yazdır.
                bilgisayar.UrunAdiGetir(); // Ürün adını ekrana yazdır.
                Console.WriteLine("Bilgisayar başarıyla üretildi.");
            }

            // Başka bir ürün üretmek isteyip istemediğini sor.
            Console.WriteLine("Başka bir ürün üretmek ister misiniz? (Evet/Hayır)");
            devamEt = Console.ReadLine().ToLower() == "evet"; // Evet ise devam edilir, hayır ise program sonlanır.
        }

        Console.WriteLine("İyi günler!"); // Program sonlandırılırken ekrana yazılır.
    }

    // Ortak bilgileri kullanıcıdan almak için kullanılan metod.
    static void UrunBilgileriniAl(BaseMakine urun)
    {
        // Ortak özellikleri kullanıcıdan al.
        Console.WriteLine("Ürünün adı: ");
        urun.Ad = Console.ReadLine();
        Console.WriteLine("Seri Numarası: ");
        urun.SeriNumarasi = Console.ReadLine();
        Console.WriteLine("Açıklama: ");
        urun.Aciklama = Console.ReadLine();
        Console.WriteLine("İşletim Sistemi: ");
        urun.IsletimSistemi = Console.ReadLine();
    }
}
