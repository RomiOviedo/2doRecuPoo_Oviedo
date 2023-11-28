using RecuPoo.Entidades;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RecuPoo.Datos
{
    public static class Billetera
    {
        private static  List<Moneda> moneda;


        public static void AgregarMoneda(Moneda m)
        {
            if (m is Dolar )
            {
                if (m.ValorEnDolares > 200)
                {
                    throw new Exception("No puede comprar más de 200 dólares");
                }

            }
            if (m is Crypto )
            {
                moneda.Add(m);

            }
            moneda.Add(m);



        }
               
                
                
         static Billetera()
        {
            moneda = new List<Moneda>();
        }

        public static string MostrarMonedas(double ValorDolar)
        {
            string info = "";

            foreach (var item in moneda)
            {
                if (item is Dolar d)
                {
                    info += $"{d.GetType().Name},  Valor En Dolares:  {d.ValorEnDolares}\n";
                }
                if (item is Crypto c)
                {
                    info += $"{c.GetType().Name}, Valor En Dolares: {c.ValorEnDolares}\n";
                }

            }
                return info;




        }












    }
}
