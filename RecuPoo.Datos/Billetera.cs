using RecuPoo.Entidades;
using System;
using System.Collections.Generic;

namespace RecuPoo.Datos
{
    public static class Billetera
    {
        private static List<Moneda> moneda;


        public static void AgregarMoneda(Moneda m)
        {
            if (m is Dolar)
            {
                if (m.ValorEnDolares > 200)
                {
                    throw new Exception("No puede comprar más de 200 dólares");
                }

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
                    info += $"{item.MostrarMoneda(ValorDolar)}\n";
                }
                if (item is Crypto c)
                {
                    info += $"{c.GetType().Name}, {item.MostrarMoneda(ValorDolar)}\n";
                }

            }
            return info;




        }












    }
}
