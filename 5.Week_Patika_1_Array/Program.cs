int[] sayilar = new int[10];//10 elemanlı bir dizi tanımladım.
for (int i = 0; i < sayilar.Length; i++)//o'dan başlayarak arttırarark gidiyor.
{

    sayilar[i] = i;//Dizinin her elemenı sayıyı indeksi ile eşitler .Örneğin,1. indeks değeri 1 gibi..
    Console.WriteLine(sayilar[i]);//Dizinin her elemanı anında ekrana yazılır.
}
foreach (int i in sayilar)//foreach komutu dizinin elemanlarını birer birer gezmek için kullanılır.
{
    Console.WriteLine(sayilar[i]);
}

Console.Write("Bir sayı giriniz:");
int sayi = int.Parse(Console.ReadLine());//Console.ReadLine() ile alınan girdi bir string (metin) olarak okunur.int.Parse() ifadesi, bu metni int tipine çevirir ve sayi değişkenine atar.

int[] yeniDizi = new int[11];//11 elemanlı yeni bir int dizisi yeniDizi oluşturulur. Bu yeni dizi, sayilar dizisinin elemanları ve kullanıcıdan alınan yeni elemanı içerecektir.
for (int i = 0; i < sayilar.Length; i++)//for döngüsü, sayilar dizisinin tüm elemanlarını yeniDizi'nin ilk 10 indeksine kopyalar.
{
    yeniDizi[i] = sayilar[i];//sayilar[i], yeniDizi[i] olarak atanır; böylece sayilar dizisinin tüm elemanları yeniDizi'ye geçirilir.
}
yeniDizi[10] = sayi;//yeniDizi[10] ifadesi, dizinin 11. elemanına kullanıcıdan alınan sayi değerini ekler. Böylece yeniDizi dizisinin son elemanı bu yeni değer olur.

Array.Sort(yeniDizi);//ifadesi yeniDizi dizisini küçükten büyüğe sıralar.
Array.Reverse(yeniDizi);// Büyükten küçüğe sıralamak için ters çevirme

Console.WriteLine("Oluşan dizinin büyükten küçüğe doğru sıralanmış hali:");

foreach (int eleman in yeniDizi)//Sıralı yeniDizi dizisi, her bir elemanı sırayla yazdırmak için foreach döngüsü ile ekrana yazdırılır.
{
    Console.WriteLine(eleman);//Console.WriteLine(eleman); ile yeniDizi dizisinin her bir elemanı büyükten küçüğe sırayla ekranda gösterilir.
}
