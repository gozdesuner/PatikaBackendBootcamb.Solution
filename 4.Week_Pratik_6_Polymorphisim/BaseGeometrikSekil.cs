namespace _4.Week_Pratik_6_Polymorphisim
{
    public class BaseGeometrikSekil//BaseGeometrikSekil tüm geometrik şekillerin ortak özelliklerini tutan temel (base) sınıf.
    {
        //Genislik ve Yukseklik property'leri genişlik ve yükseklik değerlerini tutar. Herhangi bir şeklin genişliği ve yüksekliği bu sınıf üzerinden tanımlanır.
        public double Genislik { get; set; }
        public double Yukseklik { get; set; }
        public BaseGeometrikSekil(double genislik, double yukseklik)//BaseGeometrikSekil constructor'ı (BaseGeometrikSekil(double genislik, double yukseklik)) genişlik ve yükseklik değerlerini alıp ilgili property'lere atar.
        {
            Genislik = genislik;
            Yukseklik = yukseklik;
        }
        public virtual double Alan()//AlanHesapla() metodu sanal (virtual) olarak tanımlanmıştır. Bu, alt sınıflarda bu metodun üzerine yazılabileceği (override edileceği) anlamına gelir. Varsayılan olarak genişlik × yükseklik işlemini yapar.

        { return Genislik * Yukseklik; }
    }
    public class Kare : BaseGeometrikSekil//Kare sınıfı, BaseGeometrikSekil sınıfından türetilmiştir.
    {
        public Kare(double kenar) : base(kenar, kenar) { }//Constructor (Kare(double kenar)) bir kenar uzunluğunu alır ve hem genişlik hem de yükseklik olarak aynı değeri temel sınıfa aktarır. Karelerde genişlik ve yükseklik aynı olduğu için iki kez aynı değeri kullanıyoruz.
        public override double Alan()
        {
            return base.Alan();
        }
    }
    public class Dikdortgen : BaseGeometrikSekil//Dikdortgen sınıfı, BaseGeometrikSekil sınıfından türetilmiştir.
    {
        public Dikdortgen(double genislik, double yukseklik) : base(genislik, yukseklik) { }
        public override double Alan()
        {
            return base.Alan();
        }
    }
    public class DikUcgen : BaseGeometrikSekil//DikUcgen sınıfı, BaseGeometrikSekil sınıfından türetilmiştir.
    {
        public DikUcgen(double genislik, double yukseklik) : base(genislik, yukseklik) { }
        public override double Alan()//AlanHesapla() metodu dik üçgenin alanını (Genislik * Yukseklik) / 2 formülü ile hesaplar. Bu nedenle bu metodu temel sınıftan farklı olacak şekilde yeniden tanımlıyoruz (override).

        {
            return (Genislik * Yukseklik) / 2;
        }

    }
}

