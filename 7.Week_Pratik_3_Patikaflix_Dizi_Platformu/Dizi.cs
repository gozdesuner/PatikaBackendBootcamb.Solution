namespace _7.Week_Pratik_3_Patikaflix_Dizi_Platformu
{
    public class Dizi
    {
        public string DiziAd { get; set; }
        public string YapimYili { get; set; }
        public string Turu { get; set; }
        public string YayinYili { get; set; }
        public string Yönetmen { get; set; }
        public string YayinlandigiIlkPlatform { get; set; }

        public Dizi(string diziAd, string yapimYili, string turu, string yayinYili, string yönetmen, string yayinlandigiIlkPlatform)
        {
            DiziAd = diziAd;
            YapimYili = yapimYili;
            Turu = turu;
            YayinYili = yayinYili;
            Yönetmen = yönetmen;
            YayinlandigiIlkPlatform = yayinlandigiIlkPlatform;
        }
    }

    public class KomediDizisi
    {
        public string DiziAdi { get; set; }
        public string DiziTuru { get; set; }
        public string Yonetmen { get; set; }

        public KomediDizisi(string diziAdi, string diziTuru, string yonetmen)
        {
            DiziAdi = diziAdi;
            DiziTuru = diziTuru;
            Yonetmen = yonetmen;
        }

    }
}