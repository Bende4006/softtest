using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] szinek = { "piros", "kék", "sárga", "zöld", "fekete" };
            int i;
            for (i=0; i<szinek.Length;i++)
            {
                Console.WriteLine(szinek[i]);
            }
            Console.WriteLine("Adj meg egy szint ");
            string szin;
            szin = Console.ReadLine();

            for (i = 0; i < szinek.Length; i++)
            {
                if (szin==szinek[i])
                {
                    Console.WriteLine("van ilyen szin");
                }
            }

            Console.ReadKey();
        }
    }
}
