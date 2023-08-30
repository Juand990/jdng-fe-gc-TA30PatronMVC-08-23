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
using TA30_02.Controlador;
using TA30_02.Modelo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TA30_02
{
    public partial class Form1 : Form
    {
        //Objetos
        Cliente cl = new Cliente();
        Video vd = new Video();
        //Cliente obtenido del ListView
        ClienteModelo obtenido = null;
        //Video obtenido del ListView
        VideoModelo vdObtenido = null;
        public Form1()
        {
            InitializeComponent();
            listView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ltViewVideo.HeaderStyle = ColumnHeaderStyle.Nonclickable;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Añadimos Cliente a la lista
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
        //Añadimos la ListView de Clientes        
        public void Mostrar()
        {
            List<ClienteModelo> lista = cl.Mostrar();
            int listCount = lista.Count;
            //------------
            listView.Items.Clear();
            for (int i = 0; i < listCount; i++)
            {
                ListViewItem item = new ListViewItem(lista[i].Id.ToString());
                item.SubItems.Add(lista[i].Nombre);
                item.SubItems.Add(lista[i].Apellido);
                item.SubItems.Add(lista[i].Direccion);
                item.SubItems.Add(lista[i].Dni);
                item.SubItems.Add(lista[i].Fecha);
                listView.Items.Add(item);
            }
        }
        //Borramos el Cliente de la lista a partir del elemento clicleado
        //Borramos el Video que coincida con el cliente y el video
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                List<ClienteModelo> lista = cl.Mostrar();
                List<VideoModelo> lsVideo = vd.Mostrar();
                int listvdCount = lsVideo.Count;
                int listCount = lista.Count;
                string elemento = listView.SelectedItems[0].Text;
                for (int i = 0; i < listCount; i++)
                {
                    if (lista[i].Id.ToString() == elemento)
                    {
                        for (int j = 0; j < listvdCount; j++)
                        {
                            if (lsVideo[j].Cli_id == lista[i].Id)
                            {
                                lsVideo.Remove(lsVideo[j]);
                                lista.Remove(lista[i]);
                                MostVideo();
                            }
                        }
                        Mostrar();
                    }
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Seleccion no valida");
            }
        }
        //Rellenamos los TextBox con el Cliente clicado
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                List<ClienteModelo> lista = cl.Mostrar();
                int listCount = lista.Count;
                string elemento = listView.SelectedItems[0].Text;
                for (int i = 0; i < listCount; i++)
                {
                    if (lista[i].Id.ToString() == elemento)
                    {
                        obtenido = lista[i];
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
        //Actualizamos el elemento de la lista, apartir de los TextBox obtenido
        //del boton Mostrar
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            List<ClienteModelo> lista = cl.Mostrar();
            int listCount = lista.Count;
            for (int i = 0; i < listCount; i++)
            {
                if (lista[i] == obtenido)
                {
                    lista[i].Nombre = bxNombre.Text;
                    lista[i].Apellido = bxApellido.Text;
                    lista[i].Direccion = bxDireccion.Text;
                    lista[i].Dni = bxDni.Text;
                    lista[i].Fecha = bxFecha.Text;
                    Mostrar();
                }
            }
        }
        
        //----------Zona Video---------
        //Añadimos Video a la lista
        private void btnCrVideo_Click(object sender, EventArgs e)
        {
            try
            {
                VideoModelo vdModelo = new VideoModelo(
                bxTitulo.Text,
                bxDirector.Text,
                int.Parse(bxIdCliente.Text));
                List<ClienteModelo> lista = cl.Mostrar();
                int listCount = lista.Count;
                bool idEsta = false;
                for (int i = 0; i < listCount; i++)
                {
                    if (lista[i].Id == int.Parse(bxIdCliente.Text))
                    {
                        idEsta = true; break;
                    }
                }
                if (idEsta)
                {
                    vd.Guardar(vdModelo);
                    bxTitulo.Text = "";
                    bxDirector.Text = "";
                    bxIdCliente.Text = "";
                    txtNoID.Text = "";
                    MostVideo();
                }
                else
                {
                    txtNoID.Text = "Este ID de cliente no existe";
                }
            }
            catch (Exception)
            {
                txtNoID.Text = "ID Cliente tiene que ser un numero";
                Console.WriteLine("ID Cliente tiene que ser un numero");
            }

        }
        //Añadimos la ListView de Videos 
        public void MostVideo()
        {
            List<VideoModelo> lista = vd.Mostrar();
            int listCount = lista.Count;
            //------------
            ltViewVideo.Items.Clear();
            for (int i = 0; i < listCount; i++)
            {
                ListViewItem item = new ListViewItem(lista[i].Titulo);
                item.SubItems.Add(lista[i].Director);
                item.SubItems.Add(lista[i].Cli_id.ToString());
                ltViewVideo.Items.Add(item);
            }
        }
        //Borramos el Video de la lista a partir del elemento clicleado
        private void btnBrVideo_Click(object sender, EventArgs e)
        {
            try
            {
                List<VideoModelo> lista = vd.Mostrar();
                int listCount = lista.Count;
                string elemento = ltViewVideo.SelectedItems[0].Text;
                for (int i = 0; i < listCount; i++)
                {
                    if (lista[i].Titulo == elemento)
                    {
                        lista.Remove(lista[i]);
                        MostVideo();
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Seleccion no valida");
            }
        }
        //Rellenamos los TextBox con el Video clicado
        private void btnMsVideo_Click(object sender, EventArgs e)
        {
            try
            {
                List<VideoModelo> lista = vd.Mostrar();
                int listCount = lista.Count;
                string elemento = ltViewVideo.SelectedItems[0].Text;
                for (int i = 0; i < listCount; i++)
                {
                    if (lista[i].Titulo == elemento)
                    {
                        vdObtenido = lista[i];
                        bxTitulo.Text = lista[i].Titulo;
                        bxDirector.Text = lista[i].Director;
                        bxIdCliente.Text = lista[i].Cli_id.ToString();
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Seleccion no valida");
            }
        }
        //Actualizamos el elemento de la lista, apartir de los TextBox obtenido
        //del boton Mostrar(Video)
        private void btnAcVideo_Click(object sender, EventArgs e)
        {
            List<VideoModelo> lista = vd.Mostrar();
            int listCount = lista.Count;
            try
            {
                bool idEsta = false;
                for (int i = 0; i < listCount; i++)
                {
                    if (lista[i].Id == int.Parse(bxIdCliente.Text))
                    {
                        idEsta = true; break;
                    }
                }
                if (idEsta)
                {
                    for (int i = 0; i < listCount; i++)
                    {
                        if (lista[i] == vdObtenido)
                        {
                            lista[i].Titulo = bxTitulo.Text;
                            lista[i].Director = bxDirector.Text;
                            lista[i].Cli_id = int.Parse(bxIdCliente.Text);
                            MostVideo();
                            txtNoID.Text = "";
                        }
                    }
                }
                else
                {
                    txtNoID.Text = "Este ID de cliente no existe";
                }
            }
            catch (Exception)
            {
                txtNoID.Text = "ID Cliente tiene que ser un numero";
                Console.WriteLine("ID Cliente tiene que ser un numero");
            }
        }
    }
}
