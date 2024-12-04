using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doga12._04
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Add meg az évszámot: ");
            int szsz = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Add meg a halál évszámát: ");
            int hasz = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Add meg a nevet: ");
            string nev = Convert.ToString(Console.ReadLine());

            int idos = hasz - szsz;
            Console.WriteLine($"Enyi idősen hallt meg {nev}: {idos} ");

            Console.ReadKey();

      


        }
    }
}
