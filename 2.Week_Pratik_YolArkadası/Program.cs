using System;
using System.ComponentModel.Design;

class TatilAcentesi
{
    static void Main(string[] args)
    {
        bool devamEt = true;// Kullanıcının tatil planı yapmak isteyip istemediğini kontrol ediyoruz.bool değişkeni ya true ya da false olabilir.Kullanıcının başlayabilmesi için true seçtim.

        while (devamEt)//devamEt true olduğu sürece döngü tekrar tekrar çalışır.

            Console.WriteLine("Lütfen gitmek istediğiniz lokasyonu seçiniz: Bodrum, Marmaris, Çeşme");//Hangi lokasyonu seçmek istediklerini sordum.
        string lokasyon = Console.ReadLine().ToLower();//Lokasyonu büyük, küçük harf ayırt etmeden çalıştırması için ToLowerı seçtim.
        int paket = 0;//Paket fiyatını tanımladım.
        {
            if (lokasyon == "bodrum")//Eğer bodrum seçilirse
            {
                paket = 4000;//Paket fiyatını belirttim.
                Console.WriteLine("Lokasyon olarak Bodrum'u seçtiniz.Paket başlangıç fiyatı:4000TL'dir.");//Mesajı ekrana yazdırdım.
                Console.WriteLine("Bodrum'da birbirinden güzel plajlar,lezettiyle ünlü zeytinyağlı yemekleri ve balık restoranları, hareketli gece hayatı  sizi bekliyor.");
            }
            else if (lokasyon == "marmaris")
            {
                paket = 3000;
                Console.WriteLine("Lokasyon olarak Marmaris'i seçtiniz.Paket başlangıç fiyatı:3000TL'dir.");
                Console.WriteLine("Marmaris, bütün kötü olayları size unutturacak muhteşem koyları, doğal güzellikleriyle sizi bekliyor!.");
            }
            else if (lokasyon == "çeşme")
            {
                paket = 5000;
                Console.WriteLine("Lokasyon olarak Çeşme'yi seçtiniz.Paket başlangıç fiyatı:5000TL'dir.");
                Console.WriteLine("Çeşme, şehir merkezine yakın olan temiz koyları,leziz yemekleri ve ünlü gece klupleriyle size sosyal bir yaşam sunar.");
            }
            Console.WriteLine("Bu tatil planınızda kaç kişi olacaksınız?");// Mesajı ekrana yazdırdım.
            int KisiSayısı = Convert.ToInt32(Console.ReadLine());//Seçilen kişi sayısını integer bir sayıya çevirir.KisiSayısı değişkenine aktarır.

            Console.WriteLine("Tatilinize hangi yolla gitmek istersiniz");
            Console.WriteLine("1-Kara Yolu (Kişi başı ulasım ücreti:1500 TL");
            Console.WriteLine("2-Hava Yolu (Kişi başı ulasım ücreti:4000 TL");
            Console.WriteLine("Lütfen 1 veya 2 şeklinde giriniz.");

            int UlasımSecimi = Convert.ToInt32(Console.ReadLine());
            int UlasımÜcreti = 0;//Ulaşım ücretini tutacak bir değişken seçtim.
            if (UlasımSecimi == 1)// Eğer 1. ulaşım yolu seçilirse
            {
                UlasımÜcreti = 1500;//Ulaşım ücretini belirledim.
                Console.WriteLine("Kara yolunu seçtiniz.");//Mesajı ekrana yazdırır.
            }
            else if (UlasımSecimi == 2)// Eğer 2. ulaşım yolu seçilirse
            {
                UlasımÜcreti = 4000;//Ulaşım ücretini belirledim.
                Console.WriteLine("Hava yolunu seçtiniz.");//Mesajı ekrana yazdırır.
            }
            else
            {
                Console.WriteLine("Hatalı seçim yaptınız!Lütfen geçerli bir seçenek giriniz.");//Mesajı ekrana yazdırır.
                UlasımSecimi = Convert.ToInt32(Console.ReadLine());
            }
            int toplamfiyat = paket + (KisiSayısı * UlasımÜcreti);//Tatilin toplam maliyetini hesapladım.
            Console.WriteLine($"Toplam tatil ücretiniz:{toplamfiyat} TL");//Hesaplanan toplam fiyat ekrana yazdırılır.

            Console.WriteLine("Başka bir tatil planlamak ister misiniz? (E/H)");
            string devamCevabi = Console.ReadLine().ToLower();//Kullanıcıdan alınan cevap küçük harfe çevrilir (ToLower()), böylece büyük/küçük harf duyarlılığı ortadan kalkar

            if (devamCevabi != "e")
            {
                devamEt = false;
                Console.WriteLine("İyi günler dileriz!");
            }
        }
    }
}