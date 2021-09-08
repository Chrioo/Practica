using Programa_de_descuentos.Compra1;
using Programa_de_desucnetos.Descuentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Programa_de_descuentos.Compra1.Clscompras;

namespace Programa_de_desucnetos
{
    class Program
    {
        private static object print;

        static void Main(string[] args)
        {
            Console.WriteLine("ingrse el valor de la compra ");
            double Compra = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ingrese un numero del 1 al 7 para definir que dia dela semana\n " +
                " tomando en cuenta que domingo es representado por el numero 1 ");
            int Dia = int.Parse(Console.ReadLine());

            Clscompras clsCompra = new Clscompras(Compra, Dia);
            NClsDescuentos NClsCompra = new NClsDescuentos();
           
            Console.WriteLine(NClsCompra.NClsDescuento(clsCompra));
            Console.ReadLine();

        }

        

     
            }
        }
 
   
