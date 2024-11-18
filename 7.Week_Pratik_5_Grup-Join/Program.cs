namespace _7.Week_Pratik_5_Grup_Join;

public class Program
{
    public static void Main()
    {
        List<Student> students = new List<Student>
    {
        new Student { StudentId = 1, Name = "Ali", ClassId = 1 },
        new Student { StudentId = 2, Name = "Ayşe", ClassId = 2 },
        new Student { StudentId = 3, Name = "Mehmet", ClassId = 1 },
        new Student { StudentId = 4, Name = "Fatma", ClassId = 3 },
        new Student { StudentId = 5, Name = "Ahmet", ClassId = 2 },

    };

        List<Class1> classes = new List<Class1>
    {
        new Class1 { ClassId = 1, ClassName = "Matematik" },
        new Class1 { ClassId = 2, ClassName = "Türkçe" },
        new Class1 { ClassId = 3, ClassName = "Kimya" }
    };
        var groupJoin = from c in classes
                        join s in students on c.ClassId equals s.ClassId into studentGroup
                        select new
                        {
                            ClassName = c.ClassName,
                            Students = studentGroup
                        };
        foreach (var group in groupJoin)
        {
            Console.WriteLine($"Sınıf:{group.ClassName}");

            foreach (var student in group.Students)
            {
                Console.WriteLine($"Öğrenci:{student.Name}");
            }
        }

    }
}




