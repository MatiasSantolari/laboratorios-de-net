using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Laboratorio3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList provinc = new ArrayList();
            Provincias provincia1 = new Provincias { Nombre = "Rosario", CodigoPostal = 2000, Clave = "ros" }; provinc.Add(provincia1);
            Provincias provincia2 = new Provincias { Nombre = "Santa Fe", CodigoPostal = 3000, Clave = "stf" }; provinc.Add(provincia2);
            Provincias provincia3 = new Provincias { Nombre = "Rawson", CodigoPostal = 9103, Clave = "raw" }; provinc.Add(provincia3);
            Provincias provincia4 = new Provincias { Nombre = "Cordoba", CodigoPostal = 5000, Clave = "cba" }; provinc.Add(provincia4);
            Provincias provincia5 = new Provincias { Nombre = "Corrientes", CodigoPostal = 3400, Clave = "cor" }; provinc.Add(provincia5);
            Provincias provincia6 = new Provincias { Nombre = "Neuquen", CodigoPostal = 8300, Clave = "neu" }; provinc.Add(provincia6);
            Provincias provincia7 = new Provincias { Nombre = "Mendoza", CodigoPostal = 5500, Clave = "men" }; provinc.Add(provincia7);
            Provincias provincia8 = new Provincias { Nombre = "Posadas", CodigoPostal = 3300, Clave = "pos" }; provinc.Add(provincia8);
            Provincias provincia9 = new Provincias { Nombre = "Salta", CodigoPostal = 4400, Clave = "sal" }; provinc.Add(provincia9);
            Provincias provincia10 = new Provincias { Nombre = "San Luis", CodigoPostal = 57, Clave = "slu" }; provinc.Add(provincia10);

            Console.WriteLine("Ingrese la clave de la provincia");
            string clav = Console.ReadLine().ToLower();
            Console.Clear();

            var Provin = from Provincias prov in provinc
                         where prov.Clave == clav
                         select prov;

            foreach(var pr in Provin)
            {
                Console.WriteLine("Nombre:"+pr.Nombre+"    Codigo Postal:"+pr.CodigoPostal);
            }
            Console.ReadKey();


        }
    }
}
