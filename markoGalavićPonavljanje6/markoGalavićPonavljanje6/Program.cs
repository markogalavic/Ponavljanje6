using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markoGalavićPonavljanje6
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj1=0;
            int broj2 = 0;
            int broj3 = 0;
            int broj4 = 0;
            int broj5 = 0; 
            int broj6 = 0;
            Console.WriteLine("Unesite sest brojeva");
            broj1 = Convert.ToInt32(Console.ReadLine());
            broj2 = Convert.ToInt32(Console.ReadLine());
            broj3 = Convert.ToInt32(Console.ReadLine());
            broj4 = Convert.ToInt32(Console.ReadLine());
            broj5 = Convert.ToInt32(Console.ReadLine());
            broj6 = Convert.ToInt32(Console.ReadLine());

            if (broj1 > broj2 || broj1 > broj3 || broj1 > broj4 || broj1 > broj5 || broj1 > broj6)
            {
                Console.WriteLine(broj1 + "je najveci");
            }
            if (broj2 > broj1 || broj2 > broj3 || broj2 >broj4 || broj2 > broj5 || broj2 > broj6)
            {
                Console.WriteLine(broj2 + "je najveci");
            }
            if (broj3 > broj1 || broj3 > broj2 || broj3 > broj4 || broj3 > broj5 || broj3 > broj6)
            {
                Console.WriteLine(broj3 + "je najveci");
            }
            if (broj4 > broj1 || broj4 > broj2 || broj4 > broj5 || broj4 > broj5 || broj4 > broj6)
            {
                Console.WriteLine(broj4 + "je najveci");
            }
            if (broj5 > broj1 || broj5 > broj2 || broj5 > broj3 || broj5 > broj4 || broj5 > broj6)
            {
                Console.WriteLine(broj5 + "je najveci");
            }
            if (broj6 > broj1 || broj6 > broj2 || broj6 > broj3 || broj6 > broj4 || broj6 > broj5)
            {
                Console.WriteLine(broj6 + "je najveci");
            }
            Console.ReadKey();
        }
    }
}
