using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool romperWhile=false;
            List<int> numeros = new List<int>();
            while (romperWhile == false)
            {
                Console.WriteLine("Ingrese un numero:");
                int num = int.Parse(Console.ReadLine());
                numeros.Add(num);
                Console.WriteLine("Desea agregar otro numero? S/N");
                string op = Console.ReadLine().ToUpper();
                if (op == "N")
                {
                    romperWhile = true;
                }
                Console.Clear();
            }

            IEnumerable<int> numMay20 = from n in numeros
                                        where n > 20
                                        select n;

            foreach(int n in numMay20)
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();
        }
    }
}
