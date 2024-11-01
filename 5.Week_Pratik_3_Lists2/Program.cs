
Dictionary<int, string> coffee = new Dictionary<int, string>();// Kahve isimlerini saklayacak bir sözlük tanımladım.

for (int i = 0; i < 5; i++)//for döngüsüyle kullanıcıdan isimler alır.Dictionary içine eklenir.
{
    Console.WriteLine($"lütfen{i + 1} kahve ismini giriniz:");
    string name = Console.ReadLine();
    coffee.Add(i + 1, name);//Add metodu iki parametre alır: bir anahtar (int türünde sıra numarası) ve bir değer (kahve ismi).

}
Console.WriteLine("Girdiğiniz kahve isimleri:");

foreach (var s in coffee)//foreach döngüsünde coffee içindeki Value değerlerini (string kahve isimleri) yazdırıyoruz.
{
    Console.WriteLine(s);
}
