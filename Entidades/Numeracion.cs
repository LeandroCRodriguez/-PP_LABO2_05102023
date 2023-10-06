namespace Entidades
{
    public enum ESistema { Binario, Decimal}
    public abstract class Numeracion
    {
        protected static string msgError;
        protected string valor;
        protected ESistema sistema;

        protected Numeracion()
        {
            Numeracion.msgError = "Número inválido";
        }
        protected Numeracion(string valorInicial)
        {
            InicializaValor(valorInicial);
        }

        private string InicializaValor(string valorInicial)
        {
            if (EsNumeracionValida(valorInicial))
            {
               return this.valor = valorInicial;
            }
            else
            {
                return this.valor = "Valor no es una numeración válida";
            }
        }
        public string Valor
        {
            get { return valor; }
        }
        internal abstract double ValorNumerico
        {
            get;
        }
        public abstract Numeracion CambiarSistemaDeNumeracion(ESistema sistema);
        protected bool EsNumeracionValida(string valor)
        {
            if(valor is not null) 
            {
                return true;
            }
            return false;
        }

        public static bool operator ==(Numeracion n1, Numeracion n2)
        {
            if (n1.GetType() == n2.GetType() && n1 is not null && n2 is not null)
            {
                return true;
            }

            return false;
        }
        public static bool operator !=(Numeracion n1, Numeracion n2)
        {
            return (n1 == n2);            
        }

        public static explicit operator double(Numeracion n1)
        {
            return n1.ValorNumerico();
        }


    }
}