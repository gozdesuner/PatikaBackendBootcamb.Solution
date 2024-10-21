namespace _4.Week_Pratik_2_Constructor
{
    public class Bebek
    {
        private DateTime _birthday { get; set; }
        private string _name { get; set; }
        private string _surname { get; set; }

        //Defauld constructor
        public Bebek()
        {
            _birthday = DateTime.Now;// Doğum tarihi şu anki zaman
            Console.WriteLine("Ingaaaaağğğğğğğğ");// Bebek oluşturulunca konsola yazılacak
            _name = "Unknown";// Default değerler
            _surname = "Unknown";
        }

        public Bebek(string _name, string _surname)
        {
            _birthday = DateTime.Now;
            Console.WriteLine("Ingaaaaağğğğğğğğ");
            _name = _name;// Parametrelerden gelen ad ve soyadı atama
            _surname = _surname;

        }
        public void Printİnfo()
        {
            Console.WriteLine($"Name:{_name},Surname:{_surname}, Birthday:{_birthday}");
        }
    }
}
