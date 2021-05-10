using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Provincias = new string[24];
            Provincias[1] = "Capital Federal";  Provincias[13] = "Mendoza";
            Provincias[0]= "Buenos Aires";      Provincias[12] = "Misiones";
            Provincias[3] = "Chaco";            Provincias[15] = "Neuquén";
            Provincias[2] = "Catamarca";        Provincias[14] = "Río Negro";
            Provincias[4] = "Chubut";           Provincias[16] = "Salta";
            Provincias[5] = "Córdoba";          Provincias[17] = "San Juan";
            Provincias[6] = "Corrientes";       Provincias[18] = "San Luis";
            Provincias[7] = "Entre Ríos";       Provincias[19] = "Santa Cruz";
            Provincias[8] = "Formosa";          Provincias[20] = "Santa Fe";
            Provincias[9] = "Jujuy";            Provincias[21] = "Santiago del Estero";
            Provincias[10] = "La Pampa";        Provincias[22] = "Tierra del Fuego";
            Provincias[11] = "La Rioja";        Provincias[23] = "Tucumán";

            List<string> provinciasArgentina = (from p in Provincias
                                                where p.StartsWith("S") || p.StartsWith("T")
                                                select p).ToList();
            
            foreach(string provin in provinciasArgentina)
            {
                Console.WriteLine(provin);
            }
            Console.ReadKey();
            
        }
    }
}
