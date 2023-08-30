using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TA30_01.Modelo;

namespace TA30_01.Controlador
{
    internal class Cliente
    {
        //Lista de ClienteModelo
        List<ClienteModelo> lista=new List<ClienteModelo>();
        //Añadimos un elemento a la lista
        public void Guardar(ClienteModelo modelo)
        {
            lista.Add(modelo);
        }
        //Obtenemos toda la lista
        public List<ClienteModelo> Mostrar()
        {
            return lista;
        }

    }
}
