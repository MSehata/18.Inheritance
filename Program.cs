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
    internal class ItalianChef:chef
    {
        public void MakesPasta()
        {
            Console.WriteLine("Makes Pasta");
        }

        public override void MakeSpecialDish() 
        {
            Console.WriteLine("The chef make special italian special");           
        }
        
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            chef chef = new chef();
            chef.makeChicken();
           
            ItalianChef chef1 = new ItalianChef();
            chef1.MakesPasta();
            chef1.MakeSpecialDish();

            Console.Read();
        }
    }
}
