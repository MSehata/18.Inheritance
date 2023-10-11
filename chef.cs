using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Inheritance
{   

    internal class chef
    {
        public void makeChicken()
        {
            Console.WriteLine("The chef makes Chicken");
        }

        public void makeSalad()
        {
            Console.WriteLine("The chef makes Salad");
        }

        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The chef makes Special Dish");
        }

    }
}
