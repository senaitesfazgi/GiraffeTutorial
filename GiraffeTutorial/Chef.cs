using System;
using System.Collections.Generic;
using System.Text;

namespace GiraffeTutorial
{
    class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The Chef Makes Chicken");
        }
        public void MakeSalad()
        {
            Console.WriteLine("The Chef makes Salad");
        }
         public virtual void MakeSpecialDish()
        {
            Console.WriteLine("Chef makes bbq ribs");
        }
    }
}
