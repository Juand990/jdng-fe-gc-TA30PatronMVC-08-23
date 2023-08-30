using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TA30_03.Controlador;
using TA30_03.Modelo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TA30_03
{
    public partial class Form1 : Form
    {
        //Objetos
        Cientificos ctfs = new Cientificos();
        Proyectos pyts = new Proyectos();
        AsignadoA asiga = new AsignadoA();
        //Cientifico obtenido del ListView
        CientificosMod ctfsObtenido = null;
        //Proyecto obtenido del ListView
        ProyectosMod pytsObtenido = null;
        //AsignadoA obtenido del ListView
        AsignadoAMod asigaObtenido = null;
        public Form1()
        {
            InitializeComponent();
            lsvCientificos.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lsvProy.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lsvAsignado.HeaderStyle = ColumnHeaderStyle.Nonclickable;
        }

        //Obtenemos la Lista de Cientificos, y refrescamos el ListView
        private void CargCient()
        {
            List<CientificosMod> lista = ctfs.ObtenerLista();
            int listCount = lista.Count;
            //------------
            lsvCientificos.Items.Clear();
            for (int i = 0; i < listCount; i++)
            {
                ListViewItem item = new ListViewItem(lista[i].Id.ToString());
                item.SubItems.Add(lista[i].DNI);
                item.SubItems.Add(lista[i].NOMApels);
                lsvCientificos.Items.Add(item);

            }
        }
        //Añadimos un Cientifico a la Lista
        private void btnCrCient_Click(object sender, EventArgs e)
        {
            CientificosMod modelo = new CientificosMod(
            bxDNI.Text,
            bxNomApels.Text);
            ctfs.AñadirALista(modelo);
            bxDNI.Text = "";
            bxNomApels.Text = "";
            CargCient();
        }
        //Eliminamos de la lista el Cientifico y de Asignado tambien
        private void btnBCient_Click(object sender, EventArgs e)
        {
            try
            {
                List<CientificosMod> lsCient = ctfs.ObtenerLista();
                List<AsignadoAMod> lsAsig = asiga.ObtenerLista();
                int lsAsigCount = lsAsig.Count;
                int listCount = lsCient.Count;
                string elemento = lsvCientificos.SelectedItems[0].Text;
                for (int i = 0; i < listCount; i++)
                {
                    if (lsCient[i].Id.ToString() == elemento)
                    {
                        for (int j = 0; j < lsAsigCount; j++)
                        {
                            if (lsAsig[j].Cien_dni == lsCient[i].DNI)
                            {
                                lsAsig.Remove(lsAsig[j]);
                                CargAsignado();
                                break;                                
                            }
                        }
                        lsCient.Remove(lsCient[i]);
                        CargCient();
                    }
                }                
            }
            catch (Exception)
            {
                Console.WriteLine("Seleccion no valida");
            }

        }
        //Mostramos el Cientifico del ListView en los TextBox
        private void btnMoCient_Click(object sender, EventArgs e)
        {
            try
            {
                List<CientificosMod> lista = ctfs.ObtenerLista();
                int listCount = lista.Count;
                string elemento = lsvCientificos.SelectedItems[0].Text;
                for (int i = 0; i < listCount; i++)
                {
                    if (lista[i].Id.ToString() == elemento)
                    {
                        ctfsObtenido = lista[i];
                        bxDNI.Text = lista[i].DNI;
                        bxNomApels.Text = lista[i].NOMApels;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Seleccion no valida");
            }

        }
        //Actualizamos el Cientifico, despues de mostrarlos en los TextBox
        private void btnAcCient_Click(object sender, EventArgs e)
        {
            List<CientificosMod> lista = ctfs.ObtenerLista();
            int listCount = lista.Count;
            for (int i = 0; i < listCount; i++)
            {
                if (lista[i] == ctfsObtenido)
                {
                    lista[i].DNI = bxDNI.Text;
                    lista[i].NOMApels = bxNomApels.Text;
                    CargCient();
                }
            }
            bxDNI.Text = "";
            bxNomApels.Text = "";
        }

        //--------PROYECTO----------
        //Obtenemos la Lista de Proyectos, y refrescamos el ListView
        private void CargProy()
        {
            List<ProyectosMod> lista = pyts.ObtenerLista();
            int listCount = lista.Count;
            //------------
            lsvProy.Items.Clear();
            for (int i = 0; i < listCount; i++)
            {
                ListViewItem item = new ListViewItem(lista[i].Id);
                item.SubItems.Add(lista[i].NOMBRE);
                item.SubItems.Add(lista[i].HORAS.ToString());
                lsvProy.Items.Add(item);
            }
        }
        //Añadimos un Proyecto a la Lista
        private void btnCrProy_Click(object sender, EventArgs e)
        {
            try
            {
                ProyectosMod modelo = new ProyectosMod(
                bxIdProy.Text,
                bxNomProy.Text,
                int.Parse(bxHoras.Text));
                pyts.AñadirALista(modelo);
                bxIdProy.Text = "";
                bxNomProy.Text = "";
                bxHoras.Text = "";
                msjProy.Text = "";
                CargProy();
            }
            catch (Exception)
            {
                msjProy.Text = "Horas tiene que ser numeros.";
            }
        }
        //Eliminamos de la lista el Proyecto y de Asignado tambien
        private void btnBorProy_Click(object sender, EventArgs e)
        {
            try
            {
                List<ProyectosMod> lsProy = pyts.ObtenerLista();
                List<AsignadoAMod> lsAsig = asiga.ObtenerLista();
                int lsAsigCount = lsAsig.Count;
                int listCount = lsProy.Count;
                string elemento = lsvProy.SelectedItems[0].Text;
                for (int i = 0; i < listCount; i++)
                {
                    if (lsProy[i].Id == elemento)
                    {
                        for (int j = 0; j < lsAsigCount; j++)
                        {
                            if (lsAsig[j].Proy_Nombre == lsProy[i].NOMBRE)
                            {
                                lsAsig.Remove(lsAsig[j]);
                                CargAsignado();
                                break;
                            }
                        }
                        lsProy.Remove(lsProy[i]);
                        CargProy();
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Seleccion no valida");
            }
        }
        //Mostramos el Proyecto del ListView en los TextBox
        private void btnMosProy_Click(object sender, EventArgs e)
        {
            try
            {
                List<ProyectosMod> lista = pyts.ObtenerLista();
                int listCount = lista.Count;
                string elemento = lsvProy.SelectedItems[0].Text;
                for (int i = 0; i < listCount; i++)
                {
                    if (lista[i].Id.ToString() == elemento)
                    {
                        pytsObtenido = lista[i];
                        bxIdProy.Text = lista[i].Id;
                        bxNomProy.Text = lista[i].NOMBRE;
                        bxHoras.Text = lista[i].HORAS.ToString();
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Seleccion no valida");
            }
        }
        //Actualizamos el Proyecto, despues de mostrarlos en los TextBox
        private void btnActProy_Click(object sender, EventArgs e)
        {
            List<ProyectosMod> lista = pyts.ObtenerLista();
            int listCount = lista.Count;
            for (int i = 0; i < listCount; i++)
            {
                if (lista[i] == pytsObtenido)
                {
                    try
                    {
                        lista[i].Id = bxIdProy.Text;
                        lista[i].NOMBRE = bxNomProy.Text;
                        lista[i].HORAS = int.Parse(bxHoras.Text);
                        CargProy();
                        bxIdProy.Text = "";
                        bxNomProy.Text = "";
                        bxHoras.Text = "";
                        msjProy.Text = "";
                    }
                    catch (Exception)
                    {
                        msjProy.Text = "Horas tiene que ser numeros.";
                    }
                }
            }
        }

        //--------ASIGNADO A----------
        private void CargAsignado()
        {
            List<AsignadoAMod> lista = asiga.ObtenerLista();
            int listCount = lista.Count;
            //------------
            lsvAsignado.Items.Clear();
            for (int i = 0; i < listCount; i++)
            {
                ListViewItem item = new ListViewItem(lista[i].Id.ToString());
                item.SubItems.Add(lista[i].Cien_dni);
                item.SubItems.Add(lista[i].Proy_Nombre);
                lsvAsignado.Items.Add(item);
            }
        }
        //Añadimos un AsignadoA a la Lista
        private void btnCrAsig_Click(object sender, EventArgs e)
        {            
            List<CientificosMod> lista = ctfs.ObtenerLista();
            List<ProyectosMod> lstPro = pyts.ObtenerLista();
            int listCount = lista.Count;
            int listCountPro = lstPro.Count;
            bool DNIEsta = false;
            bool IDEsta = false;
            for (int i = 0; i < listCount; i++)
            {
                if (lista[i].DNI == bxAsigCient.Text)
                {
                    DNIEsta = true; break;
                }
            }
            for (int i = 0; i < listCountPro; i++)
            {
                if (lstPro[i].Id == bxAsigProy.Text)
                {
                    IDEsta = true; break;
                }
            }
            if (DNIEsta && IDEsta)
            {
                AsignadoAMod modelo = new AsignadoAMod(
                bxAsigCient.Text,
                bxAsigProy.Text);
                asiga.AñadirALista(modelo);
                bxAsigCient.Text = "";
                bxAsigProy.Text = "";
                CargAsignado();
                msjAsig.Text = "";
            }
            else
            {
                msjAsig.Text = "Cientifico/Proyecto no existe";
            }
        }
        //Eliminamos de la lista el AsignadoA
        private void btnBorAsig_Click(object sender, EventArgs e)
        {
            try
            {
                List<AsignadoAMod> lsAsig = asiga.ObtenerLista();
                int lsAsigCount = lsAsig.Count;
                string elemento = lsvAsignado.SelectedItems[0].Text;
                for (int i = 0; i < lsAsigCount; i++)
                {
                    if (lsAsig[i].Id.ToString() == elemento)
                    {
                        lsAsig.Remove(lsAsig[i]);
                        CargAsignado();
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Seleccion no valida");
            }
        }
        //Mostramos el AsignadoA del ListView en los TextBox
        private void btnMosAsig_Click(object sender, EventArgs e)
        {
            try
            {
                List<AsignadoAMod> lista = asiga.ObtenerLista();
                int listCount = lista.Count;
                string elemento = lsvAsignado.SelectedItems[0].Text;
                for (int i = 0; i < listCount; i++)
                {
                    if (lista[i].Id.ToString() == elemento)
                    {
                        asigaObtenido = lista[i];
                        bxAsigCient.Text = lista[i].Cien_dni;
                        bxAsigProy.Text = lista[i].Proy_Nombre;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Seleccion no valida");
            }
        }
        //Actualizamos el AsignadoA, despues de mostrarlos en los TextBox
        private void btnActAsig_Click(object sender, EventArgs e)
        {
            AsignadoAMod modelo = new AsignadoAMod(
                bxAsigCient.Text,
                bxAsigProy.Text);
            List<AsignadoAMod> asig = asiga.ObtenerLista();
            List<CientificosMod> lista = ctfs.ObtenerLista();
            List<ProyectosMod> lstPro = pyts.ObtenerLista();
            int listCoAsi = asig.Count;
            int listCount = lista.Count;
            int listCountPro = lstPro.Count;
            bool DNIEsta = false;
            bool IDEsta = false;
            for (int i = 0; i < listCount; i++)
            {
                if (lista[i].DNI == bxAsigCient.Text)
                {
                    DNIEsta = true; break;
                }
            }
            for (int i = 0; i < listCountPro; i++)
            {
                if (lstPro[i].Id == bxAsigProy.Text)
                {
                    IDEsta = true; break;
                }
            }
            if (DNIEsta && IDEsta)
            {
                for (int i = 0; i < listCoAsi; i++)
                {
                    if (asig[i] == asigaObtenido)
                    {
                        asig[i].Proy_Nombre = bxAsigProy.Text;
                        asig[i].Cien_dni = bxAsigCient.Text;
                        CargAsignado();
                        bxAsigProy.Text = "";
                        bxAsigCient.Text = "";
                        msjAsig.Text = "";
                    }
                }
            }
            else
            {
                msjAsig.Text = "Cientifico/Proyecto no existe";
            }
        }
    }
}
