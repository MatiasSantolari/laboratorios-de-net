using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool bandera = false;
            List<Empleado> empleados = new List<Empleado>();

            while (bandera == false)
            {
                Empleado emp = new Empleado();
                Console.WriteLine("Ingrese el Id del empleado:");
                emp.Id = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el Nombre del empleado:");
                emp.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el Sueldo del empleado:");
                emp.Suledo = decimal.Parse(Console.ReadLine());
                empleados.Add(emp);
                Console.WriteLine("Desea ingresar un nuevo empleado? S/N");
                string op = Console.ReadLine().ToUpper();
                if (op == "N")
                {
                    bandera = true;
                }
                Console.Clear();
            }

            Console.WriteLine("De forma acendente:");
            var emple = from Empleado e in empleados
                        orderby e.Suledo ascending
                        select e;

            Console.WriteLine("----------------------------");
            Console.WriteLine("|id      |Nombre     |Sueldo");
            Console.WriteLine("----------------------------");
            foreach (var e in emple)
            {
                Console.WriteLine("|" + e.Id + "   |" + e.Nombre + "    |" + e.Suledo + "|");
                Console.WriteLine("----------------------------");
            }
            
            Console.WriteLine(" ");

            Console.WriteLine("De forma decendente:");
            var emple2 = from Empleado e in empleados
                         orderby e.Suledo descending
                         select e;

            Console.WriteLine("----------------------------");
            Console.WriteLine("|id      |Nombre     |Sueldo");
            Console.WriteLine("----------------------------");
            foreach (var e in emple2)
            {
                Console.WriteLine("|" + e.Id + "   |" + e.Nombre + "    |" + e.Suledo + "|");
                Console.WriteLine("----------------------------");
            }
            Console.ReadKey();
        }
    }
}
