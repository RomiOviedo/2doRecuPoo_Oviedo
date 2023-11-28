namespace RecuPoo.Entidades
{
    public abstract class Moneda
    {

        protected double cantidad;

        public virtual double ValorEnDolares { get => cantidad; }



        public Moneda(double cantidad)
        {
            this.cantidad = cantidad;
        }




        public abstract string MostrarMoneda(double precioDolar);














    }
}
