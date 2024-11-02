class Program
{
    static void Main()
    {
        Console.Write("Bir sayı giriniz: ");

        try
        {
            // Kullanıcının girdiği değeri double olarak parslıyoruz
            double sayi = double.Parse(Console.ReadLine());

            // Geçerli bir sayı girildiyse karesini hesaplayıp gösteriyoruz
            double kare = sayi * sayi;
            Console.WriteLine($"Girilen sayının karesi: {kare}");
        }
        catch (FormatException)
        {
            // Kullanıcı geçersiz bir giriş yaparsa hata mesajı gösteriyoruz
            Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
        }
    }
}