using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Clases
{
    class Nodo
    {
        private int numero;
        private Nodo sgte;

        public int Numero { get => numero; set => numero = value; }
        internal Nodo Sgte { get => sgte; set => sgte = value; }
    }
}
