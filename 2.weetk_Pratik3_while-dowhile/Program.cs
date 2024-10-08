using System;

class Program
{
    static void Main(string[] args)
    {
        //while döngüsü ile sayaç arttırarak yazdırma
        Console.WriteLine("Lütfen bir limit değeri giriniz.");//Kullanıcıdın bir limit değeri alınır.
        int limit = Convert.ToInt32(Console.ReadLine());//Convert.ToInt32 komutu ile kullanıcıdan alınan string değeri tamsayıya çevrilir.
        int sayaç = 0;//Sayaç başlangıç değeri.

        while (sayaç <= limit)//Limit aşılana kadar döngü devam eder.
        {
            Console.WriteLine("Ben bir Patika'lıyım.");//Ekrana mesajı yazdırır.
            sayaç++;//Sayaç her döngüde bir artacak.

        }

        //do-while döngüsü ile sayaç arttırarak yazdırma
        Console.WriteLine("Lütfen bir limit değeri giriniz.");//Kullanıcıdın bir limit değeri alınır.
        int limit = Convert.ToInt32(Console.ReadLine());//Convert.ToInt32 komutu ile kullanıcıdan alınan string değeri tamsayıya çevrilir.
        int sayaç = 0;//Sayaç başlangıç değeri.
        do
        {
            Console.WriteLine("Ben bir Patika'lıyım.");//Ekrana mesajı yazdırır.
            sayaç++;//Sayaç her döngüde bir artacak.
        }
        while (sayaç <= limit);//Limit aşılana kadar döngü devam eder.
    }
}
          //while ile do-while arasındaki fark :while döngüsü koşulu döngünün başında kontrol ederken do-while için ise koşul döngü sonunda kontrol edilir.