namespace _4.Week_Pratik_3_Encapsulation
{
    public class Araba
    {
        public string marka { get; set; }
        public string model { get; set; }
        public string renk { get; set; }

        private int _KapiSayisi;

        public int KapiSayisi
        {
            get { return _KapiSayisi; }

            set// Bu kısım, dışarıdan KapiSayisina bir değer atanmak istendiğinde çalışır. value, atanan değeri temsil eder. Eğer value 2 veya 4 olursa, bu değer _KapiSayisi'na atanır.
            {
                if (value == 2 || value == 4)
                {
                    _KapiSayisi = value;
                }
                else//Eğer value 2 veya 4 değilse, bir uyarı mesajı görüntülenir ve _KapiSayisi'na -1 atanır. Bu, hatalı bir kapı sayısı olduğu anlamına gelir.
                {
                    Console.WriteLine("Geçersiz kapı sayısı! Lütfen 2 veya 4 girin.");
                    _KapiSayisi = -1;

                }
            }

        }

        public Araba(string arabaMarka, string arabaModel, string arabaRenk, int kapiSayisi)//Bu, yapıcı metottur. Araba sınıfından yeni bir nesne oluşturulurken çalışır ve arabayla ilgili bilgilerin (marka, model, renk, kapı sayısı) atanmasını sağlar.
        {
            marka = arabaMarka;//Parametre olarak alınan arabaMarka değeri, sınıfın marka özelliğine atanır.
            model = arabaModel;
            renk = arabaRenk;
            KapiSayisi = kapiSayisi;//Parametre olarak gelen kapiSayisi değeri, kapsülleme özelliğine (KapiSayisi) atanır ve bu sayede doğrulama kontrolü yapılır.


        }

    }
}
