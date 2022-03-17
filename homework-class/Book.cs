using System;


namespace homework_class
{
    public  class Book:Product
    {
        public string Genre;


      
        public Book(string genre, int no, string name, int price, int count):base(no, name,price,count)
        {
            Genre = genre;
        }

        public void InfoBooks()
        {
            Console.WriteLine($"\nNumber:{No}\nName:{Name}\nPrice:{Price}\nGenre:{Genre}");
        }
        
    }
}
