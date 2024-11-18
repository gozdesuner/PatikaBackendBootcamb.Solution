namespace _7.Week_Pratik_4_Linq_Join;
public class Program
{
    public static void Main()
    {
        var authors = new List<Author>
        {
            new()
            {
                AuthorId = 1,
                Name = "Orhan Pamuk"
            },
            new Author
            {
                AuthorId = 2,
                Name = "Elif Şafak"
            },
            new Author
            {
                AuthorId = 3,
                Name = "Ahmet Ümit"
            }

        };

        var books = new List<Book>
        { new Book
        {
            BookId = 1,
            Title = "Kar",
            AuthorId = 1
        },
            new Book
            {
                BookId = 2,
                Title = "Masumiyet Müzesi",
                AuthorId = 1
            },
            new Book
            {
                BookId = 3,
                Title = "10 Minutes 38 Seconds in This Strange World",
                AuthorId = 2
            },
            new Book
            {
            BookId = 4,
            Title = "Beyoğlu Rapsodisi",
            AuthorId = 3
            }
        };
        var title = from book in books//Kitap listesinden (books) bir kitap (book) seçilir.
                    join author in authors//Yazarlar listesi (authors) ile kitaplar birleştirilir.
                    on book.AuthorId equals author.AuthorId//Birleştirme koşulu olarak kitapların AuthorId değeri ile yazarların AuthorId değeri eşitlenir.
                    select new//Yeni bir anonim nesne oluşturulur. 
                    {
                        BookTitle = book.Title,//Kitabın başlığını (Title) içerir.
                        AuthorName = author.Name//Yazarın adını(Name) içerir
                    };
        foreach (var result in title)//LINQ sorgusundan dönen her bir anonim nesneyi (result) döngüyle işler.Her kitap ve yazar ilişkisi ekrana yazdırılır.
        {
            Console.WriteLine($"Kitap: {result.BookTitle}, Yazar: {result.AuthorName}");
        }
        Console.ReadKey();
    }


}

