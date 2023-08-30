using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TA30_03.Modelo;

namespace TA30_03.Controlador
{
    internal class Proyectos
    {
        //Lista de Proyectos
        List<ProyectosMod> lista = new List<ProyectosMod>();
        //Añadir Proyecto a la lista
        public void AñadirALista(ProyectosMod modelo)
        {
            lista.Add(modelo);
        }
        //Obtener toda la lista
        public List<ProyectosMod> ObtenerLista()
        {
            return lista;
        }
    }
}
