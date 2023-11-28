using RecuPoo.Datos;
using RecuPoo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuPoo_Oviedo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello, Billetera!");

                var bitCoin = new Crypto(Crypto.TipoCripto.Bitcoin, 5);
                var ethereum = new Crypto(Crypto.TipoCripto.Ethereum, 10);


                var dolares100 = new Dolar(100);
                var dolares50 = new Dolar(50);


                Billetera.AgregarMoneda(bitCoin);
                Billetera.AgregarMoneda(ethereum);
                Billetera.AgregarMoneda(dolares100);
                Billetera.AgregarMoneda(dolares50);


                Console.WriteLine(Billetera.MostrarMonedas(300));


                var dolares1000 = new Dolar(1000);
                Billetera.AgregarMoneda(dolares1000);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
