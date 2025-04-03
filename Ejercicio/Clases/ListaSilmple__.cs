using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio.Clases
{
    class ListaSilmple__
    {
        private Nodo pri = null;
        private Nodo ulti = null;
        public void Insertar(int num)
        {
            Nodo nuevo = new Nodo();
            nuevo.Numero = num;
            if (pri == null)
            {
                pri = nuevo;
                pri.Sgte = null;
            }
            else
            {
                Nodo actual = pri;
                while (actual.Sgte != null)
                {
                    actual = actual.Sgte;
                }
                actual.Sgte = nuevo;
            }

                
        }
        public void listar(ListBox lsbboxLis)
        {
            Nodo actual = pri;
            while (actual != null)
            {
                lsbboxLis.Items.Add(actual.Numero);
                actual = actual.Sgte;
            }
        }
        public void eliminar(int num)
        {
            Nodo actual = pri;
            Nodo ant = null;
            while (actual != null)
            {
                if (actual.Numero==num)
                {
                    if (actual == pri)
                    {
                        pri = pri.Sgte;
                    }
                    else
                    {
                        ant.Sgte = actual.Sgte;
                    }
                    return;
                }
                ant = actual;
                actual = actual.Sgte;
            }
        }
        public void Ordenar()
        {
            Nodo actual = pri;

            while (actual != null)
            {
                Nodo sig = actual.Sgte;
                while (sig != null)
                {
                    if (actual.Numero > sig.Numero)
                    {
                        int temp = actual.Numero;
                        actual.Numero = sig.Numero;
                        sig.Numero = temp;
                    }
                    sig = sig.Sgte;
                }
                actual = actual.Sgte;
            }
        }
        public bool buscar(int valor_buscar)
        {
            Nodo actual = pri;
            while (actual != null)
            {
                if (actual.Numero == valor_buscar)
                {
                    return true;
                }
                actual = actual.Sgte;
            }
            return false;

        }

    }
}
