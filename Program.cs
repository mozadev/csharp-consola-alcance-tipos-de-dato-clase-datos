using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursocgato2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte bt = 255;
            short st = 3255;
            int entero = 21333644;
            long l = 222555555;
            // punto flotante 
            float fl = 3.1416f;
            double db = 45.124321;

            Console.WriteLine("byte " + byte.MinValue + " " + byte.MaxValue);//alcance del tipo de dato byte
            Console.WriteLine("float " + float.MinValue + " " + float.MaxValue);//alcance del tipo de dato byte
            Console.WriteLine("short " + short.MinValue + " " + short.MaxValue);//alcance del tipo de dato byte

            Console.WriteLine("ingrese el valor entero a capturar:");
            entero = int.Parse(Console.ReadLine());
            Console.WriteLine("el valor entero capturado por la consola es:" + entero);
            Console.WriteLine("ingrese el valor float a capturar:");
            fl = float.Parse(Console.ReadLine());
            Console.WriteLine("el valor float  capturado por la consola es:" + fl);

            // datos d = new datos("cesar moza",30);
            //// Console.WriteLine("escribe tu nombre: ");
            // //setNombre(String readline);
            //// d.setNombre(Console.ReadLine());
            // //Console.WriteLine("el nombre capturado es:"+d.getNombre());


            // Console.WriteLine("el nombre es:"+d.getNombre());
            // Console.WriteLine("la edad es:"+d.getEdad());



            Console.ReadKey();
        }
    }
}
