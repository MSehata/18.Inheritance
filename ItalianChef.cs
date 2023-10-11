using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Inheritance
{

    internal class ItalianChef : chef
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
}
