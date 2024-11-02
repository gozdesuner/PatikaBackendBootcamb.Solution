using _5.Week_Pratik_Araba_Fabrikası;

class Program
{
    static void Main()
    {
        List<Araba> arabalar = new List<Araba>(); // Araba nesnelerini saklayacak liste tanımlanıyor

        while (true) // Kullanıcı sonlandırana kadar devam edecek sonsuz döngü
        {
            Console.WriteLine("Araba üretmek istiyor musunuz?(E/H)"); // Kullanıcıya araba üretmek isteyip istemediği soruluyor
            string cevap = Console.ReadLine().ToLower();// Kullanıcının cevabı alınıyor ve küçük harfe dönüştürülüyor
            if (cevap != "e" && cevap != "h")// Eğer cevap "e" veya "h" değilse geçersiz giriş uyarısı verilir
            {
                Console.WriteLine("Geçersiz cevapéLütfen 'E' veya 'H' giriniz.");
                continue;// Döngünün başına dönerek aynı soruyu tekrar sorar

            }
            else if (cevap == "h") // Kullanıcı "h" derse program sonlanır
            {
                Console.WriteLine("Program sonlandırılıyor.");
                break;// Döngü kırılır ve program sona erer
            }

            Araba YeniAraba = new Araba();// Yeni bir araba nesnesi oluşturulur
            Console.WriteLine("Seri Numarası:");
            YeniAraba.SeriNo = Console.ReadLine();
            Console.WriteLine("Marka:");
            YeniAraba.Marka = Console.ReadLine();
            Console.WriteLine("Model:");
            YeniAraba.Model = Console.ReadLine();
            Console.WriteLine("Renk:");
            YeniAraba.Renk = Console.ReadLine();


        Kapı:// Kapı sayısı girişi için goto etiketi
            Console.WriteLine("Kapı Sayısı:");
            try
            {
                YeniAraba.KapiSayisi = int.Parse(Console.ReadLine()); // Girilen değeri int'e çevirir
            }
            catch
            {
                Console.WriteLine("Geçersiz giriş yaptınız.Lütfen bir sayı giriniz:");// Hatalı giriş yapılırsa kullanıcı uyarılır
                goto Kapı;// Etikete dönerek kapı sayısı girişini tekrar ettirir
            }

            arabalar.Add(YeniAraba);// Yeni araba nesnesi arabalar listesine eklenir
            Console.WriteLine("Araba üretildi!!!!Hayırlı Olsun.");// Başarılı üretim mesajı gösterilir

            Console.WriteLine("Başka bir araba üretmek istiyor musunu?(E/H):");// Kullanıcıya başka bir araba isteği sorulur
            cevap = Console.ReadLine().ToLower();// Cevap küçük harfe dönüştürülür


            if (cevap == "h") ;// Cevap "h" ise araba listesini gösterir ve program sonlanır
            {
                Console.WriteLine("Üretilen arabalar:");
                foreach (var araba in arabalar)// Arabalar listesindeki her bir araba için
                {
                    Console.WriteLine($"Seri no:{araba.SeriNo},Marka:{araba.Marka}");// Seri numarası ve marka ekrana yazdırılır
                }
                break;// Döngü kırılır ve program sona erer
            }


        }
    }
}