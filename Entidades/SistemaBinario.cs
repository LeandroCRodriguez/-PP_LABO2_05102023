using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaBinario : Numeracion
    {
        public SistemaBinario(string valor) : base(valor)
        {

        }
        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            this.sistema = sistema;
            return this;
        }

        public bool EsNumeracionValida(string valor)
        {
            if (!string.IsNullOrEmpty(valor))
            {
                if(sistema == ESistema.Binario)
                {
                    return true;
                }
            }            
            return false;
        }

        public bool EsSistemaBinrarioValido()
        {
            foreach (char c in valor)
            {
                if (c != '0' && c != '1')
                {
                    return false;
                }
            }
            return true;
        }            
            
        }
    internal override double ValorNumerico
    {
        get
        {
            SistemaDecimal sistemaDecimal = new SistemaDecimal(valor);
            return sistemaDecimal.ValorNumerico;
        }
    }

    public static implicit operator SistemaBinario(string valorString)
        {
            return new SistemaBinario(valorString);
        }    
}
