using System;
using System.Collections.Generic;

namespace Entidades
{
    public class Calculadora
    {
        private string nombreAlumno;
        private Numeracion primerOperando;
        private Numeracion segundoOperando;
        private Numeracion resultado;
        private static ESistema sistema;
        private List<string> operaciones = new List<string>();

        public Calculadora(string nombreAlumno)
        {
            this.nombreAlumno = nombreAlumno;            
        }

        public Calculadora()
        {
            operaciones = new List<string>();
        }

        public Calculadora(): 
        {
            sistema = ESistema.Decimal; 
        }

        public string NombreAlumno
        {
            get { return nombreAlumno; }
            set { nombreAlumno = value; }
        }

        public Numeracion PrimerOperando
        {
            get { return primerOperando; }
            set { primerOperando = value; }
        }

        public Numeracion SegundoOperando
        {
            get { return segundoOperando; }
            set { segundoOperando = value; }
        }

        public Numeracion Resultado
        {
            get { return resultado; }            
        }
                

        public List<string> Operaciones
        {
            get { return operaciones; }            
        }
    }


}
