using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Inheritance
{
  
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
