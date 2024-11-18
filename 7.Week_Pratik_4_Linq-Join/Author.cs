namespace _7.Week_Pratik_4_Linq_Join
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }

    }
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
    }
}
