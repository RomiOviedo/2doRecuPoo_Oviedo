using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuPoo.Entidades
{
    public class Dolar : Moneda
    {
        public Dolar(double cantidad) : base(cantidad)
        {
        }

        public override string MostrarMoneda(double precioDolar)
        {
            return $"Dolares: cantidad:{this.cantidad}, cotizacion:210, precio en pesos:{PrecioEnPesos(precioDolar)} ";
        }


        private double PrecioEnPesos(double precioDolar)
        {

            return this.cantidad * (precioDolar * 0.3);
            
        }


      
    }
}
