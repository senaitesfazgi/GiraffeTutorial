using System;

namespace GiraffeTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Creating objects of a class book with parameters sent to the constructor 
             Book book1 = new Book("Living Courageously", "Joyce Meyer", 250);  
             Book book2 = new Book("Mere Christianity", "C.S Lewis", 200);
             Book book3 = new Book("The Reason for my Hope ", "Billy Graham", 200);

             book2.title = "The Risen";

             Console.WriteLine(book1.title);
             Console.WriteLine(book2.title);
            */
            /*
             * creating the objects of a class song with parameters sent to the constructor
             Song song1 = new Song("You never lost a battle", "Tauran Wells", 5);
            *Accessing a static attribute using classname as it is not accessed using object.
             Console.WriteLine(Song.songCount);
             Song song2 = new Song("So will I", "HILL Song", 5);

             *Accessing a static attribute using a object by returning it inside a method.
             Console.WriteLine(song2.getSongCount());

              Console.WriteLine(song1.title);  
              Console.WriteLine(song1.artist);

             * Instantiating objects is not possible to call static classes like this.
             UsefulTools.SayHi("Senai");


             Chef chef = new Chef();
            // chef.MakeChicken();
             chef.MakeSpecialDish();

             ItalianChef italianchef = new ItalianChef();
             //italianchef.MakeChicken();
             //italianchef.MakePasta();
             italianchef.MakeSpecialDish();
            */

            // very good example of getters and setters in this example
            Movie avengers = new Movie("The Avengers", "Josh Whedon", "PG-13");
            Movie shrek = new Movie("Shrek", "Adam Admson", "Dog");

            // G, PG, PG-13, R, NR
            Console.WriteLine(shrek.Rating);


            Console.ReadLine();





        }

    }
}
