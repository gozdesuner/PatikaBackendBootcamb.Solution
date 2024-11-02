namespace _5.Week_Pratik_Araba_Fabrikası
{
    public class Araba
    {
        public DateTime UretimTarihi { get; private set; }
        public string SeriNo { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public int KapiSayisi { get; set; }

        public Araba()

        {
            UretimTarihi = DateTime.Now;
        }
    }
}