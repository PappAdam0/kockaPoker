using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace kockaPoker
{
    class Program
    {
        static void Main(string[] args)
        {
            Dobas d = new Dobas(1,1,1,3,4);
            //d.EgyDobas();
            d.Kiiras();
            d.Erteke();
            Console.WriteLine(d.Erteke());

            Console.ReadKey();
        }
    }
}
