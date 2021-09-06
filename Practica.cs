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
                Console.WriteLine("Coloca un valor a sacar tu dinero");
                int x = Convert.ToInt32(Console.ReadLine());

                if (x % 5 == 0)
                {
                    Console.WriteLine("Puedes sacar tu dinero");
                }
                else
                {
                    Console.WriteLine("Erro no puedes sacar tu dinero");
                    dato = 2;
                }
            }

            Console.ReadLine();

        }
    }
}
