using System;
using System.Collections.Generic;
using System.Text;

namespace GiraffeTutorial
{
    class ItalianChef : Chef
    {
        public void MakePasta()
        {
            Console.WriteLine("Chef makes Pasta");
        }

        public override void MakeSpecialDish()
        {
            Console.WriteLine("Chef makes Pasta spaghetti");
        }

    }
}
