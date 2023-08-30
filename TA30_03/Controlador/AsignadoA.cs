using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TA30_03.Modelo;

namespace TA30_03.Controlador
{
    internal class AsignadoA
    {
        //Lista de AsignadoA
        List<AsignadoAMod> lista = new List<AsignadoAMod>();
        //Añadir AsignadoA a la lista
        public void AñadirALista(AsignadoAMod modelo)
        {
            lista.Add(modelo);
        }
        //Obtener toda la lista
        public List<AsignadoAMod> ObtenerLista()
        {
            return lista;
        }
    }
}
