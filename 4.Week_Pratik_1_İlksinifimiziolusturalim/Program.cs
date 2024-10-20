using _4.Week_Pratik_1_İlksinifimiziolusturalim;
Person student1 = new Person();
student1._name = "Eda";
student1._surname = "Ercan";
student1._date = new DateTime(2001, 6, 10);

Person student2 = new Person();
student2._name = "Selvi";
student2._surname = "Yılmaz";
student2._date = new DateTime(2004, 5, 13);

Person student3 = new Person();
student3._name = "Ergün";
student3._surname = "Can";
student3._date = new DateTime(2005, 8, 22);

Person student4 = new Person();
student4._name = "İbrahim";
student4._surname = "Eray";
student4._date = new DateTime(2002, 2, 12);

Person teacher = new Person();
teacher._name = "Ali";
teacher._surname = "Akdağ";
teacher._date = new DateTime(1965, 3, 13);



Console.WriteLine($"Name:{student1._name} Surname:{student1._surname} Date of birth:{student1._date.ToShortDateString()}");
Console.WriteLine($"Name:{student2._name} Surname:{student2._surname} Date of birth:{student2._date.ToShortDateString()}");
Console.WriteLine($"Name:{student3._name} Surname:{student3._surname} Date of birth:{student3._date.ToShortDateString()}");
Console.WriteLine($"Name:{student4._name} Surname:{student4._surname} Date of birth:{student4._date.ToShortDateString()}");
Console.WriteLine($"Name:{teacher._name} Surname:{teacher._surname} Date of birth:{teacher._date.ToShortDateString()}");