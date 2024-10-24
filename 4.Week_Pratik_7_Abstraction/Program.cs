
using _4.Week_Pratik_7_Abstraction;

class Program
{
    static void Main()
    {
        // Çalışanları oluşturalım
        Calisan yazilimci = new YazilimGelistirici("Ali", "Aygün", "Yazılım");//YazilimGelistirici sınıfından yeni bir çalışan oluşturuluyor ve Calisan tipinde bir değişkene atanıyor. Bu değişken üzerinden Gorev metodu çağrılabilecek.
        Calisan projeYoneticisi = new ProjeYoneticisi("Cengiz", "Sözcü", "Proje Yönetimi");
        Calisan satisTemsilcisi = new SatisTemsilcisi("Elif", "Zeytin", "Satış");

        // Çalışanların görevlerini ekrana yazdıralım
        yazilimci.Gorev(); //YazilimGelistirici sınıfındaki Gorev metodu çağrılır ve yazılım geliştiricisinin görevi konsola yazdırılır.
        projeYoneticisi.Gorev();
        satisTemsilcisi.Gorev();
    }
}
