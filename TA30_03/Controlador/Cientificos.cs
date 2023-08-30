using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TA30_03.Modelo;

namespace TA30_03.Controlador
{
    internal class Cientificos
    {
        //Lista de Cientificos
        List<CientificosMod> lista = new List<CientificosMod>();
        //Añadir Cientifico a la lista
        public void AñadirALista(CientificosMod modelo)
        {
            lista.Add(modelo);
        }
        //Obtener toda la lista
        public List<CientificosMod> ObtenerLista()
        {
            return lista;
        }

    }
}
