using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TA30_01.Controlador;
using TA30_01.Modelo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TA30_01
{
    public partial class Form1 : Form
    {
        //Variable general
        Cliente cl = new Cliente();
        ClienteModelo obtenido = null;
        public Form1()
        {
            InitializeComponent();
            //Las columnas NO son clickables para rellenar los TextBox
            listView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Creamos un Cliente y lo añadimos a la lista
        private void crearCliente(object sender, EventArgs e)
        {
            ClienteModelo modelo = new ClienteModelo(
            bxNombre.Text,
            bxApellido.Text,
            bxDireccion.Text,
            bxDni.Text,
            bxFecha.Text);
            cl.Guardar(modelo);
            bxNombre.Text = "";
            bxApellido.Text = "";
            bxDireccion.Text = "";
            bxDni.Text = "";
            bxFecha.Text = "";
            Mostrar();
        }
        //Obtenemos la lista para mostrarlo en la ListView
        public void Mostrar()
        {
            List<ClienteModelo> lista = cl.Mostrar();
            int listCount = lista.Count;
            //------------
            listView.Items.Clear();
            for (int i = 0; i < listCount; i++)
            {
                ListViewItem item = new ListViewItem(lista[i].Nombre);
                item.SubItems.Add(lista[i].Apellido);
                item.SubItems.Add(lista[i].Direccion);
                item.SubItems.Add(lista[i].Dni);
                item.SubItems.Add(lista[i].Fecha);
                listView.Items.Add(item);
            }
        }

        //Borramos un elemento de la lista, a partir del item seleccionado en la ListView
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                List<ClienteModelo> lista = cl.Mostrar();
                int listCount = lista.Count;
                string elemento = listView.SelectedItems[0].Text;
                for (int i = 0; i < listCount; i++)
                {
                    if (lista[i].Nombre == elemento)
                    {                        
                        lista.Remove(lista[i]);
                        Mostrar();
                    }
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Seleccion no valida");
            }

        }

        //A partir del item seleccionado en la ListView, rellenamos los
        //TextBox que corresponde
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                List<ClienteModelo> lista = cl.Mostrar();
                ClienteModelo cm = null;
                int listCount = lista.Count;
                string elemento = listView.SelectedItems[0].Text;
                for (int i = 0; i < listCount; i++)
                {
                    if (lista[i].Nombre == elemento)
                    {
                        obtenido = lista[i];
                        cm = lista[i];
                        bxNombre.Text = lista[i].Nombre;
                        bxApellido.Text = lista[i].Apellido;
                        bxDireccion.Text = lista[i].Direccion;
                        bxDni.Text = lista[i].Dni;
                        bxFecha.Text = lista[i].Fecha;
                    }
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Seleccion no valida");
            }

        }

        //Actualizamos el elemento de la lista
        //a partir de los TextBox         
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            List<ClienteModelo> lista = cl.Mostrar();
            int listCount = lista.Count;
            for (int i = 0; i < listCount; i++)
            {
                if (lista[i] == obtenido)
                {
                    lista[i].Nombre = bxNombre.Text;
                    lista[i].Apellido=bxApellido.Text;
                    lista[i].Direccion=bxDireccion.Text;
                    lista[i].Dni=bxDni.Text;
                    lista[i].Fecha=bxFecha.Text;
                    Mostrar();
                }
            }
        }
    }
}
