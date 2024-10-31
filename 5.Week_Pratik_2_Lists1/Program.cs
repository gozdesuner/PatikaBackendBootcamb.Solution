class Program
{
    static void Main()
    {
        List<string> davetliler = new List<string>
        {
            "Bülent Ersoy",
            "İbrahim Tatlıses",
            "Müslüm Gürses",
            "Güllü",
            "Orhan Gencebay",
            "Sezen Aksu",
            "Azer Bülbül"
        };

        Console.WriteLine("**Davetliler**");
        foreach (string isim in davetliler)
        {
            Console.WriteLine(isim);
        }
    }
}
