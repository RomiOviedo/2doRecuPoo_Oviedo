using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuPoo.Entidades
{
    public class Crypto : Moneda
    {
        private TipoCripto tipoCripto;

        public override double ValorEnDolares 
        {
            get
            {
                if (this.tipoCripto == TipoCripto.Ethereum)
                {
                    return this.cantidad * 1200;
                }

                else if (this.tipoCripto == TipoCripto.Bitcoin)
                {
                    return this.cantidad * 17000;
                }
                return 0;
            }

        }


        public Crypto(double cantidad) : base(cantidad)
        {
            tipoCripto = new TipoCripto();
        }

        public Crypto( TipoCripto tipoCripto, double Cantidad) :this(Cantidad)
        {
            this.tipoCripto = tipoCripto;
        }



        public override string MostrarMoneda(double precioDolar)
        {

            string info = "";
            info+= $"tipo:{this.tipoCripto}, cantidad:{this.cantidad}, Valor en dolares:{ValorEnDolares} ";

            if (this.tipoCripto==TipoCripto.Ethereum)
            {
                info += $", precio en pesos: {this.cantidad*735606}";
            }
            if (this.tipoCripto == TipoCripto.Bitcoin)
            {
                info += $", precio en pesos: {this.cantidad * 13000000}";
            }
            return info;
        }

        public enum TipoCripto
        {
            Ethereum,
            Bitcoin

        }
    }
}
