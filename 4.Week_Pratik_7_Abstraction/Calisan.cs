namespace _4.Week_Pratik_7_Abstraction
{
    abstract class Calisan//Bu sınıf, tüm çalışanların ortak özelliklerini (ad, soyad, departman) içerir.Ayrıca soyut bir Gorev metodu tanımlar.
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Departman { get; set; }

        public Calisan(string ad, string soyad, string departman)//Bu, Calisan sınıfının kurucu (constructor) metodudur. Bir Calisan nesnesi oluşturulduğunda ad, soyad ve departman bilgilerini alır ve ilgili özelliklere atar.
        {
            Ad = ad;
            Soyad = soyad;
            Departman = departman;
        }
        public abstract void Gorev();//Bu soyut bir metottur ve gövdesi yoktur. Yani bu metod, alt sınıflarda (türetilmiş sınıflarda) uygulanmak zorundadır. Her alt sınıf, kendine özgü bir görev metodunu tanımlayacaktır. Bu soyut metot, bir çalışanın görevini tanımlamak için kullanılacaktır.
    }
    //YazilimGelistirici, ProjeYoneticisi, SatisTemsilcisi: Bu sınıflar, Calisan sınıfından türetilmiştir ve kendi özel görev metotlarını (override) içerirler.
    // Yazılım Geliştirici sınıfı
    class YazilimGelistirici : Calisan//YazilimGelistirici, Calisan sınıfından türetilmiş bir sınıftır. Bu sınıf, yazılım geliştirici çalışanlarını temsil eder. Calisan sınıfındaki özellikleri miras alır ve kendi Gorev metodunu tanımlayacaktır.
    {
        public YazilimGelistirici(string ad, string soyad, string departman) : base(ad, soyad, departman) { }// Bu, YazilimGelistirici sınıfının kurucu metodudur. base anahtar kelimesi, Calisan sınıfının kurucusuna (ad, soyad, departman) parametreleri göndererek miras alınan özelliklerin atanmasını sağlar.

        public override void Gorev()//Bu satırda, YazilimGelistirici sınıfı, Calisan sınıfındaki soyut Gorev metodunu "geçersiz kılıyor" (override) ve bu sınıf için özel bir görev tanımlıyor. Bu, yazılım geliştiricinin ne iş yaptığını gösterecek.
        {
            Console.WriteLine($"{Ad} {Soyad}, Yazılım Geliştirici olarak çalışıyorum.");
        }
    }

    // Proje Yöneticisi sınıfı
    class ProjeYoneticisi : Calisan
    {
        public ProjeYoneticisi(string ad, string soyad, string departman)
            : base(ad, soyad, departman) { }

        public override void Gorev()
        {
            Console.WriteLine($"{Ad} {Soyad}, Proje yöneticisi olarak çalışıyorum.");
        }
    }

    // Satış Temsilcisi sınıfı
    class SatisTemsilcisi : Calisan
    {
        public SatisTemsilcisi(string ad, string soyad, string departman)
            : base(ad, soyad, departman) { }

        public override void Gorev()
        {
            Console.WriteLine($"{Ad} {Soyad}, Satış temsilcisi olarak çalışıyorum.");
        }
    }

}