using _4.Week_Pratik_6_Polymorphisim;

class Program
{
    static void Main()
    {
        Kare kare = new Kare(3);
        Console.WriteLine($"Karenin Alanı:{kare.Alan()}");

        Dikdortgen dikdortgen = new Dikdortgen(8, 4);
        Console.WriteLine($"Dikdörtgenin Alanı:{dikdortgen.Alan()}");

        DikUcgen dikUcgen = new DikUcgen(12, 4);
        Console.WriteLine($"Dik Üçgenin Alanı:{dikUcgen.Alan()}");

    }
}