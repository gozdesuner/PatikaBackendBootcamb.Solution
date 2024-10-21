using _4.Week_Pratik_2_Constructor;

class Program
{
    static void Main(string[] args)
    {
        Bebek baby1 = new Bebek();// 1. Bebek: Default constructor ile oluşturma
        baby1.Printİnfo();

        Bebek baby2 = new Bebek("Adrianna", "Jammy");// 2. Bebek: Parametreli constructor ile oluşturma
        baby2.Printİnfo();
        Console.ReadKey();
    }
}