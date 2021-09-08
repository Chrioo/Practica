using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        { private static object print;

        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el valor de compra ");
            double Compra = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ingrese un numero del 1 al 7 para definir que dia de la semana es  " +
                " tomando en cuenta que domingo es tiene el valor del numero 1 ");
            int Dia = int.Parse(Console.ReadLine())
            Clscompras clsCompra = new Clscompras(Compra, Dia);
            NClsDescuentos NClsCompra = new NClsDescuentos();
            Console.WriteLine(NClsCompra.NClsDescuento(clsCompra));
            Console.ReadLine();

        }
    }
}
