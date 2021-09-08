using Programa_de_desucnetos.Descuentos;

namespace Programa_de_descuentos.Compra1
{
    internal class Clscompras
    {
        public Clscompras(double compra, int dia);
     
        public class NClsCompras
        {
            NClsDescuentos desc = new NClsDescuentos();
            internal static double ClsDescuentos;
            public string Descuento(NClsCompras clsCompra)
            {
                double descuento = clsCompra.Descuento;

                if (clsCompra.Dia == 3 || clsCompra.Dia == 5)
                {
                    clsCompra.Descuento = (clsCompra.Compra * 0.15);
                    clsCompra.Total = (clsCompra.Compra - clsCompra.Descuento);
                    return " El valor de su compra es de\n " + clsCompra.Compra + " con el descuento aplicado su total es de  " + clsCompra.Total;
                }
                else if (clsCompra.Dia == 1 || clsCompra.Dia == 2 || clsCompra.Dia == 4 || clsCompra.Dia == 6 || clsCompra.Dia == 7)
                {
                    clsCompra.Total = (clsCompra.Compra);
                    return " nose aplico al descuento\n" +
                        " el valor total de su compra es " + clsCompra.Total;

                }
                else
                {
                    return "has seleccionado un dia invalido";
                }
            }
        }
    }
  }
  } 
 }
 