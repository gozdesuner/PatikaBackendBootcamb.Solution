namespace _4.Week_Pratik_8_Kapanıs
{
    abstract class BaseMakine // BaseMakine soyut sınıfı, Telefon ve Bilgisayar sınıfları için temel olacak.
    {
        // Ortak özellikler (Ad, Seri Numarası, vb.)
        public DateTime UretimTarihi { get; private set; } // Üretim tarihi otomatik atanacak.
        public string SeriNumarasi { get; set; } // Her ürünün bir seri numarası var.
        public string Ad { get; set; } // Ürünün adı.
        public string Aciklama { get; set; } // Ürün hakkında açıklama.
        public string IsletimSistemi { get; set; } // Ürünün işletim sistemi.

        public BaseMakine()
        {
            // Üretim Tarihi, nesne oluşturulduğunda otomatik atanır.
            UretimTarihi = DateTime.Now;
        }

        // Ortak bilgileri yazdıran metod (Polymorphism ile ezilebilir)
        public virtual void BilgileriYazdir()
        {
            Console.WriteLine($"Ad: {Ad}");
            Console.WriteLine($"Seri Numarası: {SeriNumarasi}");
            Console.WriteLine($"Açıklama: {Aciklama}");
            Console.WriteLine($"İşletim Sistemi: {IsletimSistemi}");
            Console.WriteLine($"Üretim Tarihi: {UretimTarihi}");
        }

        // Abstract metod, her alt sınıf kendine özgü şekilde uygulayacak (Abstraction)
        public abstract void UrunAdiGetir();
    }

    class Telefon : BaseMakine // Telefon sınıfı, BaseMakine sınıfından miras alır.
    {
        public bool TrLisansli { get; set; } // Telefonun TR lisanslı olup olmadığını belirtir.

        // BilgileriYazdir metodu, BaseMakine'deki versiyonu geçersiz kılar (override) ve Telefon'a özgü özellik ekler.
        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir(); // BaseMakine sınıfındaki bilgileri yazdırır.
            Console.WriteLine($"TR Lisanslı: {(TrLisansli ? "Evet" : "Hayır")}"); // TR lisans durumu eklenir.
        }

        // UrunAdiGetir metodunu implement eder, Telefon için özel mesaj gösterir.
        public override void UrunAdiGetir()
        {
            Console.WriteLine($"Telefonunuzun adı ---> {Ad}");
        }
    }

    class Bilgisayar : BaseMakine // Bilgisayar sınıfı, BaseMakine sınıfından miras alır.
    {
        private int usbGirisSayisi; // USB giriş sayısı, encapsulation uygulanacak.

        public bool Bluetooth { get; set; } // Bilgisayarın Bluetooth desteği olup olmadığını belirtir.

        // USB giriş sayısı 2 veya 4 olabilir. Aksi durumda uyarı verip -1 atar.
        public int UsbGirisSayisi
        {
            get { return usbGirisSayisi; }
            set
            {
                if (value == 2 || value == 4)
                {
                    usbGirisSayisi = value; // Eğer değer 2 veya 4 ise atama yapılır.
                }
                else
                {
                    usbGirisSayisi = -1; // Geçersiz değerlerde -1 atanır.
                    Console.WriteLine("Geçersiz USB giriş sayısı, 2 veya 4 olabilir. USB giriş sayısı -1 olarak atandı.");
                }
            }
        }

        // BilgileriYazdir metodu, BaseMakine'deki versiyonu geçersiz kılar ve Bilgisayar'a özgü özellik ekler.
        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir(); // BaseMakine sınıfındaki bilgileri yazdırır.
            Console.WriteLine($"USB Giriş Sayısı: {usbGirisSayisi}"); // USB giriş sayısı eklenir.
            Console.WriteLine($"Bluetooth: {(Bluetooth ? "Var" : "Yok")}"); // Bluetooth durumu eklenir.
        }

        // UrunAdiGetir metodunu implement eder, Bilgisayar için özel mesaj gösterir.
        public override void UrunAdiGetir()
        {
            Console.WriteLine($"Bilgisayarınızın adı ---> {Ad}");
        }
    }
}