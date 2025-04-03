using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio
{
    public partial class Frm_ListaEnlazadaSimple: Form
    {
        Clases.ListaSilmple__ listaa = new Clases.ListaSilmple__();
        public Frm_ListaEnlazadaSimple()
        {
            InitializeComponent();
        }

        private void btn_insertar_Click(object sender, EventArgs e)
        {
            lsbox_nom.Items.Clear();
            listaa.Insertar(int.Parse(txt_num.Text));
            txt_num.Clear();
            txt_num.Focus();
            listaa.listar(lsbox_nom);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            listaa.eliminar(int.Parse(txt_num.Text));
            lsbox_nom.Items.Clear();
            txt_num.Clear();
            txt_num.Focus();
            listaa.listar(lsbox_nom);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listaa.Ordenar();
            lsbox_nom.Items.Clear();
            listaa.listar(lsbox_nom);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listaa.buscar(int.Parse(txt_num.Text)))
            {
                MessageBox.Show("Numero" + int.Parse(txt_num.Text) +"encontrado");

            }
            else
            {
                MessageBox.Show("Numero" + int.Parse(txt_num.Text)+ "no encontrado");
            }
        }
    }
}
