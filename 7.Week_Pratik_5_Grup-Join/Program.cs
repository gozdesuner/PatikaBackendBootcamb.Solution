namespace _7.Week_Pratik_5_Grup_Join;


// Program: Ana uygulama sınıfıdır.
public class Program
{
    // Main: Programın başlangıç noktasıdır.
    public static void Main()
    {
        // Öğrenci verilerini oluşturuyoruz.
        List<Student> students = new List<Student>
            {
                new Student { StudentId = 1, Name = "Ali", ClassId = 1 }, // Ali Matematik sınıfında
                new Student { StudentId = 2, Name = "Ayşe", ClassId = 2 }, // Ayşe Türkçe sınıfında
                new Student { StudentId = 3, Name = "Mehmet", ClassId = 1 }, // Mehmet Matematik sınıfında
                new Student { StudentId = 4, Name = "Fatma", ClassId = 3 }, // Fatma Kimya sınıfında
                new Student { StudentId = 5, Name = "Ahmet", ClassId = 2 } // Ahmet Türkçe sınıfında
            };

        // Sınıf verilerini oluşturuyoruz.
        List<Class1> classes = new List<Class1>
            {
                new Class1 { ClassId = 1, ClassName = "Matematik" }, // Matematik sınıfı
                new Class1 { ClassId = 2, ClassName = "Türkçe" }, // Türkçe sınıfı
                new Class1 { ClassId = 3, ClassName = "Kimya" } // Kimya sınıfı
            };

        // LINQ Group Join işlemi:
        // Bu sorgu her sınıfın öğrencilerini gruplandırır.
        var groupJoin = from c in classes // Her sınıf için...
                        join s in students // Öğrencileri sınıflarla eşleştir
                        on c.ClassId equals s.ClassId // ClassId'ler üzerinden eşleşme yap
                        into studentGroup // Her sınıf için bir öğrenci grubu oluştur
                        select new
                        {
                            ClassName = c.ClassName, // Sınıfın adı
                            Students = studentGroup // O sınıfa ait öğrenciler grubu
                        };

        // Sonuçları ekrana yazdırıyoruz.
        foreach (var group in groupJoin) // Her sınıf ve ilgili öğrenciler için
        {
            Console.WriteLine($"Sınıf: {group.ClassName}"); // Sınıf adını yazdır
            foreach (var student in group.Students) // O sınıfa ait öğrenciler için
            {
                Console.WriteLine($"  Öğrenci: {student.Name}"); // Öğrenci adını yazdır
            }
        }
    }
}
