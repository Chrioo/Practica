using Programa_de_descuentos.Compra1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_de_desucnetos.Descuentos
{
    class NClsDescuentos
    {
        private int dia;
        private double compra;
        private double descuento;
        private double total;

        public NClsDescuentos()
        {
        }

        public NClsDescuentos(int dia, double compra)
        {
            this.dia = dia;
            this.compra = compra;
        }
        public NClsDescuentos(int dia, double compra, double descuento, double total)
        {
            this.dia = dia;
            this.compra = compra;
            this.descuento = descuento;
            this.total = total;
        }

        public int Dia { get => dia; set => dia = value; }
        public double Compra { get => compra; set => compra = value; }
        public double Descuento { get => descuento; set => descuento = value; }

        internal bool NClsDescuento(Clscompras clsCompra)
        {
            throw new NotImplementedException();
        }

        internal bool NClsDescuento(NClscompras clsCompra)
        {
            throw new NotImplementedException();
        }

        public double Total { get => total; set => total = value; }
    }
}
