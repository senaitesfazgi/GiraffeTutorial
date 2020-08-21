using System;

namespace GiraffeTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Living Courageously", "Joyce Meyer", 250);

            Book book2 = new Book("Mere Christianity", "C>S Lewis", 200);

            Console.WriteLine(book1.title);
            Console.WriteLine(book2.title);

            Console.ReadLine();


        }

    }
}
