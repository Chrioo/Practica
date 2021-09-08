using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_de__clase
{
    class Practica
    {
        static void Main(string[] args)
        {
            int dato = 1;
            while (dato == 1)
            {
                Console.WriteLine("Coloca el dogotp para sacar tu dinero");
                int x = Convert.ToInt32(Console.ReadLine());
                if (x % 5 == 0)
                {
                    Console.WriteLine("Puedes obtener tu dinero");
                    Console.ReadLine();
                 }
                else
                {
                    Console.WriteLine("Error no puedes obtener tu dinero tu dinero");
                    dato = 2;
                    while (dato == 2) ;
                }
            }
            Console.ReadLine();
        }
    }
}

