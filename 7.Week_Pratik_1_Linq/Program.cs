class Program
{
    static void Main()
    {
        Random random = new Random(); //Rastgele sayı üretmek için Random sınıfından bir nesne oluşturuyoruz.
        List<int> numbers = new List<int>(); //Tam sayılar(int) içeren boş bir liste oluşturuyoruz.
        for (int i = 0; i < 10; i++)//Döngü başlatıyoruz. i < 10 olduğu sürece döngü 10 kez çalışır.
        {
            numbers.Add(random.Next(-20, 20)); // -20 ile 20 arasında sayılar üretir
        }
        //listeyi oluşturdu
        Console.WriteLine("Liste:");
        numbers.ForEach(n => Console.WriteLine(n + ""));//Listenin her elemanını sırayla ekrana yazdırır.Listenin her elemanını sırayla ekrana yazdırır.
        Console.WriteLine("\n"); //Bir satır boşluk bırakır.

        var evenNumbers = numbers.Where(n => n % 2 == 0);//numbers listesindeki elemanlardan n % 2 == 0 koşulunu sağlayanları (çift sayılar) evenNumbers değişkenine atar.
        Console.WriteLine("Çift sayılar:");
        evenNumbers.ToList().ForEach(n => Console.WriteLine(n + ""));//evenNumbers listesindeki her elemanı yazdırır.
        Console.WriteLine("\n");// Bir satır boşluk bırakır.

        var oddNumbers = numbers.Where(n => n % 2 != 0);
        Console.WriteLine("Tek sayılar:");
        oddNumbers.ToList().ForEach(n => Console.WriteLine(n + ""));
        Console.WriteLine("\n");// Bir satır boşluk bırakır.

        var negatifSayilar = numbers.Where(n => n < 0);
        Console.WriteLine("Negatif sayılar:");
        negatifSayilar.ToList().ForEach(n => Console.WriteLine(n + ""));
        Console.WriteLine("\n");// Bir satır boşluk bırakır.

        var pozitifSayilar = numbers.Where(n => n > 0);
        Console.WriteLine("Pozitif sayılar:");
        pozitifSayilar.ToList().ForEach(n => Console.WriteLine(n + ""));
        Console.WriteLine("\n");// Bir satır boşluk bırakır.

        var between15And22 = numbers.Where(n => n > 15 && n < 22);// numbers listesindeki elemanlardan 15'ten büyük ve 22'den küçük olanları between15And22 değişkenine atar.
        Console.WriteLine("15 ile 22 arasındaki sayılar:");
        between15And22.ToList().ForEach(n => Console.WriteLine(n + ""));//between15And22 listesindeki her elemanı ekrana yazar.
        Console.WriteLine("\n");// Bir satır boşluk bırakır.


        var squares = numbers.Select(n => n * n).ToList();//numbers listesindeki her elemanın karesini alarak squares isimli yeni bir liste oluşturur.
        Console.WriteLine("Her bir sayının karesi:");
        squares.ForEach(n => Console.Write(n + " "));//squares listesindeki her elemanı ekrana yazar.
        Console.WriteLine("\n");


    }
}