using System;

namespace homework_class
{
    internal class Program
    {
        static void Main(string[] args)
        {




            int NumberOfBooks = GetInputCount("Please, write how many books do you need:");

            Book[] books = new Book[NumberOfBooks];
            for (int i = 0; i < NumberOfBooks; i++)
            {

                int no = GetInputInt("\nPlease, write Number the book:");

                string name = GetInputStr($"\nPlease,write the Name of the {no} book:");

                int price = GetInputInt($"\nPlease, write the Price of the {no} book:");

                string genre = GetInputStr($"\nPlease, write the Genre of the {no} book:");

                books[i] = new Book(genre, no, name, price, NumberOfBooks);

            }

            foreach (var item  in books)
            {
               item.InfoBooks();
            }



            Сhoice(books);

        }
        static string GetInputStr(string sentence)
        {
            string input;
            Console.Write(sentence);
            input = Console.ReadLine();
            return input;

        }
        static int GetInputCount(string sentence)
        {
            int input;
            Console.Write(sentence);
            input = Convert.ToInt32(Console.ReadLine());
            return input;
        }
        static int GetInputInt(string sentence)
        {
            int input;
            Console.Write(sentence);
            input = Convert.ToInt32(Console.ReadLine());

            return input;
        }
        static void Сhoice(Book[] books)
        {
          
            int choice = 0;
            do
            {
                Console.Write("\n1.Filter the books according the price\n2.Show all books \n0.Close the program:\n");
                var StringValue = Console.ReadLine();
                while (!int.TryParse(StringValue, out choice))
                {
                    Console.Write("\n1.The price filter of books is blood \n2.Show all books \n0.Close the program:\n");
                    StringValue = Console.ReadLine();
                }
                switch (choice)
                {

                    case 1:
                        Console.Write("\nplease,write minPrice:");
                        int minPrice = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nplease,write maxPrice:");
                        int maxPrice = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < books.Length; i++)
                        {
                            Book pr = books[i];
                            if (pr.Price <= minPrice || pr.Price <= maxPrice)
                            {
                                Console.WriteLine($"\nNumber:{pr.No}\nName:{pr.Name}\nPrice:{pr.Price}\nGenre:{pr.Genre}");
                            }
                        }
                        break;
                    case 2:

                        foreach (var item in books)
                        {
                            Book pr = item;
                            Console.WriteLine($"\nNumber:{pr.No}\nName:{pr.Name}\nPrice:{pr.Price}\nGenre:{pr.Genre}");
                        }
                        break;
                    case 0:
                        Console.WriteLine("\nGood bay :)");
                        break;
                }
            } while (choice < 0 || choice > 2);
        }

        
    }
}
