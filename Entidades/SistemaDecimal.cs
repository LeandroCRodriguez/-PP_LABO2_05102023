using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaDecimal : Numeracion
    {
        public SistemaDecimal(string valor) : base(valor)
        {

        }

        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            this.sistema = sistema;
            return this;
        }

        public SistemaBinario DecimalABinario()
        {
            if (double.TryParse(valor, out double valorDecimal) && valorDecimal > 0)
            {
                int valorEntero = (int)Math.Floor(valorDecimal); // Obtiene la parte entera
                return new SistemaBinario(valorEntero);
            }
            else
            {
                msgError = "El valor no es válido para la conversión a binario.";
                return null; // Devuelve null para indicar que no se pudo realizar la conversión
            }
        }

        public bool EsNumeracionValida(string valor)
        {
            if(valor != null && double.TryParse(valor, out double valorDecimal))
            {
                return valorDecimal >= 0;
            }
            return false;        
        }

        public bool EsSistemaDecimalValido(string valor)
        {
            double valorDouble;
            return double.TryParse(valor, out valorDouble);
        }
        internal override double ValorNumerico
        {
            get
            {
                SistemaBinario sistemaDecimal = new SistemaBinario(valor);
                return sistemaDecimal.ValorNumerico;
            }
        }
        public static implicit operator SistemaDecimal(double valorDouble)
        {
            return new SistemaDecimal(valorDouble.ToString());
        }


        public static implicit operator SistemaDecimal(string valorString)
        {
            return new SistemaDecimal(valorString);
        }

    }
}
