using System;

namespace GiraffeTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Living Courageously", "Joyce Meyer", 250);  
            Book book2 = new Book("Mere Christianity", "C.S Lewis", 200);
            Book book3 = new Book("The Reason for my Hope ", "Billy Graham", 200);

            book2.title = "The Risen";

            Console.WriteLine(book1.title);
            Console.WriteLine(book2.title);

            Song song1 = new Song("You never lost a battle", "Tauran Wells", 5);
            Console.WriteLine(Song.songCount);
            Song song2 = new Song("So will I", "HILL Song", 5);
            Console.WriteLine(song2.getSongCount());

            // Console.WriteLine(song1.title);  
            // Console.WriteLine(song1.artist);


            UsefulTools.SayHi("Senai");


            Chef chef = new Chef();
           // chef.MakeChicken();
            chef.MakeSpecialDish();

            ItalianChef italianchef = new ItalianChef();
            //italianchef.MakeChicken();
            //italianchef.MakePasta();
            italianchef.MakeSpecialDish();



            Console.ReadLine();





        }

    }
}
